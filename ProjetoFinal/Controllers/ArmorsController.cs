using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using AtosProjetoFinal.Data;
using AtosProjetoFinal.Models;

namespace AtosProjetoFinal.Controllers
{
    public class ArmorsController : Controller
    {
        private readonly CharacterSheetContext _context;

        public ArmorsController(CharacterSheetContext context)
        {
            _context = context;
        }

        // GET: Armors
        public async Task<IActionResult> Index()
        {
              return _context.Armors != null ? 
                          View(await _context.Armors.ToListAsync()) :
                          Problem("Entity set 'CharacterSheetContext.Armors'  is null.");
        }

        // GET: Armors/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Armors/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("armorID,armorName,armorGroup,armorBulk,armorProtectionValue,armorDescription")] Armor armor)
        {
            if (ModelState.IsValid)
            {
                _context.Add(armor);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(armor);
        }

        // GET: Armors/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Armors == null)
            {
                return NotFound();
            }

            var armor = await _context.Armors.FindAsync(id);
            if (armor == null)
            {
                return NotFound();
            }
            return View(armor);
        }

        // POST: Armors/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("armorID,armorName,armorGroup,armorBulk,armorProtectionValue,armorDescription")] Armor armor)
        {
            if (id != armor.armorID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(armor);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ArmorExists(armor.armorID))
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
            return View(armor);
        }

        // GET: Armors/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Armors == null)
            {
                return NotFound();
            }

            var armor = await _context.Armors
                .FirstOrDefaultAsync(m => m.armorID == id);
            if (armor == null)
            {
                return NotFound();
            }

            return View(armor);
        }

        // POST: Armors/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Armors == null)
            {
                return Problem("Entity set 'CharacterSheetContext.Armors'  is null.");
            }
            var armor = await _context.Armors.FindAsync(id);
            if (armor != null)
            {
                _context.Armors.Remove(armor);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ArmorExists(int id)
        {
          return (_context.Armors?.Any(e => e.armorID == id)).GetValueOrDefault();
        }
    }
}
