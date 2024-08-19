using System.ComponentModel.DataAnnotations;

namespace Anigoo.Data.Models
{
    public class Streaming
    {
        [Key]
        public int Id_Streaming { get; set; }
        public string Nm_Streaming { get; set; }
        public DateTime Dt_Criacao { get; set; }
        public bool Fl_Ativo { get; set; }

        //Relacionamentos
        public ICollection<AnimeStreaming> AnimeStreaming { get; set; }
    }
}
