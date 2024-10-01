namespace Anigoo.Entities
{
    public class BuscarAnimeResponse
    {
        public BuscarAnimeResponse()
        {
            
        }

        public BuscarAnimeResponse(int id, string nomeAnime, string autor, int lancamento, int temporadas, int episodios, int classificacao, bool finalizado, string sinopse, string caminhoImagem, List<string> nomeGenero, List<string> nomeStreaming, decimal avaliacao)
        {
            Id = id;
            NomeAnime = nomeAnime;
            Autor = autor;
            Lancamento = lancamento;
            Temporadas = temporadas;
            Episodios = episodios;
            Classificacao = classificacao;
            Finalizado = finalizado;
            Sinopse = sinopse;
            CaminhoImagem = caminhoImagem;
            NomeGenero = nomeGenero;
            NomeStreaming = nomeStreaming;
            Avaliacao = avaliacao;
        }

        public int Id { get; set; }
        public string NomeAnime { get; set; }
        public string Autor { get; set; }
        public int Lancamento { get; set; }
        public int Temporadas { get; set; }
        public int Episodios { get; set; }
        public int Classificacao { get; set; }
        public bool Finalizado { get; set; }
        public string Sinopse { get; set; }
        public string CaminhoImagem { get; set; }
        public List<string> NomeGenero { get; set; }
        public List<string> NomeStreaming { get; set; }
        public decimal Avaliacao { get; set; }

    }
}
