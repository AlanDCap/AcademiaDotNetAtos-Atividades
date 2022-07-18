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
    public class AncestriesController : Controller
    {
        private readonly CharacterSheetContext _context;

        public AncestriesController(CharacterSheetContext context)
        {
            _context = context;
        }

        // GET: Ancestries
        public async Task<IActionResult> Index()
        {
              return _context.Ancestries != null ? 
                          View(await _context.Ancestries.ToListAsync()) :
                          Problem("Entity set 'CharacterSheetContext.Ancestries'  is null.");
        }

        // GET: Ancestries/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Ancestries/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ancestryID,ancestryName,trait1,trait2,trait3")] Ancestry ancestry)
        {
            if (ModelState.IsValid)
            {
                _context.Add(ancestry);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(ancestry);
        }

        // GET: Ancestries/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Ancestries == null)
            {
                return NotFound();
            }

            var ancestry = await _context.Ancestries.FindAsync(id);
            if (ancestry == null)
            {
                return NotFound();
            }
            return View(ancestry);
        }

        // POST: Ancestries/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ancestryID,ancestryName,trait1,trait2,trait3")] Ancestry ancestry)
        {
            if (id != ancestry.ancestryID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(ancestry);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AncestryExists(ancestry.ancestryID))
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
            return View(ancestry);
        }

        // GET: Ancestries/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Ancestries == null)
            {
                return NotFound();
            }

            var ancestry = await _context.Ancestries
                .FirstOrDefaultAsync(m => m.ancestryID == id);
            if (ancestry == null)
            {
                return NotFound();
            }

            return View(ancestry);
        }

        // POST: Ancestries/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Ancestries == null)
            {
                return Problem("Entity set 'CharacterSheetContext.Ancestries'  is null.");
            }
            var ancestry = await _context.Ancestries.FindAsync(id);
            if (ancestry != null)
            {
                _context.Ancestries.Remove(ancestry);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AncestryExists(int id)
        {
          return (_context.Ancestries?.Any(e => e.ancestryID == id)).GetValueOrDefault();
        }
    }
}
