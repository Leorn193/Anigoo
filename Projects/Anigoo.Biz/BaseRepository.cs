using Anigoo.Biz.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Anigoo.Biz
{
    //public abstract class BaseRepository<TContext, TEntidade> : IBaseRepository<TEntidade> where TContext: DbContext where TEntidade : class, new()
    //{
    //    internal TContext _context;

    //    internal BaseRepository(TContext context)
    //    {
    //        _context = context;
    //    }

    //    public virtual bool Commit => _context.SaveChanges() > 0;
    //    public virtual void Dispose() => _context.Dispose();

    //    private static bool PropriedadeExiste(TEntidade entidade, string nomePropriedade) => entidade.GetType().GetProperty(nomePropriedade) != null;

    //    private static bool PropriedadeExiste(IQueryable)

    //    public virtual TEntidade Adicionar(TEntidade entidade)
    //    {
    //        if()
    //    }
    //}
}
