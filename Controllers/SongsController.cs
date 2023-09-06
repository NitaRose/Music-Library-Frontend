﻿using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Music_Library_Frontend.Data;
using Music_Library_Frontend.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Music_Library_Frontend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SongsController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        public SongsController(ApplicationDbContext context)
        {
            _context = context;
        }
        // GET: api/<SongsController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<SongsController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<SongsController>
        [HttpPost]
        public IActionResult Post([FromBody] Song song)            
        {
            if (ModelState.IsValid)
            {
                _context.Songs.Add(song);
                _context.SaveChanges();
                return StatusCode(201, song);
            }
            return BadRequest(ModelState);
        }
           

        // PUT api/<SongsController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<SongsController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
