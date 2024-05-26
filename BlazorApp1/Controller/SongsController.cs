using BlazorApp1.Data;
using BlazorApp1.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BlazorApp1.Controller
{
    [Route("api/songs")]
    [ApiController]
    public class SongsController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        private readonly IWebHostEnvironment environment;
        public SongsController(IWebHostEnvironment environment, ApplicationDbContext context)
        {
            _context = context;
            this.environment = environment;
        }

        // GET: api/songs
        [HttpGet]
        public async Task<ActionResult<IEnumerable<SongModel>>> GetSongs()
        {
            return await _context.Songs.ToListAsync();
        }

        // GET api/songs/5
        [HttpGet("{id}")]
        public async Task<ActionResult<SongModel>> GetSong(int id)
        {
            var song = await _context.Songs.FindAsync(id);

            if (song == null)
            {
                return NotFound();
            }

            return song;
        }
        
        // TestController

        // POST api/songs
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/songs/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/songs/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
