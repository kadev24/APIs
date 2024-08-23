using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ventas.Domain;
using System.Linq;
using System.Linq.Expressions;
using Ventas.Domain.Repositorios;
using Ventas.Domain.Repositories;

namespace Ventas.Data.Repositories
{
    public class UsuarioRepository : Repository<IncaFcContext>, IUsuarioRepository
    {
        public UsuarioRepository(IncaFcContext context) : base(context) { }

        public void Add(Usuario entity)
        {
            throw new NotImplementedException();
        }

        public void Attach(Usuario entity)
        {
            throw new NotImplementedException();
        }

        public int Count()
        {
            throw new NotImplementedException();
        }

        public int Count(Expression<Func<Usuario, bool>> criteria)
        {
            throw new NotImplementedException();
        }

        public void Delete(Usuario entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Expression<Func<Usuario, bool>> criteria)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Usuario> Find(Expression<Func<Usuario, bool>> criteria)
        {
            return _context.Usuarios.Where(criteria);
        }

        public Usuario FindOne(Expression<Func<Usuario, bool>> criteria)
        {
            throw new NotImplementedException();
        }

        public Usuario First(Expression<Func<Usuario, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Usuario> Get<TOrderBy>(Expression<Func<Usuario, TOrderBy>> orderBy, int pageIndex, int pageSize, SortOrder sortOrder = SortOrder.Ascending)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Usuario> Get<TOrderBy>(Expression<Func<Usuario, bool>> criteria, Expression<Func<Usuario, TOrderBy>> orderBy, int pageIndex, int pageSize, SortOrder sortOrder = SortOrder.Ascending)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Usuario> GetAll()
        {
            return _context.Usuarios.ToList();
        }

        public Usuario GetByKey(object keyValue)
        {
            throw new NotImplementedException();
        }

        public IQueryable<TEntity> GetQuery<TEntity>()
        {
            throw new NotImplementedException();
        }

        public IQueryable<Usuario> GetQuery(Expression<Func<Usuario, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public TEntity Single<TEntity>(Expression<Func<TEntity, bool>> criteria) where TEntity : class
        {
            throw new NotImplementedException();
        }

        public void Update(Usuario entity)
        {
            throw new NotImplementedException();
        }

        public void Update(Usuario entity, Expression<Func<Usuario, object>>[] properties)
        {
            throw new NotImplementedException();
        }

        public void SaveChanges()
        {
            _context.SaveChanges();
        }
    }
}
