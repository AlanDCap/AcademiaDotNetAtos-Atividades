using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using AtosProjetoFinal.Data;
using AtosProjetoFinal.Models;
using AtosProjetoFinal.Models.ViewModels;

namespace AtosProjetoFinal.Controllers
{
    //controller responsável pela relação entre personagens e atributos, como força, destreza, etc.
    public class CharAttributesController : Controller
    {
        private readonly CharacterSheetContext _context;

        public CharAttributesController(CharacterSheetContext context)
        {
            _context = context;
        }

        // GET: CharAttributes
        public async Task<IActionResult> Index()
        {
            return _context.CharAttributes != null ? 
                View(await _context.CharAttributes
                .Include(p => p.Character)
                .ToListAsync()) :
                Problem("Entity set 'CharacterSheetContext.CharAttributes'  is null.");
        }
        
        // GET: CharAttributes/Create
        public async Task<IActionResult> Create()
        {
            var characters = await _context.Characters.ToListAsync();
            var attributesViewModel = new AttributesViewModel { Characters = characters };

            return View(attributesViewModel);
        }

        // POST: CharAttributes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(CharAttributes charAttributes)
        {
            //Neste trecho, usa-se um construtor para que os atributos secundários sejam calculados.
            //O usuário insere os atributos primários, e os secundários são calculados de acordo com
            //a especificação da regra do jogo de RPG. 
            CharAttributes cA=  new CharAttributes (charAttributes.characterID, charAttributes.physique, charAttributes.dexterity, charAttributes.intelligence, charAttributes.perception, charAttributes.charisma, charAttributes.conviction);
            _context.Add(cA);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        //construtor alternativo utilizado para direcionar o usuário para a lista de personagens, ao invés de retornar para o index de atributos
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> GoToCharacters(CharAttributes charAttributes)
        {
            CharAttributes cA = new CharAttributes(charAttributes.characterID, charAttributes.physique, charAttributes.dexterity, charAttributes.intelligence, charAttributes.perception, charAttributes.charisma, charAttributes.conviction);
            _context.Add(cA);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index", "Characters");
        }

        // GET: CharAttributes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.CharAttributes == null)
            {
                return NotFound();
            }

            var charAttributes = await _context.CharAttributes.FindAsync(id);
            if (charAttributes == null)
            {
                return NotFound();
            }
            return View(charAttributes);
        }

        // POST: CharAttributes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, CharAttributes charAttributes)
        {
            if (id != charAttributes.charAttributesID)
            {
                return NotFound();
            }
            try
            {
            CharAttributes cA = new CharAttributes(id, charAttributes.characterID, charAttributes.physique, charAttributes.dexterity, charAttributes.intelligence, charAttributes.perception, charAttributes.charisma, charAttributes.conviction);
            _context.Update(cA);
            _context.Entry(cA).Property(u => u.characterID).IsModified = false;
                
            await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CharAttributesExists(charAttributes.charAttributesID))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }
            return RedirectToAction(nameof(Index));
        }

        // GET: CharAttributes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.CharAttributes == null)
            {
                return NotFound();
            }

            var charAttributes = await _context.CharAttributes
                .FirstOrDefaultAsync(m => m.charAttributesID == id);
            if (charAttributes == null)
            {
                return NotFound();
            }

            return View(charAttributes);
        }

        // POST: CharAttributes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.CharAttributes == null)
            {
                return Problem("Entity set 'CharacterSheetContext.CharAttributes'  is null.");
            }
            var charAttributes = await _context.CharAttributes.FindAsync(id);
            if (charAttributes != null)
            {
                _context.CharAttributes.Remove(charAttributes);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CharAttributesExists(int id)
        {
          return (_context.CharAttributes?.Any(e => e.charAttributesID == id)).GetValueOrDefault();
        }
    }
}
