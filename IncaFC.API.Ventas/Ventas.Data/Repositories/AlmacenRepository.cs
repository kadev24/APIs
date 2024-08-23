using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Ventas.Domain;
using Ventas.Domain.Repositories;
using Ventas.Domain.Repositorios;

namespace Ventas.Data.Repositories
{
    public class AlmacenRepository : Repository<IncaFcContext>, IAlmacenRepository
    {
        public AlmacenRepository(IncaFcContext context) : base(context) { }

        public void Add(Almacen entity)
        {
            throw new NotImplementedException();
        }

        public void Attach(Almacen entity)
        {
            throw new NotImplementedException();
        }

        public int Count()
        {
            throw new NotImplementedException();
        }

        public int Count(Expression<Func<Almacen, bool>> criteria)
        {
            throw new NotImplementedException();
        }

        public void Delete(Almacen entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Expression<Func<Almacen, bool>> criteria)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Almacen> Find(Expression<Func<Almacen, bool>> criteria)
        {
            throw new NotImplementedException();
        }

        public Almacen FindOne(Expression<Func<Almacen, bool>> criteria)
        {
            throw new NotImplementedException();
        }

        public Almacen First(Expression<Func<Almacen, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Almacen> Get<TOrderBy>(Expression<Func<Almacen, TOrderBy>> orderBy, int pageIndex, int pageSize, SortOrder sortOrder = SortOrder.Ascending)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Almacen> Get<TOrderBy>(Expression<Func<Almacen, bool>> criteria, Expression<Func<Almacen, TOrderBy>> orderBy, int pageIndex, int pageSize, SortOrder sortOrder = SortOrder.Ascending)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Almacen> GetAll()
        {
            throw new NotImplementedException();
        }

        public Almacen GetByKey(object keyValue)
        {
            throw new NotImplementedException();
        }

        public IQueryable<TEntity> GetQuery<TEntity>()
        {
            throw new NotImplementedException();
        }

        public IQueryable<Almacen> GetQuery(Expression<Func<Almacen, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public TEntity Single<TEntity>(Expression<Func<TEntity, bool>> criteria) where TEntity : class
        {
            throw new NotImplementedException();
        }

        public void Update(Almacen entity)
        {
            throw new NotImplementedException();
        }

        public void Update(Almacen entity, Expression<Func<Almacen, object>>[] properties)
        {
            throw new NotImplementedException();
        }

        public void SaveChanges()
        {
            _context.SaveChanges();
        }
    }
}
