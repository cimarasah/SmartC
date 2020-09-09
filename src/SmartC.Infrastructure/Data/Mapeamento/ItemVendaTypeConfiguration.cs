using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SmartC.ApplicationCore.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace SmartC.Infrastructure.Data.Mapeamento
{
    internal class ItemVendaTypeConfiguration : IEntityTypeConfiguration<ItemVenda>
    {
        public void Configure(EntityTypeBuilder<ItemVenda> builder)
        {
            builder.ToTable("item_venda");

            builder.HasKey(e => e.IdItemVenda);

            builder.HasIndex(i => i.IdVenda).HasName("id_venda");
            builder.HasIndex(i => i.IdItemClinica).HasName("id_item_clinica");
            builder.Property(e => e.Valor).HasColumnName("valor");
            builder.Property(e => e.QuantidadeItem).HasColumnName("qtd_item");

            builder.HasOne(d => d.ItemClinica).WithMany(p => p.ItensVenda).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(d => d.Venda).WithMany(p => p.ItensVenda).OnDelete(DeleteBehavior.Restrict);

        }
    }
}
