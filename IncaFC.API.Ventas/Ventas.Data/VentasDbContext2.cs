using Microsoft.EntityFrameworkCore;
using Ventas.Domain;
using Ventas.Data.Configs;

namespace Ventas.Data
{
    public class VentasDbContext2: DbContext
    {
        public DbSet<Almacen> ListaAlmacen { get; set; }
        public DbSet<ArticuloMarca> ListaArticuloMarca { get; set; }
        public DbSet<ArticuloCategoria> ListaArticuloCategoria { get; set; }
        public DbSet<Vendedor> ListaVendedor { get; set; }
        public DbSet<PedidoLinea> ListaPedidoLinea { get; set; }
        public DbSet<Pedido> ListaPedido { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-7U19UH0\\SQLEXPRESS;Database=IncaFC;Trusted Connection=True;MultipleActiveResultSets=True");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new ArticuloMarcaConfig());
            modelBuilder.ApplyConfiguration(new ArticuloCategoriaConfig());
            modelBuilder.ApplyConfiguration(new ArticuloConfig());
            modelBuilder.ApplyConfiguration(new ClienteConfig());
            modelBuilder.ApplyConfiguration(new CondicionPagoConfig());
            modelBuilder.ApplyConfiguration(new PedidoConfig());
            modelBuilder.ApplyConfiguration(new PedidoLineaConfig());
            modelBuilder.ApplyConfiguration(new VendedorConfig());

        }
    }
}
