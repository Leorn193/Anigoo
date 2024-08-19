using System.ComponentModel.DataAnnotations;

namespace Anigoo.Data.Models
{
    public class Anime
    {
        [Key]
        public int Id_Anime { get; set; }
        public string Nm_Anime { get; set; }
        public string Nm_Autor { get; set; }
        public int Qt_Episodios { get; set; }
        public int Qt_Temporadas { get; set; }
        public int Qt_AnoEstreia { get; set; }
        public DateTime Dt_Criacao { get; set; }
        public bool Fl_Ativo { get; set; }

        //Relacionamentos

        public ICollection<AnimeGenero> AnimeGenero { get; set; }
        public ICollection<AnimeStreaming> AnimeStreaming { get; set; }
        public ICollection<Episodio> Episodio { get; set; }
        public ICollection<Avaliacao> Avaliacao { get; set; }
    }
}
