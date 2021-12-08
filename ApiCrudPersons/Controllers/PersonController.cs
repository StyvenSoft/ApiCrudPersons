using ApiCrudPersons.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ApiCrudPersons.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public PersonController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/<PersonController>
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            try
            {
                var listPersons = await _context.Person.ToListAsync();

                return Ok(listPersons);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // GET api/<PersonController>/5
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            try
            {
                var person = await _context.Person.FindAsync(id);

                if (person == null)
                {
                    return NotFound();
                }

                return Ok(person);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // POST api/<PersonController>
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] Person person)
        {
            try
            {
                _context.Add(person);
                await _context.SaveChangesAsync();

                return Ok(person);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // PUT api/<PersonController>/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, [FromBody] Person person)
        {
            try
            {
                if(id != person.Id)
                {
                    return BadRequest();
                }

                _context.Update(person);
                await _context.SaveChangesAsync();
                return Ok(new { message = "Persona actualizada con exito!" });
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // DELETE api/<PersonController>/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            try
            {
                var person = await _context.Person.FindAsync(id);

                if(person == null)
                {
                    return NotFound();
                }

                _context.Person.Remove(person);
                await _context.SaveChangesAsync();
                return Ok(new { message = "Persona eliminada con exito!" });
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
