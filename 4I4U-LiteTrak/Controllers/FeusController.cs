using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using _4I4U_LiteTrak.Model;

namespace _4I4U_LiteTrak.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FeusController : ControllerBase
    {
        private readonly FeuDbContext _context;

        public FeusController(FeuDbContext context)
        {
            _context = context;
        }

        // GET: api/Feus
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Feu>>> GetFeus()
        {
          if (_context.Feus == null)
          {
              return NotFound();
          }
            return await _context.Feus.ToListAsync();
        }

        // GET: api/Feus/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Feu>> GetFeu(int id)
        {
          if (_context.Feus == null)
          {
              return NotFound();
          }
            var feu = await _context.Feus.FindAsync(id);

            if (feu == null)
            {
                return NotFound();
            }

            return feu;
        }

        // PUT: api/Feus/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutFeu(int id, Feu feu)
        {
            if (id != feu.Id)
            {
                return BadRequest();
            }

            _context.Entry(feu).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!FeuExists(id))
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

        private bool FeuExists(int id)
        {
            return (_context.Feus?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
