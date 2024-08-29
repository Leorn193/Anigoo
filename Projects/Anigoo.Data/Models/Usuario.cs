using System.ComponentModel.DataAnnotations;

namespace Anigoo.Data.Models
{
    public class Usuario
    {
        public Usuario()
        {
            
        }

        public Usuario(string nm_Usuario, string ds_Usuario, string ds_Senha, string ds_Telefone, string ds_Email, bool fl_Premium)
        {
            Nm_Usuario = nm_Usuario;
            Ds_Usuario = ds_Usuario;
            Ds_Senha = ds_Senha;
            Ds_Telefone = ds_Telefone;
            Ds_Email = ds_Email;
            Fl_Premium = fl_Premium;
        }

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
