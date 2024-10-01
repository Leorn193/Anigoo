using Anigoo.Biz.Interfaces;
using Anigoo.Data.Models;
using Anigoo.Entities;
using Microsoft.EntityFrameworkCore;

namespace Anigoo.Biz.Services
{
    public class AnimeService
    {
        private readonly IAnimeRepository _animeRepository;
        private readonly IGeneroRepository _generoRepository;
        private readonly IAnimeGeneroRepository _animeGeneroRepository;

        public AnimeService(IAnimeRepository animeRepository, IGeneroRepository generoRepository , IAnimeGeneroRepository animeGeneroRepository)
        {
            _animeRepository = animeRepository;
            _generoRepository = generoRepository;
            _animeGeneroRepository = animeGeneroRepository;
        }

        public List<BuscarAnimeResponse> BuscarAnimes()
        {

            List<Anime> listaAnime = _animeRepository.Listar(x => x.Include(x => x.AnimeGenero).ThenInclude(x => x.Genero)
                                                                   .Include(x => x.AnimeStreaming).ThenInclude(x => x.Streaming)
                                                                   .Include(x => x.Avaliacao).ThenInclude(x => x.Usuario))
                                                                   .Take(14).ToList();

            List<BuscarAnimeResponse> listaBuscarAnimeResponse = Mapper.AnimeMapper.Converte(listaAnime);

            return listaBuscarAnimeResponse;
        }

        public BuscarAnimeResponse BuscarAnimeById(int id)
        {
            Anime? anime = _animeRepository.Listar(x => x.Include(x => x.AnimeGenero).ThenInclude(x => x.Genero)
                                                                   .Include(x => x.AnimeStreaming).ThenInclude(x => x.Streaming)
                                                                   .Include(x => x.Avaliacao).ThenInclude(x => x.Usuario)).Where(x => x.Id_Anime == id).FirstOrDefault();
            if(anime != null)
            {  
                BuscarAnimeResponse animeResponse = Mapper.AnimeMapper.Converte(anime);
                return animeResponse;
            }
            return new BuscarAnimeResponse();
        }

    }
}
