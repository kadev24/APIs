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
    public class PedidoLineaConfig : IEntityTypeConfiguration<PedidoLinea>
    {
        public void Configure(EntityTypeBuilder<PedidoLinea> builder)
        {
            builder.ToTable("tblPedidoLinea");
            builder.HasKey(c => c.IdPedidoLinea);
        }
    }
}
