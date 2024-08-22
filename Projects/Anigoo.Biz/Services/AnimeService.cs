﻿using Anigoo.Biz.Interfaces;
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
                                                                   .Include(x => x.Avaliacao).ThenInclude(x => x.Usuario)).ToList();

            List<BuscarAnimeResponse> listaBuscarAnimeResponse = new List<BuscarAnimeResponse>();
            foreach (var anime in listaAnime)
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
                    listaStreaming.Add(animeStreaming.Streaming.Nm_Streaming);
                }

                //Acessa as avaliações do anime e calcula sua média
                decimal soma = 0;
                foreach (var avaliacao in anime.Avaliacao)
                {
                    soma += avaliacao.Vl_Avaliacao;
                }

                decimal avaliacaoTotal = soma / anime.Avaliacao.Count;

                listaBuscarAnimeResponse.Add(new BuscarAnimeResponse(anime.Nm_Anime, listaGenero, listaStreaming, avaliacaoTotal));
            }

            return listaBuscarAnimeResponse;
        }
    }
}
