using Microsoft.EntityFrameworkCore.Storage;
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
    public class PedidoRepository : Repository<IncaFcContext>, IPedidoRepository 
    {
        public PedidoRepository(IncaFcContext context): base (context) { }

        public void Add(Pedido entity)
        {
            _context.Add(entity);
        }

        public void Attach(Pedido entity)
        {
            throw new NotImplementedException();
        }

        public int Count()
        {
            throw new NotImplementedException();
        }

        public int Count(Expression<Func<Pedido, bool>> criteria)
        {
            throw new NotImplementedException();
        }

        public void Delete(Pedido entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Expression<Func<Pedido, bool>> criteria)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Pedido> Find(Expression<Func<Pedido, bool>> criteria)
        {
            throw new NotImplementedException();
        }

        public Pedido FindOne(Expression<Func<Pedido, bool>> criteria)
        {
            throw new NotImplementedException();
        }

        public Pedido First(Expression<Func<Pedido, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Pedido> Get<TOrderBy>(Expression<Func<Pedido, TOrderBy>> orderBy, int pageIndex, int pageSize, SortOrder sortOrder = SortOrder.Ascending)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Pedido> Get<TOrderBy>(Expression<Func<Pedido, bool>> criteria, Expression<Func<Pedido, TOrderBy>> orderBy, int pageIndex, int pageSize, SortOrder sortOrder = SortOrder.Ascending)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Pedido> GetAll()
        {
            return _context.Pedidos;
        }

        public Pedido GetByKey(object keyValue)
        {
            throw new NotImplementedException();
        }

        public IQueryable<TEntity> GetQuery<TEntity>()
        {
            throw new NotImplementedException();
        }

        public IQueryable<Pedido> GetQuery(Expression<Func<Pedido, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public TEntity Single<TEntity>(Expression<Func<TEntity, bool>> criteria) where TEntity : class
        {
            throw new NotImplementedException();
        }

        public void Update(Pedido entity)
        {
            throw new NotImplementedException();
        }

        public void Update(Pedido entity, Expression<Func<Pedido, object>>[] properties)
        {
            throw new NotImplementedException();
        }

        public void SaveChanges()
        {
            _context.SaveChanges();
        }
    }
}
