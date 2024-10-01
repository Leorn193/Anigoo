using Anigoo.Biz.Services;
using Anigoo.Entities;
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
            List<BuscarAnimeResponse> retorno = _animeService.BuscarAnimes();
            return Ok(retorno);
        }

        [HttpGet]
        [Route("{id}")]
        public IActionResult GetAnimeById(int id)
        {
            BuscarAnimeResponse retorno = _animeService.BuscarAnimeById(id);
            if(retorno.NomeAnime != null)
                return Ok(retorno);
            return BadRequest("ANIME NÃO ENCONTRADO");
        }
    }
}
