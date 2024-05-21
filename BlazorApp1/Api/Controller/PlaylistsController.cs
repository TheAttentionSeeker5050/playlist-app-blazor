using BlazorApp1.Api.Model;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BlazorApp1.Api.Controller
{
    [Route("api/playlists")]
    [ApiController]
    public class PlaylistsController : ControllerBase
    {
        

        private readonly IWebHostEnvironment environment;
        public PlaylistsController(IWebHostEnvironment environment)
        {
            this.environment = environment;
        }

        // GET: api/playlists
        [HttpGet]
        public IEnumerable<PlaylistModel> Get() 
        {
            var playlists =  PlaylistModel.GetPlaylists();

            return playlists;
        }

        // GET api/playlists/5
        // the response is composed of the following json object:
        // {
        //     "playlistMetadata": {PlaylistModel}
        //     "playlistSongs": {List<TrackModel>}
        // }
        [HttpGet("{id}")]
        public string Get(int id)
        {
            var playlistMetadata = PlaylistModel.GetPlaylists().FirstOrDefault(p => p.Id == id);
            var playlistSongs = SongModel.GetSongs().ToList();

            // prepare the response object
            
            return JsonConvert.SerializeObject(new
            {
                playlistMetadata,
                playlistSongs
            });

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
