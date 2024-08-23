using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Ventas.Domain;

namespace Ventas.Data;

public partial class IncaFcContext : DbContext
{
    public IncaFcContext()
    {
    }

    public IncaFcContext(DbContextOptions<IncaFcContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Almacen> Almacens { get; set; }

    public virtual DbSet<Articulo> Articulos { get; set; }

    public virtual DbSet<ArticuloCategorium> ArticuloCategoria { get; set; }

    public virtual DbSet<ArticuloMarca> ArticuloMarcas { get; set; }

    public virtual DbSet<Cliente> Clientes { get; set; }

    public virtual DbSet<CondicionPago> CondicionPagos { get; set; }

    public virtual DbSet<Pedido> Pedidos { get; set; }

    public virtual DbSet<PedidoLinea> PedidoLineas { get; set; }

    public virtual DbSet<RolUsuario> RolUsuarios { get; set; }

    public virtual DbSet<Usuario> Usuarios { get; set; }

    public virtual DbSet<Vendedor> Vendedors { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer("Name=ConnectionStrings:DefaultConnection");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Almacen>(entity =>
        {
            entity.HasKey(e => e.IdAlmacen).HasName("PK__Almacen__7339837BAC783DED");

            entity.ToTable("Almacen", "Ventas");

            entity.Property(e => e.Direccion)
                .HasMaxLength(300)
                .IsUnicode(false);
            entity.Property(e => e.Nombre)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Articulo>(entity =>
        {
            entity.HasKey(e => e.IdArticulo).HasName("PK__Articulo__F8FF5D52B8298713");

            entity.ToTable("Articulo", "Ventas");

            entity.Property(e => e.Descripcion)
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.HasOne(d => d.IdCategoriaNavigation).WithMany(p => p.Articulos)
                .HasForeignKey(d => d.IdCategoria)
                .HasConstraintName("FK__Articulo__IdCate__3C69FB99");

            entity.HasOne(d => d.IdMarcaNavigation).WithMany(p => p.Articulos)
                .HasForeignKey(d => d.IdMarca)
                .HasConstraintName("FK__Articulo__IdMarc__3B75D760");
        });

        modelBuilder.Entity<ArticuloCategorium>(entity =>
        {
            entity.HasKey(e => e.IdCategoria).HasName("PK__Articulo__A3C02A10E0638225");

            entity.ToTable("ArticuloCategoria", "Ventas");

            entity.Property(e => e.Descripcion)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<ArticuloMarca>(entity =>
        {
            entity.HasKey(e => e.IdMarca).HasName("PK__Articulo__4076A887F9993861");

            entity.ToTable("ArticuloMarca", "Ventas");

            entity.Property(e => e.Descripcion)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Cliente>(entity =>
        {
            entity.HasKey(e => e.IdCliente).HasName("PK__Cliente__D594664285F728AA");

            entity.ToTable("Cliente", "Ventas");

            entity.Property(e => e.DireccionFiscal)
                .HasMaxLength(300)
                .IsUnicode(false);
            entity.Property(e => e.RazonSocial)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Telefono)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.TipoCliente)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Ubigeo)
                .HasMaxLength(20)
                .IsUnicode(false);
        });

        modelBuilder.Entity<CondicionPago>(entity =>
        {
            entity.HasKey(e => e.IdCondicionPago).HasName("PK__Condicio__7FC8A226ACB4C1AE");

            entity.ToTable("CondicionPago", "Ventas");

            entity.Property(e => e.Descripcion)
                .HasMaxLength(300)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Pedido>(entity =>
        {
            entity.HasKey(e => e.IdPedido).HasName("PK__Pedido__9D335DC3015589DC");

            entity.ToTable("Pedido", "Ventas");

            entity.Property(e => e.EstadoPedido)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.FechaModifica).HasColumnType("datetime");
            entity.Property(e => e.FechaPedido).HasColumnType("datetime");
            entity.Property(e => e.FechaRegistro).HasColumnType("datetime");
            entity.Property(e => e.Total).HasColumnType("decimal(10, 2)");
            entity.Property(e => e.TotalDescuento).HasColumnType("decimal(10, 2)");
            entity.Property(e => e.UsuarioModifica)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.UsuarioRegistro)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.HasOne(d => d.IdClienteNavigation).WithMany(p => p.Pedidos)
                .HasForeignKey(d => d.IdCliente)
                .HasConstraintName("FK__Pedido__IdClient__46E78A0C");

            entity.HasOne(d => d.IdCondicionPagoNavigation).WithMany(p => p.Pedidos)
                .HasForeignKey(d => d.IdCondicionPago)
                .HasConstraintName("FK__Pedido__IdCondic__48CFD27E");

            entity.HasOne(d => d.IdVendedorNavigation).WithMany(p => p.Pedidos)
                .HasForeignKey(d => d.IdVendedor)
                .HasConstraintName("FK__Pedido__IdVended__47DBAE45");
        });

        modelBuilder.Entity<PedidoLinea>(entity =>
        {
            entity.HasKey(e => e.IdPedidoLinea).HasName("PK__PedidoLi__8BEF9FD7F8B98BF1");

            entity.ToTable("PedidoLinea", "Ventas");

            entity.Property(e => e.Descuento).HasColumnType("decimal(10, 2)");
            entity.Property(e => e.FechaModifica).HasColumnType("datetime");
            entity.Property(e => e.FechaRegistro).HasColumnType("datetime");
            entity.Property(e => e.ImpuestoIgv).HasColumnType("decimal(10, 2)");
            entity.Property(e => e.Moneda)
                .HasMaxLength(5)
                .IsUnicode(false);
            entity.Property(e => e.PrecioLista).HasColumnType("decimal(10, 2)");
            entity.Property(e => e.Subtotal).HasColumnType("decimal(10, 2)");
            entity.Property(e => e.UsuarioModifica)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.UsuarioRegistro)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.HasOne(d => d.IdAlmacenNavigation).WithMany(p => p.PedidoLineas)
                .HasForeignKey(d => d.IdAlmacen)
                .HasConstraintName("FK__PedidoLin__IdAlm__4D94879B");

            entity.HasOne(d => d.IdArticuloNavigation).WithMany(p => p.PedidoLineas)
                .HasForeignKey(d => d.IdArticulo)
                .HasConstraintName("FK__PedidoLin__IdArt__4CA06362");

            entity.HasOne(d => d.IdPedidoNavigation).WithMany(p => p.PedidoLineas)
                .HasForeignKey(d => d.IdPedido)
                .HasConstraintName("FK__PedidoLin__IdPed__4BAC3F29");
        });

        modelBuilder.Entity<RolUsuario>(entity =>
        {
            entity.HasKey(e => e.IdUsuarioRol).HasName("PK__RolUsuar__6806BF4A1C3C586C");

            entity.ToTable("RolUsuario", "Seguridad");

            entity.Property(e => e.Rol)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.HasOne(d => d.IdUsuarioNavigation).WithMany(p => p.RolUsuarios)
                .HasForeignKey(d => d.IdUsuario)
                .HasConstraintName("FK__RolUsuari__IdUsu__52593CB8");
        });

        modelBuilder.Entity<Usuario>(entity =>
        {
            entity.HasKey(e => e.IdUsuario).HasName("PK__Usuario__5B65BF975E7E7844");

            entity.ToTable("Usuario", "Seguridad");

            entity.Property(e => e.Clave)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Correo)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Usuario1)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Usuario");
        });

        modelBuilder.Entity<Vendedor>(entity =>
        {
            entity.HasKey(e => e.IdVendedor).HasName("PK__Vendedor__16D6C7CA6F87E50C");

            entity.ToTable("Vendedor", "Ventas");

            entity.Property(e => e.Nombre)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
