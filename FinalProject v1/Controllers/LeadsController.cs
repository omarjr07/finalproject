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
    public class LeadsController : Controller
    {
        private readonly FinalProject_v1Context _context;

        public LeadsController(FinalProject_v1Context context)
        {
            _context = context;
        }

        // GET: Leads
        public async Task<IActionResult> Index()
        {
            return View(await _context.Leads.ToListAsync());
        }

        // GET: Leads/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var leads = await _context.Leads
                .SingleOrDefaultAsync(m => m.ID == id);
            if (leads == null)
            {
                return NotFound();
            }

            return View(leads);
        }

        // GET: Leads/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Leads/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,fName,lName,email,phone,owner")] Leads leads)
        {
            if (ModelState.IsValid)
            {
                _context.Add(leads);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(leads);
        }

        // GET: Leads/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var leads = await _context.Leads.SingleOrDefaultAsync(m => m.ID == id);
            if (leads == null)
            {
                return NotFound();
            }
            return View(leads);
        }

        // POST: Leads/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,fName,lName,email,phone,owner")] Leads leads)
        {
            if (id != leads.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(leads);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!LeadsExists(leads.ID))
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
            return View(leads);
        }

        // GET: Leads/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var leads = await _context.Leads
                .SingleOrDefaultAsync(m => m.ID == id);
            if (leads == null)
            {
                return NotFound();
            }

            return View(leads);
        }

        // POST: Leads/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var leads = await _context.Leads.SingleOrDefaultAsync(m => m.ID == id);
            _context.Leads.Remove(leads);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool LeadsExists(int id)
        {
            return _context.Leads.Any(e => e.ID == id);
        }
    }
}
