using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MagicCalendar.Data;
using MagicCalendar.Models;

namespace MagicCalendar.Controllers
{
    public class EventSoftwareController : Controller
    {
        private readonly MagicCalendarContext _context;

        public EventSoftwareController(MagicCalendarContext context)
        {
            _context = context;
        }

        // GET: EventSoftware
        public async Task<IActionResult> Index()
        {
            return View(await _context.EventSoftware.ToListAsync());
        }

        // GET: EventSoftware/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var eventSoftware = await _context.EventSoftware
                .FirstOrDefaultAsync(m => m.EventSoftwareID == id);
            if (eventSoftware == null)
            {
                return NotFound();
            }

            return View(eventSoftware);
        }

        // GET: EventSoftware/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: EventSoftware/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("EventSoftwareID,Name,URL")] EventSoftware eventSoftware)
        {
            if (ModelState.IsValid)
            {
                _context.Add(eventSoftware);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(eventSoftware);
        }

        // GET: EventSoftware/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var eventSoftware = await _context.EventSoftware.FindAsync(id);
            if (eventSoftware == null)
            {
                return NotFound();
            }
            return View(eventSoftware);
        }

        // POST: EventSoftware/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("EventSoftwareID,Name,URL")] EventSoftware eventSoftware)
        {
            if (id != eventSoftware.EventSoftwareID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(eventSoftware);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!EventSoftwareExists(eventSoftware.EventSoftwareID))
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
            return View(eventSoftware);
        }

        // GET: EventSoftware/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var eventSoftware = await _context.EventSoftware
                .FirstOrDefaultAsync(m => m.EventSoftwareID == id);
            if (eventSoftware == null)
            {
                return NotFound();
            }

            return View(eventSoftware);
        }

        // POST: EventSoftware/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var eventSoftware = await _context.EventSoftware.FindAsync(id);
            if (eventSoftware != null)
            {
                _context.EventSoftware.Remove(eventSoftware);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool EventSoftwareExists(int id)
        {
            return _context.EventSoftware.Any(e => e.EventSoftwareID == id);
        }
    }
}
