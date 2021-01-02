using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Proje.Models;

namespace Proje.Controllers
{
    public class BookingsController : Controller
    {
        private readonly AgencyContext _context;

        public BookingsController(AgencyContext context,UserManager<User> user)
        {
            _context = context;
        }

        // GET: Bookings
        [Authorize]
        public async Task<IActionResult> Index(string id)
        {
            var bookings = await _context.Bookings.Where(b => b.customerId == TempData["userId"]).ToListAsync();
            foreach (var b in bookings)
            {
                var t = await _context.Tours.Where(t => t.TourId == b.TourId).FirstOrDefaultAsync();
                b.tour = t;
            }
            return View(bookings);
        }

        // GET: Bookings/Details/5
        [Authorize]
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var booking = await _context.Bookings
                .FirstOrDefaultAsync(m => m.BookingId == id);
            var user = _context.Users.FirstOrDefault(x => x.Id == booking.customerId);
            var tour = _context.Tours.FirstOrDefault(x => x.TourId == booking.TourId);
            booking.customer = user;
            booking.tour = tour;
            if (booking == null)
            {
                return NotFound();
            }
            return View(booking);
        }

        // GET: Bookings/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Bookings/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [Authorize]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("BookingId,customerId,TourId,placed_at")] Booking booking)
        {
            if (ModelState.IsValid)
            {
                booking.state = "Unconfirmed";
                _context.Add(booking);
                await _context.SaveChangesAsync();
                TempData["BookingId"] = booking.BookingId;
                TempData["error"] = null;
                return RedirectToAction("Authenticate", "CreditCards");
            }
            return View(booking);
        }


        // GET: Bookings/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var booking = await _context.Bookings
                .FirstOrDefaultAsync(m => m.BookingId == id);
            var tour = await _context.Tours.FirstOrDefaultAsync(t => t.TourId == booking.TourId);
            booking.tour = tour;
            var pay = _context.Payments.FirstOrDefault(x => x.PaymentId == booking.PaymentId);
            if (pay != null)
            {
                TempData["isPayedDate"] = pay.payment_date;
            }
            else
            {
                TempData["isPayedDate"] = null;
            }
            if (booking == null)
            {
                return NotFound();
            }

            return View(booking);
        }

        // POST: Bookings/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            
            var booking = await _context.Bookings.FindAsync(id);
            var pay = _context.Payments.FirstOrDefault(x => x.PaymentId == booking.PaymentId);
            if (pay != null) _context.Payments.Remove(pay);
            _context.Bookings.Remove(booking);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool BookingExists(int id)
        {
            return _context.Bookings.Any(e => e.BookingId == id);
        }
    }
}
