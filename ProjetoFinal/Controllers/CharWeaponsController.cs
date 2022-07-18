using AtosProjetoFinal.Data;
using AtosProjetoFinal.Models;
using AtosProjetoFinal.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AtosProjetoFinal.Controllers
{
    //controller responsável pela relação entre personagens e armas
    public class CharWeaponsController : Controller
    {
        private readonly CharacterSheetContext _context;

        public CharWeaponsController(CharacterSheetContext context)
        {
            _context = context;
        }

        // GET: CharWeapons
        public async Task<IActionResult> Index()
        {
            return _context.CharWeapons != null ?
                View(await _context.CharWeapons
                .Include(p => p.Character)
                .Include(a => a.Weapon)
                .ToListAsync()) :
                Problem("Entity set 'CharacterSheetContext.CharWeapons'  is null.");
        }


        // GET: CharWeapons/Create
        public async Task<IActionResult> Create()
        {
            var weapon = await _context.Weapons.ToListAsync();
            var character = await _context.Characters.ToListAsync();
            var equipmentViewModel = new EquipmentViewModel { Characters = character, Weapons = weapon };

            return View(equipmentViewModel);
        }

        // POST: CharWeapons/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(CharWeapon charWeapon)
        {
            _context.Add(charWeapon);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        // GET: CharWeapons/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.CharWeapons == null)
            {
                return NotFound();
            }

            var charWeapon = await _context.CharWeapons
                .Include(p => p.Character)
                .Include(a => a.Weapon)
                .FirstOrDefaultAsync(m => m.charWeaponID == id);
            if (charWeapon == null)
            {
                return NotFound();
            }

            return View(charWeapon);
        }

        // POST: CharWeapons/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.CharWeapons == null)
            {
                return Problem("Entity set 'CharacterSheetContext.CharWeapons'  is null.");
            }
            var charWeapon = await _context.CharWeapons.FindAsync(id);
            if (charWeapon != null)
            {
                _context.CharWeapons.Remove(charWeapon);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CharWeaponExists(int id)
        {
            return (_context.CharWeapons?.Any(e => e.charWeaponID == id)).GetValueOrDefault();
        }
    }
}
