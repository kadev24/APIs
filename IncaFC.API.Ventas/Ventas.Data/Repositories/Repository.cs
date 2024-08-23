using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ventas.Data;
using Ventas.Domain.Repositories;


namespace Ventas.Data.Repositories
{
    public class Repository<TDbContext>  where TDbContext : IncaFcContext
    {
        public TDbContext _context;

        public Repository(TDbContext dbContext)
        {
            _context = dbContext;
        }

        #region Implementation of IDisposable

        /// <summary>
        /// Performs application-defined tasks associated with freeing, releasing, or resetting unmanaged resources.
        /// </summary>
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        /// <summary>
        /// Disposes off the managed and unmanaged resources used.
        /// </summary>
        /// <param name="disposing"></param>
        private void Dispose(bool disposing)
        {
            if (!disposing)
                return;

            if (_disposed)
                return;

            _disposed = true;
        }

        private bool _disposed;
        #endregion


    }
}
