using Anigoo.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Anigoo.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AnimeController : ControllerBase
    {
        private readonly AnigooContext _context;

        public AnimeController(AnigooContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var animes = _context.Anime.ToList();
            if( animes.Count == 0)
            {
                return NotFound("Nenhum anime foi encontrado!");
            }
            return Ok(animes);
        }
    }
}
