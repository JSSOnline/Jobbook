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
    public class ProfileController : Controller
    {
        private readonly JobbookContext _context;

        public ProfileController(JobbookContext context)
        {
            _context = context;
        }

        // GET: Profile
        public async Task<IActionResult> Index()
        {
            return View(await _context.JobbookProfileModel.ToListAsync());
        }

        // GET: Profile/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var jobbookProfileModel = await _context.JobbookProfileModel
                .FirstOrDefaultAsync(m => m.ID == id);
            if (jobbookProfileModel == null)
            {
                return NotFound();
            }

            return View(jobbookProfileModel);
        }

        // GET: Profile/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Profile/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,JobbookProfileFirstName,JobbookProfileLastName,JobbookProfileOpen,JobbookProfileTitle,JobbookProfileDescription,JobbookProfilePosts,JobbookProfileWork,JobbookProfileEducation")] JobbookProfileModel jobbookProfileModel)
        {
            if (ModelState.IsValid)
            {
                _context.Add(jobbookProfileModel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(jobbookProfileModel);
        }

        // GET: Profile/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var jobbookProfileModel = await _context.JobbookProfileModel.FindAsync(id);
            if (jobbookProfileModel == null)
            {
                return NotFound();
            }
            return View(jobbookProfileModel);
        }

        // POST: Profile/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,JobbookProfileFirstName,JobbookProfileLastName,JobbookProfileOpen,JobbookProfileTitle,JobbookProfileDescription,JobbookProfilePosts,JobbookProfileWork,JobbookProfileEducation")] JobbookProfileModel jobbookProfileModel)
        {
            if (id != jobbookProfileModel.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(jobbookProfileModel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!JobbookProfileModelExists(jobbookProfileModel.ID))
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
            return View(jobbookProfileModel);
        }

        // GET: Profile/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var jobbookProfileModel = await _context.JobbookProfileModel
                .FirstOrDefaultAsync(m => m.ID == id);
            if (jobbookProfileModel == null)
            {
                return NotFound();
            }

            return View(jobbookProfileModel);
        }

        // POST: Profile/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var jobbookProfileModel = await _context.JobbookProfileModel.FindAsync(id);
            _context.JobbookProfileModel.Remove(jobbookProfileModel);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool JobbookProfileModelExists(int id)
        {
            return _context.JobbookProfileModel.Any(e => e.ID == id);
        }
    }
}
