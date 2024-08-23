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
    public class CondicionPagoConfig : IEntityTypeConfiguration<CondicionPago>
    {
        public void Configure(EntityTypeBuilder<CondicionPago> builder)
        {
            builder.ToTable("tblCondicionPagoConfig");
            builder.HasKey(c => c.IdCondicionPago);
        }
    }
}
