using Anigoo.Biz.Interfaces;
using Anigoo.Data;
using Anigoo.Data.Models;

namespace Anigoo.Biz.Repositorys
{
    public class GeneroRepository : BaseRepository<AnigooContext, Genero>, IGeneroRepository
    {
        public GeneroRepository(AnigooContext ctx) : base(ctx)
        {

        }
    }
}
