using System.ComponentModel.DataAnnotations;

namespace Anigoo.Data.Models
{
    public class Usuario
    {
        [Key]
        public int Id_Usuario { get; set; }
        public string  Nm_Usuario { get; set; }
        public string Ds_Usuario { get; set; }
        public string Ds_Senha { get; set; }
        public string Ds_Telefone { get; set; }
        public string Ds_Email { get; set; }
        public bool Fl_Premium { get; set; }
        public DateTime Dt_Criacao { get; set; }
        public bool Fl_Ativo { get; set; }

        //Relacionamento
        public ICollection<Avaliacao> Avaliacao { get; set; }
    }
}
