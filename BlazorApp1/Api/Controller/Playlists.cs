using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BlazorApp1.Api.Controller
{
    [Route("api/playlists")]
    [ApiController]
    public class Playlists : ControllerBase
    {
        private readonly IWebHostEnvironment environment;
        public Playlists(IWebHostEnvironment environment)
        {
            this.environment = environment;
        }

        // GET: api/playlists
        [HttpGet()]
        public IEnumerable<string> Get()
        {
            return new string[] { "playlist1", "playlist2" };
        }

        // GET api/playlists/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "playlist";
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
