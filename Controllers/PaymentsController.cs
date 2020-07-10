﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using GospelCares.Data;
using GospelCares.Models.ForIscholar;

namespace GospelCares.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PaymentsController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public PaymentsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/Payments
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Payment>>> GetPayment()
        {
            return await _context.Payment.ToListAsync();
        }

        // GET: api/Payments/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Payment>> GetPayment(Guid id)
        {
            var payment = await _context.Payment.FindAsync(id);

            if (payment == null)
            {
                return NotFound();
            }

            return payment;
        }

        [HttpGet("{SchoolId}")]
        public ActionResult<IEnumerable<Payment>> GetSchoolPayment(Guid SchoolId)
        {
            var payment = _context.Payment.Where(p => p.SchoolId == SchoolId).ToList();

            if (payment == null)
            {
                return NotFound();
            }

            return payment;
        }

        // PUT: api/Payments/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPayment(Guid id, Payment payment)
        {
            if (id != payment.PaymentId)
            {
                return BadRequest();
            }

            _context.Entry(payment).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PaymentExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Payments
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Payment>> PostPayment(Payment payment)
        {
            int termlydue = _context.TermlyDues.Where(t => t.SchoolSession == payment.SchoolSession && t.Term == payment.Term).FirstOrDefault().AmountDue;
            payment.Balance = termlydue - payment.AmountPaid;
            _context.Payment.Add(payment);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetPayment", new { id = payment.PaymentId }, payment);
        }

        [HttpPost]
        [Route("postall")]
        public async Task<ActionResult<Payment>> PostAllPayment(List<Payment> payments)
        {
            foreach (var payment in payments)
            {
                int termlydue = _context.TermlyDues.Where(t => t.SchoolSession == payment.SchoolSession && t.Term == payment.Term).FirstOrDefault().AmountDue;
                payment.Balance = termlydue - payment.AmountPaid;
                _context.Payment.Add(payment);
            }
            await _context.SaveChangesAsync();

            return CreatedAtAction("PostAllPayment", new { message = "All Payments Created Successfully"});
        }

        // DELETE: api/Payments/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Payment>> DeletePayment(Guid id)
        {
            var payment = await _context.Payment.FindAsync(id);
            if (payment == null)
            {
                return NotFound();
            }

            _context.Payment.Remove(payment);
            await _context.SaveChangesAsync();

            return payment;
        }

        private bool PaymentExists(Guid id)
        {
            return _context.Payment.Any(e => e.PaymentId == id);
        }
    }
}
