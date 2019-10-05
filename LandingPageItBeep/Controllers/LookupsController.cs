using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using LandingPageItBeep.DAL;
using LandingPageItBeep.Models;

namespace LandingPageItBeep.Controllers
{
    public class LookupsController : Controller
    {
        private readonly LandingPageItBeepContext _context;

        public LookupsController(LandingPageItBeepContext context)
        {
            _context = context;
        }

        // GET: Lookups
        public async Task<IActionResult> Index()
        {
            return View(await _context.Lookups.ToListAsync());
        }

        // GET: Lookups/Details/5
        public async Task<Lookup> Details(int? id)
        {
            if (id == null)
            {
                return null;
            }

            var lookup = await _context.Lookups
                .Include(lookupCategories => lookupCategories.LookupCategories)
                .FirstOrDefaultAsync(m => m.LookupID == id);
            if (lookup == null)
            {
                return new Lookup();
            }

            return lookup;
        }

        // GET: Lookups/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Lookups/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("LookupID,LookupName,LookupNameEn,CraetedBy,IsDeleted")] Lookup lookup)
        {
            if (ModelState.IsValid)
            {
                _context.Add(lookup);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(lookup);
        }

        // GET: Lookups/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var lookup = await _context.Lookups.FindAsync(id);
            if (lookup == null)
            {
                return NotFound();
            }
            return View(lookup);
        }

        // POST: Lookups/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("LookupID,LookupName,LookupNameEn,CraetedBy,IsDeleted")] Lookup lookup)
        {
            if (id != lookup.LookupID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(lookup);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!LookupExists(lookup.LookupID))
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
            return View(lookup);
        }

        // GET: Lookups/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var lookup = await _context.Lookups
                .FirstOrDefaultAsync(m => m.LookupID == id);
            if (lookup == null)
            {
                return NotFound();
            }

            return View(lookup);
        }

        // POST: Lookups/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var lookup = await _context.Lookups.FindAsync(id);
            _context.Lookups.Remove(lookup);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool LookupExists(int id)
        {
            return _context.Lookups.Any(e => e.LookupID == id);
        }
    }
}
