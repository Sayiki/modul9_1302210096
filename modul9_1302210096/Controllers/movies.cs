using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace modul9_1302210096.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class movies : ControllerBase
    {
        public static List<Movies> DataMovies = new List<Movies>
        {
            new Movies("The Shawshank Redemption", "The Shawshank Redemption", new List<string>{"Tim Robbins, Morgan Freeman, Bob Gunton, William Sadler" }, "Over the course of several years, two convicts form a friendship, seeking consolation and, eventually, redemption through basic compassion."),
            new Movies("The Godfather", "Francis Ford Coppola", new List<string>{"Marlon Brando, Al Pacino, James Caan, Diane Keaton" }, "The aging patriarch of an organized crime dynasty in postwar New York City transfers control of his clandestine empire to his reluctant youngest son."),
            new Movies("The Dark Knight", "Christopher Nolan", new List<string>{"Marlon Brando, Al Pacino, James Caan, Diane Keaton" }, "When the menace known as the Joker wreaks havoc and chaos on the people of Gotham, Batman must accept one of the greatest psychological and physical tests of his ability to fight injustice.")

        };

        [HttpGet]
        public IEnumerable<Movies> Get()
        {
            return DataMovies;
        }

        [HttpGet("{id}")]
        public Movies Get(int id)
        {
            return DataMovies[id];
        }

        [HttpPost]
        public void Post([FromBody] Movies value)
        {
            DataMovies.Add(value);
        }

        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Movies value)
        {
            DataMovies[id] = value;
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            DataMovies.RemoveAt(id);
        }
    }
}
