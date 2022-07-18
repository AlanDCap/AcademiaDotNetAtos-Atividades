using AtosProjetoFinal.Data;
using AtosProjetoFinal.Models;
using AtosProjetoFinal.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AtosProjetoFinal.Controllers
{
    //controller responsável pela relação entre personagens e itens 
    public class CharItemsController : Controller
    {
        private readonly CharacterSheetContext _context;

        public CharItemsController(CharacterSheetContext context)
        {
            _context = context;
        }

        // GET: CharItems
        public async Task<IActionResult> Index()
        {
            return _context.CharItems != null ?
                View(await _context.CharItems
                .Include(p => p.Character)
                .Include(i => i.Item)
                .ToListAsync()) :
                Problem("Entity set 'CharacterSheetContext.CharItems'  is null.");
        }

        // GET: CharItems/Create
        public async Task<IActionResult> Create()
        {
            var item = await _context.Items.ToListAsync();
            var character = await _context.Characters.ToListAsync();
            var equipmentViewModel = new EquipmentViewModel { Characters = character, Items = item };

            return View(equipmentViewModel);
        }

        // POST: CharItems/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(CharItem charItem)
        {
            _context.Add(charItem);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
            
        }

        // GET: CharItems/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.CharItems == null)
            {
                return NotFound();
            }

            var charItem = await _context.CharItems
                .Include(p => p.Character)
                .Include(a => a.Item)
                .FirstOrDefaultAsync(m => m.charItemID == id);
            if (charItem == null)
            {
                return NotFound();
            }

            return View(charItem);
        }

        // POST: CharItems/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.CharItems == null)
            {
                return Problem("Entity set 'CharacterSheetContext.CharItems'  is null.");
            }
            var charItem = await _context.CharItems.FindAsync(id);
            if (charItem != null)
            {
                _context.CharItems.Remove(charItem);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CharItemExists(int id)
        {
            return (_context.CharItems?.Any(e => e.charItemID == id)).GetValueOrDefault();
        }
    }
}
