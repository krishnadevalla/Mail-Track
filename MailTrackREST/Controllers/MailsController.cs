using MailTrackREST.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MailTrackREST.Controllers
{
    [Produces("application/json")]
    [Route("api/Mails")]
    public class MailsController : Controller
    {
        private readonly MailsContext _context;

        public MailsController(MailsContext context)
        {
            _context = context;
        }

        // GET: api/Mails
        [HttpGet]
        public IEnumerable<Mail> GetMail()
        {
            return _context.Mail;
        }

        // GET: api/Mails/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetMail([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var mail = await _context.Mail.SingleOrDefaultAsync(m => m.Id == id);

            if (mail == null)
            {
                return NotFound();
            }

            return Ok(mail);
        }

        // PUT: api/Mails/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutMail([FromRoute] int id, [FromBody] Mail mail)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != mail.Id)
            {
                return BadRequest();
            }

            _context.Entry(mail).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MailExists(id))
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

        // POST: api/Mails
        [HttpPost]
        public async Task<IActionResult> PostMail([FromBody] Mail mail)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.Mail.Add(mail);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetMail", new { id = mail.Id }, mail);
        }

        // DELETE: api/Mails/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteMail([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var mail = await _context.Mail.SingleOrDefaultAsync(m => m.Id == id);
            if (mail == null)
            {
                return NotFound();
            }

            _context.Mail.Remove(mail);
            await _context.SaveChangesAsync();

            return Ok(mail);
        }

        private bool MailExists(int id)
        {
            return _context.Mail.Any(e => e.Id == id);
        }
    }
}