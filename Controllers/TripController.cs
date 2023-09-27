using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ASP.NET_CRUD_APP.Data;
using ASP.NET_CRUD_APP.Models;

namespace ASP.NET_CRUD_APP.Controllers
{
    public class TripController : Controller
    {
        private readonly ApplicationDbContext _context;

        public TripController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Trip
        public async Task<IActionResult> Index()
        {
              return _context.Trip != null ? 
                          View(await _context.Trip.ToListAsync()) :
                          Problem("Entity set 'ApplicationDbContext.Trip'  is null.");
        }

        // GET: Trip/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Trip == null)
            {
                return NotFound();
            }

            var trip = await _context.Trip
                .FirstOrDefaultAsync(m => m.Id == id);
            if (trip == null)
            {
                return NotFound();
            }

            return View(trip);
        }

        // GET: Trip/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Trip/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,StartingMiles,EndingMiles,TotalMiles,Stops,TotalPay, Pallets, IsTeamRoute, SuperStop")] Trip trip)
        {
            if (ModelState.IsValid)
            {
                trip.TotalMiles = trip.EndingMiles - trip.StartingMiles;

                if (trip.IsTeamRoute == true)
                {
                    trip.TotalPay = (trip.TotalMiles * 0.38m) + (trip.Stops * 20) + (trip.Pallets * 1) + (trip.SuperStop * 36m);
                }
                else
                {
                    trip.TotalPay = (trip.TotalMiles * 0.51m) + (trip.Stops * 22) + (trip.Pallets * 1 ) + (trip.SuperStop * 36m);
                }

                _context.Add(trip);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(trip);
        }

        // GET: Trip/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Trip == null)
            {
                return NotFound();
            }

            var trip = await _context.Trip.FindAsync(id);
            if (trip == null)
            {
                return NotFound();
            }
            return View(trip);
        }

        // POST: Trip/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,StartingMiles,EndingMiles,TotalMiles,Stops,TotalPay")] Trip trip)
        {
            if (id != trip.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(trip);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TripExists(trip.Id))
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
            return View(trip);
        }

        // GET: Trip/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Trip == null)
            {
                return NotFound();
            }

            var trip = await _context.Trip
                .FirstOrDefaultAsync(m => m.Id == id);
            if (trip == null)
            {
                return NotFound();
            }

            return View(trip);
        }

        // POST: Trip/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Trip == null)
            {
                return Problem("Entity set 'ApplicationDbContext.Trip'  is null.");
            }
            var trip = await _context.Trip.FindAsync(id);
            if (trip != null)
            {
                _context.Trip.Remove(trip);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TripExists(int id)
        {
          return (_context.Trip?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
