using System.ComponentModel.DataAnnotations;

namespace Anigoo.Data.Models
{
    public class Avaliacao
    {
        [Key]
        public int Id_Avaliacao { get; set; }
        public int Id_Anime { get; set; }
        public int Id_Usuario { get; set; }
        public decimal Vl_Avaliacao { get; set; }
        public DateTime Dt_Criacao { get; set; }
        public bool Fl_Ativo { get; set; }

        //Relacionamentos
        public Anime Anime { get; set; }
        public Usuario Usuario { get; set; }
    }
}
