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
    public class ResponseController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public ResponseController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/Response
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CounsellingReply>>> GetCounsellingReply()
        {
            return await _context.CounsellingReply.ToListAsync();
        }

        // GET: api/Response/5
        [HttpGet("{id}")]
        public async Task<ActionResult<CounsellingReply>> GetCounsellingReply(Guid id)
        {
            var counsellingReply = await _context.CounsellingReply.FindAsync(id);

            if (counsellingReply == null)
            {
                return NotFound();
            }

            return counsellingReply;
        }

        // PUT: api/Response/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCounsellingReply(Guid id, CounsellingReply counsellingReply)
        {
            if (id != counsellingReply.CounsellingReplyId)
            {
                return BadRequest();
            }

            _context.Entry(counsellingReply).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CounsellingReplyExists(id))
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

        // POST: api/Response
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<CounsellingReply>> PostCounsellingReply(CounsellingReply counsellingReply)
        {
            _context.CounsellingReply.Add(counsellingReply);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetCounsellingReply", new { id = counsellingReply.CounsellingReplyId }, counsellingReply);
        }

        // DELETE: api/Response/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<CounsellingReply>> DeleteCounsellingReply(Guid id)
        {
            var counsellingReply = await _context.CounsellingReply.FindAsync(id);
            if (counsellingReply == null)
            {
                return NotFound();
            }

            _context.CounsellingReply.Remove(counsellingReply);
            await _context.SaveChangesAsync();

            return counsellingReply;
        }

        private bool CounsellingReplyExists(Guid id)
        {
            return _context.CounsellingReply.Any(e => e.CounsellingReplyId == id);
        }
    }
}
