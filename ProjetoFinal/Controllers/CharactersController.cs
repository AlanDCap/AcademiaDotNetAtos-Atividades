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
    public class CharactersController : Controller
    {
        private readonly CharacterSheetContext _context;

        public CharactersController(CharacterSheetContext context)
        {
            _context = context;
        }

        // GET: Characters
        public async Task<IActionResult> Index()
        {
              return _context.Characters != null ? 
                          View(await _context.Characters
                          .Include(a => a.Ancestry)
                          .ToListAsync()) :
                          Problem("Entity set 'CharacterSheetContext.Characters'  is null.");
        }

        // GET: Characters/Details/5
        // Seção central da aplicação, ela agrega em si todas as informações relativas à personagem,
        // por isso a necessidade de incluir os modelos. Nesta view, as informações estão organizadas
        // e são apresentadas ao usuário, formando a ficha da personagem.
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Characters == null)
            {
                return NotFound();
            }

            var character = await _context.Characters
                .Include(a => a.Ancestry)
                .Include(r => r.Role)
                .Include(c => c.Class)
                .Include(cA => cA.CharAttributes)
                .Include(cW => cW.CharWeapon)
                .ThenInclude(w => w.Weapon)
                .Include(cAr => cAr.CharArmor)
                .ThenInclude(ar => ar.Armor)
                .Include(i => i.CharItem)
                .ThenInclude(i => i.Item)
                .FirstOrDefaultAsync(m => m.characterID == id);
            if (character == null)
            {
                return NotFound();
            }

            return View(character);
        }

        // GET: Characters/Create
        // Esta ação utiliza viewModels a fim de administrar mais de uma model numa única view.
        // A criação de personagem utiliza id do BD das tabelas de ancestralidade, sub-classe e classe
        public async Task<IActionResult> Create()
        {
            var ancestry = await _context.Ancestries.ToListAsync();
            var role = await _context.Roles.ToListAsync();
            var classes = await _context.Classes.ToListAsync();
            var charViewModel = new CharViewModel { Ancestry = ancestry, Role = role, Class = classes };

            return View(charViewModel);
        }

        // POST: Characters/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Character character)
        {
            
                _context.Add(character);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            
        }
        //ação alternativa de criar personagem usada para avançar para a view de adição dos atributos
        public async Task<IActionResult> AddAttributes(Character character)
        {

            _context.Add(character);
            await _context.SaveChangesAsync();
            return RedirectToAction("Create", "CharAttributes");

        }
        public IActionResult EquipChar(string BtnValue)
        {
            return RedirectToAction("Create", BtnValue);
        }

        // GET: Characters/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Characters == null)
            {
                return NotFound();
            }

            var character = await _context.Characters.FindAsync(id);
            if (character == null)
            {
                return NotFound();
            }
            return View(character);
        }

        // POST: Characters/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, Character character)
        {
            if (id != character.characterID)
            {
                return NotFound();
            }
            try
            {
            _context.Update(character);
            //as próximas três linhas foram inseridas para solucionar conflito de gravação de fk no BD
            _context.Entry(character).Property(u => u.ancestryID).IsModified = false;
            _context.Entry(character).Property(u => u.classID).IsModified = false;
            _context.Entry(character).Property(u => u.roleID).IsModified = false;
            await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CharacterExists(character.characterID))
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

        // GET: Characters/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Characters == null)
            {
                return NotFound();
            }

            var character = await _context.Characters
                .FirstOrDefaultAsync(m => m.characterID == id);
            if (character == null)
            {
                return NotFound();
            }

            return View(character);
        }

        // POST: Characters/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Characters == null)
            {
                return Problem("Entity set 'CharacterSheetContext.Characters'  is null.");
            }
            var character = await _context.Characters.FindAsync(id);
            if (character != null)
            {
                _context.Characters.Remove(character);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CharacterExists(int id)
        {
          return (_context.Characters?.Any(e => e.characterID == id)).GetValueOrDefault();
        }
    }
}
