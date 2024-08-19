using Anigoo.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

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
            var animes = _context.Anime.Include(x => x.AnimeGenero).ThenInclude(x => x.Genero)
                                       .Include(x => x.AnimeStreaming).ThenInclude(x => x.Streaming)
                                       .Include(x => x.Episodio)
                                       .Include(x => x.Avaliacao).ToList();
            if( animes.Count == 0)
            {
                return NotFound("Nenhum anime foi encontrado!");
            }
            return Ok("Deu certo");
        }
    }
}
