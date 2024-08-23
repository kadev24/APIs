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
    public class UsuarioRolRepository : Repository<IncaFcContext>, IUsuarioRolRepository
    {
        public UsuarioRolRepository(IncaFcContext context) : base(context) { }

        public void Add(RolUsuario entity)
        {
            throw new NotImplementedException();
        }

        public void Attach(RolUsuario entity)
        {
            throw new NotImplementedException();
        }

        public int Count()
        {
            throw new NotImplementedException();
        }

        public int Count(Expression<Func<RolUsuario, bool>> criteria)
        {
            throw new NotImplementedException();
        }

        public void Delete(RolUsuario entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Expression<Func<RolUsuario, bool>> criteria)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<RolUsuario> Find(Expression<Func<RolUsuario, bool>> criteria)
        {
            return _context.RolUsuarios.Where(criteria);
        }

        public RolUsuario FindOne(Expression<Func<RolUsuario, bool>> criteria)
        {
            throw new NotImplementedException();
        }

        public RolUsuario First(Expression<Func<RolUsuario, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<RolUsuario> Get<TOrderBy>(Expression<Func<RolUsuario, TOrderBy>> orderBy, int pageIndex, int pageSize, SortOrder sortOrder = SortOrder.Ascending)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<RolUsuario> Get<TOrderBy>(Expression<Func<RolUsuario, bool>> criteria, Expression<Func<RolUsuario, TOrderBy>> orderBy, int pageIndex, int pageSize, SortOrder sortOrder = SortOrder.Ascending)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<RolUsuario> GetAll()
        {
            throw new NotImplementedException();
        }

        public RolUsuario GetByKey(object keyValue)
        {
            throw new NotImplementedException();
        }

        public IQueryable<TEntity> GetQuery<TEntity>()
        {
            throw new NotImplementedException();
        }

        public IQueryable<RolUsuario> GetQuery(Expression<Func<RolUsuario, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public TEntity Single<TEntity>(Expression<Func<TEntity, bool>> criteria) where TEntity : class
        {
            throw new NotImplementedException();
        }

        public void Update(RolUsuario entity)
        {
            throw new NotImplementedException();
        }

        public void Update(RolUsuario entity, Expression<Func<RolUsuario, object>>[] properties)
        {
            throw new NotImplementedException();
        }

        public void SaveChanges()
        {
            _context.SaveChanges();
        }
    }
}
