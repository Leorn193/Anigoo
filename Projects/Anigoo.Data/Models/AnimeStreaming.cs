using System.ComponentModel.DataAnnotations;

namespace Anigoo.Data.Models
{
    public class AnimeStreaming
    {
        [Key]
        public int Id_AnimeStreaming { get; set; }
        public int Id_Anime { get; set; }
        public int Id_Streaming { get; set; }
        public DateTime Dt_Criacao { get; set; }
        public bool Fl_Ativo { get; set; }
        public virtual Anime Anime { get; set; }
        public virtual Streaming Streaming { get; set; }
    }
}
