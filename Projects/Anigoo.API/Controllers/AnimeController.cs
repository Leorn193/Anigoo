using Anigoo.Biz.Services;
using Microsoft.AspNetCore.Mvc;

namespace Anigoo.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AnimeController : ControllerBase
    { 
        private readonly AnimeService _animeService;

        public AnimeController(AnimeService animeService)
        {
            _animeService = animeService;
        }

        [HttpGet]
        public IActionResult Get(int page)
        {
            var retorno = _animeService.BuscarAnimes(page);
            return Ok(retorno);
        }

/*        [HttpGet]
        public IActionResult GetAnimesInicial()
        {
            var retorno = _animeService.
            return Ok(retorno);
        }*/
    }
}
