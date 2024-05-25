using BlazorApp1.Api.Model;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BlazorApp1.Api.Controller
{
    [Route("api/songs")]
    [ApiController]
    public class SongsController : ControllerBase
    {

        private readonly IWebHostEnvironment environment;
        public SongsController(IWebHostEnvironment environment)
        {
            this.environment = environment;
        }

        // GET: api/songs
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "song1", "song2" };
        }

        // GET api/songs/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            var song = SongModel.GetSongs().FirstOrDefault(s => s.Id == id);

            return JsonConvert.SerializeObject(song);
        }

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
