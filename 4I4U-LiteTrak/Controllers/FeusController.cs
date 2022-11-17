using _4I4U_LiteTrak.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

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

        // POST: api/Feus
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        //[HttpPost]
        //public async Task<ActionResult<Feu>> PostFeu(Feu feu)
        //{
        //  if (_context.Feus == null)
        //  {
        //      return Problem("Entity set 'FeuDbContext.Feus'  is null.");
        //  }
        //    _context.Feus.Add(feu);
        //    await _context.SaveChangesAsync();

        //    return CreatedAtAction("GetFeu", new { id = feu.Id }, feu);
        //}

        // DELETE: api/Feus/5
        //[HttpDelete("{id}")]
        //public async Task<IActionResult> DeleteFeu(int id)
        //{
        //    if (_context.Feus == null)
        //    {
        //        return NotFound();
        //    }
        //    var feu = await _context.Feus.FindAsync(id);
        //    if (feu == null)
        //    {
        //        return NotFound();
        //    }

        //    _context.Feus.Remove(feu);
        //    await _context.SaveChangesAsync();

        //    return NoContent();
        //}

        private bool FeuExists(int id)
        {
            return (_context.Feus?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
