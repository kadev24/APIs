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
    public class VendedorRepository: Repository<IncaFcContext>, IVendedorRepository
    {
        public VendedorRepository(IncaFcContext context) : base(context) { }

        public void Add(Vendedor entity)
        {
            throw new NotImplementedException();
        }

        public void Attach(Vendedor entity)
        {
            throw new NotImplementedException();
        }

        public int Count()
        {
            throw new NotImplementedException();
        }

        public int Count(Expression<Func<Vendedor, bool>> criteria)
        {
            throw new NotImplementedException();
        }

        public void Delete(Vendedor entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Expression<Func<Vendedor, bool>> criteria)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Vendedor> Find(Expression<Func<Vendedor, bool>> criteria)
        {
            throw new NotImplementedException();//return DbContext.Vendedors.Where(criteria);
        }

        public Vendedor FindOne(Expression<Func<Vendedor, bool>> criteria)
        {
            throw new NotImplementedException();
        }

        public Vendedor First(Expression<Func<Vendedor, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Vendedor> Get<TOrderBy>(Expression<Func<Vendedor, TOrderBy>> orderBy, int pageIndex, int pageSize, SortOrder sortOrder = SortOrder.Ascending)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Vendedor> Get<TOrderBy>(Expression<Func<Vendedor, bool>> criteria, Expression<Func<Vendedor, TOrderBy>> orderBy, int pageIndex, int pageSize, SortOrder sortOrder = SortOrder.Ascending)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Vendedor> GetAll()
        {
            throw new NotImplementedException();
        }

        public Vendedor GetByKey(object keyValue)
        {
            throw new NotImplementedException();
        }

        public IQueryable<TEntity> GetQuery<TEntity>()
        {
            throw new NotImplementedException();
        }

        public IQueryable<Vendedor> GetQuery(Expression<Func<Vendedor, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public TEntity Single<TEntity>(Expression<Func<TEntity, bool>> criteria) where TEntity : class
        {
            throw new NotImplementedException();
        }

        public void Update(Vendedor entity)
        {
            throw new NotImplementedException();
        }

        public void Update(Vendedor entity, Expression<Func<Vendedor, object>>[] properties)
        {
            throw new NotImplementedException();
        }

        public void SaveChanges()
        {
            _context.SaveChanges();
        }
    }
}
