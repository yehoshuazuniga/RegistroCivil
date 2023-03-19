using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RegistroCivil.Context;
using RegistroCivil.Models;

namespace RegistroCivil.Controllers
{
    [EnableCors("MyPolicy")]
    [Route("api/[controller]")]
    [ApiController]
    public class RegistrosController : ControllerBase
    {
        private readonly RegistroCivilDbContext _context;

        public RegistrosController(RegistroCivilDbContext context)
        {
            _context = context;
        }

        // GET: api/Registros
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Registro>>> GetResgistros()
        {
          if (_context.Resgistros == null)
          {
              return NotFound();
          }
            return await _context.Resgistros.ToListAsync();
        }

        // GET: api/Registros/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Registro>> GetRegistro(int id)
        {
          if (_context.Resgistros == null)
          {
              return NotFound();
          }
            var registro = await _context.Resgistros.FindAsync(id);

            if (registro == null)
            {
                return NotFound();
            }

            return registro;
        }

        // PUT: api/Registros/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutRegistro(int id, Registro registro)
        {
            if (id != registro.RegistroID)
            {
                return BadRequest();
            }

            _context.Entry(registro).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!RegistroExists(id))
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

        // POST: api/Registros
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Registro>> PostRegistro(Registro registro)
        {
            registro.FechaNacimiento = Convert.ToDateTime(registro.FechaNacimiento);
            registro.Monoparental = Convert.ToBoolean(registro.Monoparental);
            registro.Sexo = Convert.ToChar(registro.Sexo);

          if (_context.Resgistros == null)
          {
              return Problem("Entity set 'RegistroCivilDbContext.Resgistros'  is null.");
          }
            _context.Resgistros.Add(registro);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetRegistro", new { id = registro.RegistroID }, registro);
        }

        // DELETE: api/Registros/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteRegistro(int id)
        {
            if (_context.Resgistros == null)
            {
                return NotFound();
            }
            var registro = await _context.Resgistros.FindAsync(id);
            if (registro == null)
            {
                return NotFound();
            }

            _context.Resgistros.Remove(registro);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool RegistroExists(int id)
        {
            return (_context.Resgistros?.Any(e => e.RegistroID == id)).GetValueOrDefault();
        }
    }
}
