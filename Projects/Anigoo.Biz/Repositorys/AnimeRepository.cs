using Anigoo.Biz.Interfaces;
using Anigoo.Data;
using Anigoo.Data.Models;

namespace Anigoo.Biz.Repositorys
{
    public class AnimeRepository : BaseRepository<AnigooContext, Anime>, IAnimeRepository
    {
        public AnimeRepository(AnigooContext ctx) : base(ctx)
        {

        }
    }
}
