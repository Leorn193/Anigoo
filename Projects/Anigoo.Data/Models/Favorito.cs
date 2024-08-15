using System.ComponentModel.DataAnnotations;

namespace Anigoo.Data.Models
{
    public class Favorito
    {
        [Key]
        public int Id_Favorito { get; set; }
        public int Id_Anime { get; set; }
        public int Id_Usuario { get; set; }
        public DateTime Dt_Criacao { get; set; }
        public bool Fl_Ativo { get; set; }
        public virtual Anime Anime { get; set; }
        public virtual Usuario Usuario { get; set; }
    }
}
