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
    public class VacaturesController : Controller
    {
        private readonly JobbookContext _context;

        public VacaturesController(JobbookContext context)
        {
            _context = context;
        }

        // GET: Vacatures
        public async Task<IActionResult> Index()
        {
            return View(await _context.JobbookVacatureModel.ToListAsync());
        }

        // GET: Vacatures/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var jobbookVacatureModel = await _context.JobbookVacatureModel
                .FirstOrDefaultAsync(m => m.ID == id);
            if (jobbookVacatureModel == null)
            {
                return NotFound();
            }

            return View(jobbookVacatureModel);
        }

        // GET: Vacatures/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Vacatures/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,JobCompanyID,JobPublished,JobExpiredDate,JobTitle,JobDescription,JobLocation,JobContractType,JobContractHours,JobSeniority,JobSalary,JobDaysOff,JobExpired,JobContactEmail,JobContactTel")] JobbookVacatureModel jobbookVacatureModel)
        {
            if (ModelState.IsValid)
            {
                _context.Add(jobbookVacatureModel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(jobbookVacatureModel);
        }

        // GET: Vacatures/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var jobbookVacatureModel = await _context.JobbookVacatureModel.FindAsync(id);
            if (jobbookVacatureModel == null)
            {
                return NotFound();
            }
            return View(jobbookVacatureModel);
        }

        // POST: Vacatures/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,JobCompanyID,JobPublished,JobExpiredDate,JobTitle,JobDescription,JobLocation,JobContractType,JobContractHours,JobSeniority,JobSalary,JobDaysOff,JobExpired,JobContactEmail,JobContactTel")] JobbookVacatureModel jobbookVacatureModel)
        {
            if (id != jobbookVacatureModel.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(jobbookVacatureModel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!JobbookVacatureModelExists(jobbookVacatureModel.ID))
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
            return View(jobbookVacatureModel);
        }

        // GET: Vacatures/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var jobbookVacatureModel = await _context.JobbookVacatureModel
                .FirstOrDefaultAsync(m => m.ID == id);
            if (jobbookVacatureModel == null)
            {
                return NotFound();
            }

            return View(jobbookVacatureModel);
        }

        // POST: Vacatures/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var jobbookVacatureModel = await _context.JobbookVacatureModel.FindAsync(id);
            _context.JobbookVacatureModel.Remove(jobbookVacatureModel);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool JobbookVacatureModelExists(int id)
        {
            return _context.JobbookVacatureModel.Any(e => e.ID == id);
        }
    }
}
