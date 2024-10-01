using Anigoo.Data.Models;
using Anigoo.Entities;

namespace Anigoo.Biz.Mapper
{
    public class AnimeMapper
    {
        static public List<BuscarAnimeResponse> Converte(List<Anime> listaAnime)
        {
            List<BuscarAnimeResponse> animeResponse = new List<BuscarAnimeResponse>();

            foreach (var anime in listaAnime)
            {
                animeResponse.Add(Converte(anime));
            }

            return animeResponse;
        }

        static public BuscarAnimeResponse Converte(Anime anime)
        {
            //Acessa os gêneros do anime
            List<string> listaGenero = new();
            foreach (var animeGenero in anime.AnimeGenero)
            {
                listaGenero.Add(animeGenero.Genero.Nm_Genero);
            }

            //Acessa os streamings do anime
            List<string> listaStreaming = new();
            foreach (var animeStreaming in anime.AnimeStreaming)
            {
                if (animeStreaming.Fl_Ativo == true)
                    listaStreaming.Add(animeStreaming.Streaming.Nm_Streaming);
            }

            //Acessa as avaliações do anime e calcula sua média
            decimal soma = 0;
            decimal avaliacaoTotal = 0;

            if (anime.Avaliacao.Count() > 0)
            {
                foreach (var avaliacao in anime.Avaliacao)
                {
                    soma += avaliacao.Vl_Avaliacao;
                }

                avaliacaoTotal = soma / anime.Avaliacao.Count;
            }


            return new BuscarAnimeResponse(anime.Id_Anime,
                                           anime.Nm_Anime, 
                                           anime.Nm_Autor, 
                                           anime.Qt_AnoEstreia, 
                                           anime.Qt_Temporadas, 
                                           anime.Qt_Episodios,
                                           anime.Cd_Classificacao,
                                           anime.Fl_Finalizado,
                                           anime.Ds_Sinopse,
                                           anime.Ds_Imagem,
                                           listaGenero,
                                           listaStreaming,
                                           avaliacaoTotal);
        }
    }
}
