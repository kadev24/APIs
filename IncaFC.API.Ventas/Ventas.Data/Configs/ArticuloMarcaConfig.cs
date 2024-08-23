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
    public class ArticuloMarcaConfig : IEntityTypeConfiguration<ArticuloMarca>
    {
        public void Configure(EntityTypeBuilder<ArticuloMarca> builder)
        {
            builder.ToTable("tblArticuloMarca");
            builder.HasKey(c => c.IdMarca);
        }
    }
}
