using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ventas.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace Ventas.Data.Configs
{
    public class ArticuloCategoriaConfig : IEntityTypeConfiguration<ArticuloCategoria>
    {
        public void Configure(EntityTypeBuilder<ArticuloCategoria> builder)
        {
            builder.ToTable("tblArticuloCategoria");
            builder.HasKey(c => c.IdCategoria);
        }
    }
}
