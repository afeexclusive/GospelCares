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
    public class EventReportsController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public EventReportsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/EventReports
        [HttpGet]
        public async Task<ActionResult<IEnumerable<EventReport>>> GetEventReports()
        {
            return await _context.EventReports.ToListAsync();
        }

        // GET: api/EventReports/5
        [HttpGet("{id}")]
        public async Task<ActionResult<EventReport>> GetEventReport(Guid id)
        {
            var eventReport = await _context.EventReports.FindAsync(id);

            if (eventReport == null)
            {
                return NotFound();
            }

            return eventReport;
        }

        // PUT: api/EventReports/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutEventReport(Guid id, EventReport eventReport)
        {
            if (id != eventReport.EventReportId)
            {
                return BadRequest();
            }

            _context.Entry(eventReport).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EventReportExists(id))
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

        // POST: api/EventReports
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<EventReport>> PostEventReport(EventReport eventReport)
        {
            _context.EventReports.Add(eventReport);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetEventReport", new { id = eventReport.EventReportId }, eventReport);
        }

        // DELETE: api/EventReports/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<EventReport>> DeleteEventReport(Guid id)
        {
            var eventReport = await _context.EventReports.FindAsync(id);
            if (eventReport == null)
            {
                return NotFound();
            }

            _context.EventReports.Remove(eventReport);
            await _context.SaveChangesAsync();

            return eventReport;
        }

        private bool EventReportExists(Guid id)
        {
            return _context.EventReports.Any(e => e.EventReportId == id);
        }
    }
}
