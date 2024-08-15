using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Anigoo.Data.Models
{
    public class Anime
    {
        [Key]
        public int Id_Anime { get; set; }
        public int Id_Genero { get; set; }
        public string Nm_Anime { get; set; }
        public string Nm_Autor { get; set; }
        public int Qt_Episodios { get; set; }
        public int Qt_Temporadas { get; set; }
        public decimal Vl_Avaliacao { get; set; }
        public int Qt_AnoEstreia { get; set; }
        public DateTime Dt_Criacao { get; set; }
        public bool Fl_Ativo { get; set; }
    }
}
