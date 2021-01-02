using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Proje.Models;

namespace Proje.Controllers
{
    public class PaymentsController : Controller
    {
        private readonly AgencyContext _context;

        public PaymentsController(AgencyContext context)
        {
            _context = context;
        }


        // GET: Payments/Create
        [Authorize]
        public IActionResult Complete()
        {
            return View();
        }

        // POST: Payments/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [Authorize]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Complete([Bind("PaymentId,BookingId,CardId")] Payment payment)
        {
            if (ModelState.IsValid)
            {
                payment.payment_date = DateTime.Now;
                var b = _context.Bookings.FirstOrDefault(b => b.BookingId == payment.BookingId);
                b.PaymentId = payment.PaymentId;
                _context.Add(payment);                
                await _context.SaveChangesAsync();
                var pay = await _context.Payments.FirstOrDefaultAsync(b => b.BookingId == payment.BookingId);
                b.PaymentId = pay.PaymentId;
                await _context.SaveChangesAsync();
                return RedirectToAction("Index","Home");
            }
            return View(payment);
        }

        private bool PaymentExists(int id)
        {
            return _context.Payments.Any(e => e.PaymentId == id);
        }
    }
}
