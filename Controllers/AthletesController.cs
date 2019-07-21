using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using UniversityRunningTeam.Data;
using UniversityRunningTeam.Models;

namespace UniversityRunningTeam.Controllers
{
    public class AthletesController : Controller
    {
        private readonly SchoolContext _context;

        public AthletesController(SchoolContext context)
        {
            _context = context;
        }

        // GET: Athletes

        public async Task<IActionResult> Index(
        string sortOrder,
        string currentFilter,
        string searchString,
        int? pageNumber)
        {
            ViewData["CurrentSort"] = sortOrder;
            ViewData["NameSortParm"] =
                String.IsNullOrEmpty(sortOrder) ? "LastName_desc" : "";
            ViewData["DateSortParm"] =
                sortOrder == "Don" ? "Dob_desc" : "Dob";

            if (searchString != null)
            {
                pageNumber = 1;
            }
            else
            {
                searchString = currentFilter;
            }


            ViewData["CurrentFilter"] = searchString;

            var athletes = from s in _context.Athletes
                           select s;
            if (!String.IsNullOrEmpty(searchString))
            {
                athletes = athletes.Where(s => s.LastName.Contains(searchString)
                                       || s.FirstName.Contains(searchString));
            }

            switch (sortOrder)
            {
                case "name_desc":
                    athletes = athletes.OrderByDescending(s => s.LastName);
                    break;
                case "Date":
                    athletes = athletes.OrderBy(s => s.Dob);
                    break;
                case "date_desc":
                    athletes = athletes.OrderByDescending(s => s.Dob);
                    break;
                default:
                    athletes = athletes.OrderBy(s => s.LastName);
                    break;
            }
            int pageSize = 3;
            return View(await PaginatedList<Athlete>.CreateAsync(athletes.AsNoTracking(), pageNumber ?? 1, pageSize));

        }

        // GET: Athletes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var athlete = await _context.Athletes
                .FirstOrDefaultAsync(m => m.ID == id);
            if (athlete == null)
            {
                return NotFound();
            }

            return View(athlete);
        }

        // GET: Athletes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Athletes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,LastName,MiddleName,FirstName,Dob,Gender,Weight,Height")] Athlete athlete)
        {
            if (ModelState.IsValid)
            {
                _context.Add(athlete);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(athlete);
        }

        // GET: Athletes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var athlete = await _context.Athletes.FindAsync(id);
            if (athlete == null)
            {
                return NotFound();
            }
            return View(athlete);
        }

        // POST: Athletes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,LastName,MiddleName,FirstName,Dob,Gender,Weight,Height")] Athlete athlete)
        {
            if (id != athlete.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(athlete);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AthleteExists(athlete.ID))
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
            return View(athlete);
        }

        // GET: Athletes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var athlete = await _context.Athletes
                .FirstOrDefaultAsync(m => m.ID == id);
            if (athlete == null)
            {
                return NotFound();
            }

            return View(athlete);
        }

        // POST: Athletes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var athlete = await _context.Athletes.FindAsync(id);
            _context.Athletes.Remove(athlete);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AthleteExists(int id)
        {
            return _context.Athletes.Any(e => e.ID == id);
        }
    }
}
