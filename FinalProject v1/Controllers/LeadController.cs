using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using FinalProjec_v1.Models;
using FinalProject_v1.Models;

namespace FinalProject_v1.Controllers
{
    public class LeadController : Controller
    {
        private readonly FinalProject_v1Context _context;

        public LeadController(FinalProject_v1Context context)
        {
            _context = context;
        }

        // GET: lead
        public async Task<IActionResult> Index()
        {
            return View(await _context.lead.ToListAsync());
        }

        // GET: lead/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var lead = await _context.lead
                .SingleOrDefaultAsync(m => m.ID == id);
            if (lead == null)
            {
                return NotFound();
            }

            return View(lead);
        }

        // GET: lead/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: lead/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,fName,lName,email,phone,owner")] lead lead)
        {
            if (ModelState.IsValid)
            {
                _context.Add(lead);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(lead);
        }

        // GET: lead/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var lead = await _context.lead.SingleOrDefaultAsync(m => m.ID == id);
            if (lead == null)
            {
                return NotFound();
            }
            return View(lead);
        }

        // POST: lead/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,fName,lName,email,phone,owner")] lead lead)
        {
            if (id != lead.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(lead);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!leadExists(lead.ID))
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
            return View(lead);
        }

        // GET: lead/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var lead = await _context.lead
                .SingleOrDefaultAsync(m => m.ID == id);
            if (lead == null)
            {
                return NotFound();
            }

            return View(lead);
        }

        // POST: lead/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var lead = await _context.lead.SingleOrDefaultAsync(m => m.ID == id);
            _context.lead.Remove(lead);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool leadExists(int id)
        {
            return _context.lead.Any(e => e.ID == id);
        }
    }
}
