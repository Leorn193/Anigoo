using Microsoft.EntityFrameworkCore.Query;
using System.Linq.Expressions;

namespace Anigoo.Biz.Interfaces
{
    public interface IBaseRepository<TEntidade> : IDisposable where TEntidade : class, new()
    {
        bool Commit();
        TEntidade Adicionar(TEntidade entidade);
        IEnumerable<TEntidade> AdicionarLista(IEnumerable<TEntidade> entidades);
        TEntidade Remover(int id);
        TEntidade Remover(TEntidade entidade);
        IQueryable<TEntidade> RemoverLista(IQueryable<TEntidade> entidades);
        TEntidade Editar(TEntidade entidade);
        IQueryable<TEntidade> Listar(params Expression<Func<TEntidade, object>>[] includeProperties);
        IQueryable<TEntidade> Listar(Func<IQueryable<TEntidade>, IIncludableQueryable<TEntidade, object>> includeProperties = null);
        IQueryable<TEntidade> ListarPor(Expression<Func<TEntidade, bool>> where, params Expression<Func<TEntidade, object>>[] includeProperties);
        IQueryable<TEntidade> ListarPorEOrdenadosPor<TKey>(Expression<Func<TEntidade, bool>> where, Expression<Func<TEntidade, TKey>> ordem, bool ascedente = true, params Expression<Func<TEntidade, object>>[] includeProperties);
        IQueryable<TEntidade> ListarOrdenadosPor<TKey>(Expression<Func<TEntidade, TKey>> ordem, bool ascendente = true, params Expression<Func<TEntidade, object>>[] includeProperties);
        TEntidade ObterPor(Func<TEntidade, bool> where, params Expression<Func<TEntidade, object>>[] includeProperties);
    }
}
