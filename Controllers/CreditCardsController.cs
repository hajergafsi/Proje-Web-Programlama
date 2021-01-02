using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Localization;
using Microsoft.AspNetCore.Localization;
using Proje.Models;

namespace Proje.Controllers
{
    public class CreditCardsController : Controller
    {
        private readonly AgencyContext _context;
        public CreditCardsController(AgencyContext context)
        {
            _context = context;
        }



        // GET: CreditCards/Create
        public IActionResult Authenticate()
        {
            return View();
        }

        // POST: CreditCards/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [Authorize]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Authenticate([Bind("CardId,number,CVV,ExpirationDate")] CreditCard creditCard)
        {
            
            if (ModelState.IsValid)
            {
                var card = await _context.CreditCards.FirstOrDefaultAsync(c => c.number == creditCard.number);
                if(card != null)
                {
                    if(card.CVV == creditCard.CVV && card.ExpirationDate.Year == creditCard.ExpirationDate.Year 
                        && card.ExpirationDate.Month == creditCard.ExpirationDate.Month )
                        {
                        var book = _context.Bookings.FirstOrDefault(b => b.BookingId == creditCard.CardId);
                        book.state = "Confirmed";
                        await _context.SaveChangesAsync();
                        TempData["CardId"] = card.CardId;
                        TempData["BookingId"] = creditCard.CardId;
                        return RedirectToAction("Complete", "Payments");
                        }
                    else
                    {
                        
                        TempData["error"] = "Wrong CVV or Expiration Date";
                        return RedirectToAction(nameof(Authenticate));
                    }
                }
                TempData["error"] = "Wrong Credit Card Number";
                return RedirectToAction("Authenticate", "CreditCards");

            }
            return View(creditCard);
        }

        private bool CreditCardExists(int id)
        {
            return _context.CreditCards.Any(e => e.CardId == id);
        }
    }
}
