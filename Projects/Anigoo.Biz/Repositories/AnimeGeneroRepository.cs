using Anigoo.Biz.Interfaces;
using Anigoo.Data;
using Anigoo.Data.Models;

namespace Anigoo.Biz.Repositorys
{
    public class AnimeGeneroRepository : BaseRepository<AnigooContext, AnimeGenero>, IAnimeGeneroRepository
    {
        public AnimeGeneroRepository(AnigooContext ctx) : base(ctx)
        {

        }
    }
}
