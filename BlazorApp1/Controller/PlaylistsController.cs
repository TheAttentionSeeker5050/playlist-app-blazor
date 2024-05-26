using BlazorApp1.Data;
using BlazorApp1.DTOs;
using BlazorApp1.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BlazorApp1.Controller
{
    [Route("api/playlists")]
    [ApiController]
    public class PlaylistsController : ControllerBase
    {

        private readonly ApplicationDbContext _context;

        private readonly IWebHostEnvironment environment;
        public PlaylistsController(IWebHostEnvironment environment, ApplicationDbContext context)
        {
            _context = context;
            this.environment = environment;
        }

        // GET: api/playlists
        [HttpGet]
        public async Task<ActionResult<IEnumerable<PlaylistModel>>> GetPlaylists()
        {
            return await _context.Playlists.ToListAsync();
        }

        // GET: api/playlists/5
        [HttpGet("{id}")]
        public async Task<ActionResult<PlaylistDetailsDto>> GetPlaylist(int id)
        {
            var playlist = await _context.Playlists
                .Include(p => p.PlaylistItems)
                    .ThenInclude(pi => pi.SongModel)
                .FirstOrDefaultAsync(p => p.Id == id);

            if (playlist == null)
            {
                return NotFound();
            }

            var playlistDetailsDto = new PlaylistDetailsDto
            {
                PlaylistMetadata = new PlaylistMetadataDto
                {
                    Id = playlist.Id,
                    Name = playlist.Name,
                    Description = playlist.Description,
                    Image = playlist.Image
                },
                PlaylistSongs = playlist.PlaylistItems.Select(pi => new SongDto
                {
                    Id = pi.SongModel.Id,
                    Name = pi.SongModel.Name,
                    Artist = pi.SongModel.Artist,
                    Image = pi.SongModel.Image
                }).ToList()
            };

            return Ok(playlistDetailsDto);
        }

        // POST api/playlists
        [HttpPost()]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/playlists/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/playlists/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
