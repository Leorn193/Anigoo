namespace Anigoo.Entities
{
    public class BuscarAnimeResponse
    {
        public BuscarAnimeResponse()
        {
            
        }

        public BuscarAnimeResponse(string nomeAnime, List<string> nomeGenero, List<string> nomeStreaming, decimal avaliacao)
        {
            NomeAnime = nomeAnime;
            NomeGenero = nomeGenero;
            NomeStreaming = nomeStreaming;
            Avaliacao = avaliacao;
        }

        public string NomeAnime { get; set; }
        public List<string> NomeGenero { get; set; }
        public List<string> NomeStreaming { get; set; }
        public decimal Avaliacao { get; set; }

    }
}
