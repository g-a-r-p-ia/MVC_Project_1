using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WEBCHIK.Models;

namespace WEBCHIK.Controllers
{
    public class PerformanceReviewsController : Controller
    {
        private readonly HrmanagementDbContext _context;

        public PerformanceReviewsController(HrmanagementDbContext context)
        {
            _context = context;
        }

        // GET: PerformanceReviews
        public async Task<IActionResult> Index()
        {
            return View(await _context.PerformanceReviews.ToListAsync());
        }

        // GET: PerformanceReviews/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var performanceReview = await _context.PerformanceReviews
                .FirstOrDefaultAsync(m => m.Id == id);
            if (performanceReview == null)
            {
                return NotFound();
            }

            return View(performanceReview);
        }

        // GET: PerformanceReviews/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: PerformanceReviews/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,EmployeeId,ReviewDate,Rating,ReviewerId,Comments")] PerformanceReview performanceReview)
        {
            if (ModelState.IsValid)
            {
                performanceReview.Id = Guid.NewGuid();
                _context.Add(performanceReview);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(performanceReview);
        }

        // GET: PerformanceReviews/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var performanceReview = await _context.PerformanceReviews.FindAsync(id);
            if (performanceReview == null)
            {
                return NotFound();
            }
            return View(performanceReview);
        }

        // POST: PerformanceReviews/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("Id,EmployeeId,ReviewDate,Rating,ReviewerId,Comments")] PerformanceReview performanceReview)
        {
            if (id != performanceReview.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(performanceReview);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PerformanceReviewExists(performanceReview.Id))
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
            return View(performanceReview);
        }

        // GET: PerformanceReviews/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var performanceReview = await _context.PerformanceReviews
                .FirstOrDefaultAsync(m => m.Id == id);
            if (performanceReview == null)
            {
                return NotFound();
            }

            return View(performanceReview);
        }

        // POST: PerformanceReviews/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var performanceReview = await _context.PerformanceReviews.FindAsync(id);
            if (performanceReview != null)
            {
                _context.PerformanceReviews.Remove(performanceReview);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PerformanceReviewExists(Guid id)
        {
            return _context.PerformanceReviews.Any(e => e.Id == id);
        }
    }
}
