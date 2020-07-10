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
    public class CounsellingController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public CounsellingController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/Counselling
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CounsellingQuestion>>> GetCounsellingQuestion()
        {
            return await _context.CounsellingQuestion.ToListAsync();
        }

        // GET: api/Counselling/5
        [HttpGet("{id}")]
        public async Task<ActionResult<CounsellingQuestion>> GetCounsellingQuestion(Guid id)
        {
            var counsellingQuestion = await _context.CounsellingQuestion.FindAsync(id);

            if (counsellingQuestion == null)
            {
                return NotFound();
            }

            return counsellingQuestion;
        }

        // PUT: api/Counselling/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCounsellingQuestion(Guid id, CounsellingQuestion counsellingQuestion)
        {
            if (id != counsellingQuestion.CounsellingQuestionId)
            {
                return BadRequest();
            }

            _context.Entry(counsellingQuestion).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CounsellingQuestionExists(id))
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

        // POST: api/Counselling
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<CounsellingQuestion>> PostCounsellingQuestion(CounsellingQuestion counsellingQuestion)
        {
            _context.CounsellingQuestion.Add(counsellingQuestion);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetCounsellingQuestion", new { id = counsellingQuestion.CounsellingQuestionId }, counsellingQuestion);
        }

        // DELETE: api/Counselling/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<CounsellingQuestion>> DeleteCounsellingQuestion(Guid id)
        {
            var counsellingQuestion = await _context.CounsellingQuestion.FindAsync(id);
            if (counsellingQuestion == null)
            {
                return NotFound();
            }

            _context.CounsellingQuestion.Remove(counsellingQuestion);
            await _context.SaveChangesAsync();

            return counsellingQuestion;
        }

        private bool CounsellingQuestionExists(Guid id)
        {
            return _context.CounsellingQuestion.Any(e => e.CounsellingQuestionId == id);
        }
    }
}
