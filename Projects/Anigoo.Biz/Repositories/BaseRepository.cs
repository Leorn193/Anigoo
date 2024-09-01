using Anigoo.Biz.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using System.Linq.Dynamic.Core;
using Microsoft.EntityFrameworkCore.Query;
using System.Collections.Generic;

namespace Anigoo.Biz.Repositorys
{
    public abstract class BaseRepository<TContext, TEntidade> : IBaseRepository<TEntidade> where TContext : DbContext where TEntidade : class, new()
    {
        internal TContext _context;

        internal BaseRepository(TContext context)
        {
            _context = context;
        }

        public virtual bool Commit() => _context.SaveChanges() > 0;
        public virtual void Dispose() => _context.Dispose();

        private static bool PropriedadeExiste(TEntidade entidade, string nomePropriedade) => entidade.GetType().GetProperty(nomePropriedade) != null;

        private static bool PropriedadeExiste(IQueryable<TEntidade> entidades, string nomePropriedade)
        {
            foreach (var entidade in entidades)
            {
                if (!PropriedadeExiste(entidade, nomePropriedade))
                    return false;
            }

            return true;
        }

        public virtual TEntidade Adicionar(TEntidade entidade)
        {
            if (PropriedadeExiste(entidade, "Fl_Ativo") && PropriedadeExiste(entidade, "Dt_Criacao"))
            {
                ((dynamic)entidade).Fl_Ativo = true;
                ((dynamic)entidade).Dt_Criacao = DateTime.Now;

                _context.Set<TEntidade>().Add(entidade);
                _context.Entry(entidade).State = EntityState.Added;

                return entidade;
            }
            return new();
        }

        public virtual IEnumerable<TEntidade> AdicionarLista(IEnumerable<TEntidade> entidades)
        {
            foreach (var entidade in entidades)
            {
                Adicionar(entidade);
            }
            return entidades ?? Enumerable.Empty<TEntidade>();
        }

        public virtual TEntidade Remover(int id)
        {
            TEntidade entidade = _context.Set<TEntidade>().Find(id);

            if (PropriedadeExiste(entidade, "Fl_Ativo"))
            {
                ((dynamic)entidade).Fl_Ativo = false;
                _context.Entry(entidade).State = EntityState.Modified;
            }

            return entidade ?? new();
        }

        public virtual TEntidade Remover(TEntidade entidade)
        {
            if (PropriedadeExiste(entidade, "Fl_Ativo"))
            {
                ((dynamic)entidade).Fl_Ativo = false;
                _context.Entry(entidade).State = EntityState.Modified;
            }

            return entidade ?? new();
        }

        public virtual IQueryable<TEntidade> RemoverLista(IQueryable<TEntidade> entidades)
        {
            foreach (var entidade in entidades)
            {
                Remover(entidade);
            }

            return entidades ?? Enumerable.Empty<TEntidade>().AsQueryable();//Testar como IEnumerable
        }

        public virtual TEntidade Editar(TEntidade entidade)
        {
            if (PropriedadeExiste(entidade, "Fl_Ativo") && PropriedadeExiste(entidade, "Dt_Criacao"))
            {
                _context.Entry(entidade).Property("Fl_Ativo").IsModified = false;
                _context.Entry(entidade).Property("Dt_Criacao").IsModified = false;

                _context.Entry(entidade).State = EntityState.Modified;

                return entidade;
            }

            return new();
        }

        private IQueryable<TEntidade> Include(IQueryable<TEntidade> query, params Expression<Func<TEntidade, object>>[] includeProperties)
        {
            foreach (var property in includeProperties)
            {
                query = query.Include(property);
            }
            return query;
        }

        public virtual IQueryable<TEntidade> Listar(params Expression<Func<TEntidade, object>>[] includeProperties)
        {
            IQueryable<TEntidade> query = _context.Set<TEntidade>();

            if (PropriedadeExiste(query, "Fl_Ativo"))
            {
                query = query.Where("Fl_Ativo == true").AsQueryable();
            }

            if (includeProperties.Any())
                return Include(query, includeProperties);

            return query;
        }

        public virtual IQueryable<TEntidade> Listar(Func<IQueryable<TEntidade>, IIncludableQueryable<TEntidade, object>> includeProperties = null)
        {
            IQueryable<TEntidade> query = _context.Set<TEntidade>();

            if (PropriedadeExiste(query.FirstOrDefault(), "Fl_Ativo"))
            {
                query = query.Where("Fl_Ativo == true").AsQueryable();
            }

            if (includeProperties != null)
            {
                query = includeProperties(query);
            }

            return query;
        }

        public virtual IQueryable<TEntidade> ListarPor(Expression<Func<TEntidade, bool>> where, params Expression<Func<TEntidade, object>>[] includeProperties)
        {
            return Listar(includeProperties).Where(where);
        }

        public virtual IQueryable<TEntidade> ListarPorEOrdenadosPor<TKey>(Expression<Func<TEntidade, bool>> where, Expression<Func<TEntidade, TKey>> ordem, bool ascedente = true, params Expression<Func<TEntidade, object>>[] includeProperties)
        {
            return ascedente ? ListarPor(where, includeProperties).OrderBy(ordem) : ListarPor(where, includeProperties).OrderByDescending(ordem);
        }

        public virtual IQueryable<TEntidade> ListarOrdenadosPor<TKey>(Expression<Func<TEntidade, TKey>> ordem, bool ascendente = true, params Expression<Func<TEntidade, object>>[] includeProperties)
        {
            return ascendente ? Listar(includeProperties).OrderBy(ordem) : Listar(includeProperties).OrderByDescending(ordem);
        }

        public virtual TEntidade ObterPor(Func<TEntidade, bool> where, params Expression<Func<TEntidade, object>>[] includeProperties)
        {
            return Listar(includeProperties).FirstOrDefault(where);
        }
    }
}
