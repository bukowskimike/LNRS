using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using LNRS.Data;
using LNRS.Models;

namespace LNRS.Controllers
{
    public class PresencesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public PresencesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Presences
        public async Task<IActionResult> Index()
        {
            return View(await _context.Presence.ToListAsync());
        }

        // GET: Presences/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var presence = await _context.Presence
                .FirstOrDefaultAsync(m => m.Id == id);
            if (presence == null)
            {
                return NotFound();
            }

            return View(presence);
        }

        // GET: Presences/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Presences/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Email,StartTime,CauseStart,EndTime,CauseEnd")] Presence presence)
        {
            if (ModelState.IsValid)
            {
                _context.Add(presence);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(presence);
        }

        // GET: Presences/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var presence = await _context.Presence.FindAsync(id);
            if (presence == null)
            {
                return NotFound();
            }
            return View(presence);
        }

        // POST: Presences/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Email,StartTime,CauseStart,EndTime,CauseEnd")] Presence presence)
        {
            if (id != presence.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(presence);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PresenceExists(presence.Id))
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
            return View(presence);
        }

        // GET: Presences/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var presence = await _context.Presence
                .FirstOrDefaultAsync(m => m.Id == id);
            if (presence == null)
            {
                return NotFound();
            }

            return View(presence);
        }

        // POST: Presences/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var presence = await _context.Presence.FindAsync(id);
            _context.Presence.Remove(presence);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PresenceExists(int id)
        {
            return _context.Presence.Any(e => e.Id == id);
        }
    }
}
