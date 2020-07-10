using System;
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
    public class TermlyDuesController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public TermlyDuesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/TermlyDues
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TermlyDue>>> GetTermlyDues()
        {
            return await _context.TermlyDues.ToListAsync();
        }

        // GET: api/TermlyDues/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TermlyDue>> GetTermlyDue(Guid id)
        {
            var termlyDue = await _context.TermlyDues.FindAsync(id);

            if (termlyDue == null)
            {
                return NotFound();
            }

            return termlyDue;
        }

        // PUT: api/TermlyDues/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTermlyDue(Guid id, TermlyDue termlyDue)
        {
            if (id != termlyDue.TermlyDueId)
            {
                return BadRequest();
            }

            _context.Entry(termlyDue).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TermlyDueExists(id))
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

        // POST: api/TermlyDues
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<TermlyDue>> PostTermlyDue(TermlyDue termlyDue)
        {
            _context.TermlyDues.Add(termlyDue);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetTermlyDue", new { id = termlyDue.TermlyDueId }, termlyDue);
        }

        // DELETE: api/TermlyDues/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<TermlyDue>> DeleteTermlyDue(Guid id)
        {
            var termlyDue = await _context.TermlyDues.FindAsync(id);
            if (termlyDue == null)
            {
                return NotFound();
            }

            _context.TermlyDues.Remove(termlyDue);
            await _context.SaveChangesAsync();

            return termlyDue;
        }

        private bool TermlyDueExists(Guid id)
        {
            return _context.TermlyDues.Any(e => e.TermlyDueId == id);
        }
    }
}
