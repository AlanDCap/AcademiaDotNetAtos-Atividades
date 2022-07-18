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
    //controller responsável pela relação entre personagens e armaduras.
    
    public class CharArmorsController : Controller
    {
        private readonly CharacterSheetContext _context;

        public CharArmorsController(CharacterSheetContext context)
        {
            _context = context;
        }

        // GET: CharArmors
        public async Task<IActionResult> Index()
        {
            return _context.CharArmors != null ? 
                View(await _context.CharArmors
                .Include(p => p.Character)
                .Include(a => a.Armor)
                .ToListAsync()) :
                Problem("Entity set 'CharacterSheetContext.CharArmors'  is null.");
        }

        // GET: CharArmors/Create
        public async Task<IActionResult> Create()
        {
            var armor = await _context.Armors.ToListAsync();
            var character = await _context.Characters.ToListAsync();
            var equipmentViewModel = new EquipmentViewModel { Characters = character, Armors = armor };

            return View(equipmentViewModel);
        }

        // POST: CharArmors/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(CharArmor charArmor)
        {
            _context.Add(charArmor);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
            
        }

        // GET: CharArmors/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.CharArmors == null)
            {
                return NotFound();
            }

            var charArmor = await _context.CharArmors
                .Include(p => p.Character)
                .Include(a => a.Armor)
                .FirstOrDefaultAsync(m => m.charArmorID == id);
            if (charArmor == null)
            {
                return NotFound();
            }
            return View(charArmor);
        }

        // POST: CharArmors/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.CharArmors == null)
            {
                return Problem("Entity set 'CharacterSheetContext.CharArmors'  is null.");
            }
            var charArmor = await _context.CharArmors.FindAsync(id);
            if (charArmor != null)
            {
                _context.CharArmors.Remove(charArmor);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CharArmorExists(int id)
        {
          return (_context.CharArmors?.Any(e => e.charArmorID == id)).GetValueOrDefault();
        }
    }
}
