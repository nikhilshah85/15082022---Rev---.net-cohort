using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using shoppingAPP.Models.EF;

namespace shoppingAPP.Controllers
{
    public class trainingController : Controller
    {
        private readonly shoppingDBContext _context = new shoppingDBContext();

        //public trainingController(shoppingDBContext context)
        //{
        //    _context = context;
        //}

        // GET: training
        public async Task<IActionResult> Index()
        {
              return _context.Traininginfos != null ? 
                          View(await _context.Traininginfos.ToListAsync()) :
                          Problem("Entity set 'shoppingDBContext.Traininginfos'  is null.");
        }

        // GET: training/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Traininginfos == null)
            {
                return NotFound();
            }

            var traininginfo = await _context.Traininginfos
                .FirstOrDefaultAsync(m => m.TId == id);
            if (traininginfo == null)
            {
                return NotFound();
            }

            return View(traininginfo);
        }

        // GET: training/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: training/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("TId,MyName,MyFavTechSoFar,MyFeedback,MyComments")] Traininginfo traininginfo)
        {
            if (ModelState.IsValid)
            {
                _context.Add(traininginfo);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(traininginfo);
        }

        // GET: training/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Traininginfos == null)
            {
                return NotFound();
            }

            var traininginfo = await _context.Traininginfos.FindAsync(id);
            if (traininginfo == null)
            {
                return NotFound();
            }
            return View(traininginfo);
        }

        // POST: training/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("TId,MyName,MyFavTechSoFar,MyFeedback,MyComments")] Traininginfo traininginfo)
        {
            if (id != traininginfo.TId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(traininginfo);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TraininginfoExists(traininginfo.TId))
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
            return View(traininginfo);
        }

        // GET: training/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Traininginfos == null)
            {
                return NotFound();
            }

            var traininginfo = await _context.Traininginfos
                .FirstOrDefaultAsync(m => m.TId == id);
            if (traininginfo == null)
            {
                return NotFound();
            }

            return View(traininginfo);
        }

        // POST: training/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Traininginfos == null)
            {
                return Problem("Entity set 'shoppingDBContext.Traininginfos'  is null.");
            }
            var traininginfo = await _context.Traininginfos.FindAsync(id);
            if (traininginfo != null)
            {
                _context.Traininginfos.Remove(traininginfo);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TraininginfoExists(int id)
        {
          return (_context.Traininginfos?.Any(e => e.TId == id)).GetValueOrDefault();
        }
    }
}
