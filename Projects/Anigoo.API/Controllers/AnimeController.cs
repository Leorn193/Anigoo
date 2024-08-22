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
        public IActionResult Get()
        {
            var retorno = _animeService.BuscarAnimes();
            return Ok(retorno);
        }
    }
}
