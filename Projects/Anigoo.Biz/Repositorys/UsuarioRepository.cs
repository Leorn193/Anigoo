using Anigoo.Biz.Interfaces;
using Anigoo.Data;
using Anigoo.Data.Models;

namespace Anigoo.Biz.Repositorys
{
    public class UsuarioRepository : BaseRepository<AnigooContext, Usuario>, IUsuarioRepository
    {
        public UsuarioRepository(AnigooContext ctx) : base(ctx)
        {

        }
    }
}
