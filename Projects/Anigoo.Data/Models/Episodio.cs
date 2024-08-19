using System.ComponentModel.DataAnnotations;

namespace Anigoo.Data.Models
{
    public class Episodio
    {
        [Key]
        public int Id_Episodio { get; set; }
        public int Id_Anime { get; set; }
        public int Cd_Episodio { get; set; }
        public string Nm_Episodio { get; set; }
        public string Ds_Sinopse { get; set; }
        public string Cd_Temporada { get; set; }
        public DateTime Dt_Criacao { get; set; }
        public bool Fl_Ativo { get; set; }

        //Relacionamento
        public Anime Anime { get; set; }
    }
}
