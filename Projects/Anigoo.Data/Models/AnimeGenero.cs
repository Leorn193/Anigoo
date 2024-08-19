using System.ComponentModel.DataAnnotations;

namespace Anigoo.Data.Models
{
    public class AnimeGenero
    {
        [Key]
        public int Id_AnimeGenero { get; set; }
        public int Id_Anime { get; set; }
        public int Id_Genero { get; set; }
        public DateTime Dt_Criacao { get; set; }
        public bool Fl_Ativo { get; set; }

        //Relacionamentos
        public Anime Anime { get; set; }
        public Genero Genero { get; set; }
    }
}
