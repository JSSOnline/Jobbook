using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Jobbook.Models;

namespace Jobbook.Controllers
{
    public class CompanyController : Controller
    {
        private readonly JobbookContext _context;

        public CompanyController(JobbookContext context)
        {
            _context = context;
        }

        // GET: Company
        public async Task<IActionResult> Index()
        {
            return View(await _context.JobbookCompanyModel.ToListAsync());
        }

        // GET: Company/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var jobbookCompanyModel = await _context.JobbookCompanyModel
                .FirstOrDefaultAsync(m => m.ID == id);
            if (jobbookCompanyModel == null)
            {
                return NotFound();
            }

            return View(jobbookCompanyModel);
        }

        // GET: Company/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Company/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,JobbookCompanyName,JobbookCompanyDescription,JobbookCompanyWebsite,JobbookCompanyEmail,JobbookCompanyTel")] JobbookCompanyModel jobbookCompanyModel)
        {
            if (ModelState.IsValid)
            {
                _context.Add(jobbookCompanyModel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(jobbookCompanyModel);
        }

        // GET: Company/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var jobbookCompanyModel = await _context.JobbookCompanyModel.FindAsync(id);
            if (jobbookCompanyModel == null)
            {
                return NotFound();
            }
            return View(jobbookCompanyModel);
        }

        // POST: Company/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,JobbookCompanyName,JobbookCompanyDescription,JobbookCompanyWebsite,JobbookCompanyEmail,JobbookCompanyTel")] JobbookCompanyModel jobbookCompanyModel)
        {
            if (id != jobbookCompanyModel.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(jobbookCompanyModel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!JobbookCompanyModelExists(jobbookCompanyModel.ID))
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
            return View(jobbookCompanyModel);
        }

        // GET: Company/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var jobbookCompanyModel = await _context.JobbookCompanyModel
                .FirstOrDefaultAsync(m => m.ID == id);
            if (jobbookCompanyModel == null)
            {
                return NotFound();
            }

            return View(jobbookCompanyModel);
        }

        // POST: Company/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var jobbookCompanyModel = await _context.JobbookCompanyModel.FindAsync(id);
            _context.JobbookCompanyModel.Remove(jobbookCompanyModel);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool JobbookCompanyModelExists(int id)
        {
            return _context.JobbookCompanyModel.Any(e => e.ID == id);
        }
    }
}
