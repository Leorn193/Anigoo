using System.ComponentModel.DataAnnotations;

namespace Anigoo.Data.Models
{
    public class Genero
    {
        [Key]
        public int Id_Genero { get; set; }
        public string Nm_Genero { get; set; }
        public DateTime Dt_Criacao { get; set; }
        public bool Fl_Ativo { get; set; }
    }
}
