using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SmartC.ApplicationCore.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace SmartC.Infrastructure.Entity
{
    internal class EstoqueTypeConfiguration : IEntityTypeConfiguration<Estoque>
    {
        public void Configure(EntityTypeBuilder<Estoque> builder)
        {
            builder.ToTable("estoque");

            builder.HasKey(e => e.Id);

            builder.HasIndex(i => i.IdProduto).HasName("id_produto");
            builder.Property(e => e.QuantidadeProduto).HasColumnName("qtd_produto");
            builder.HasOne(d => d.Produto).WithOne(p => p.Estoque).OnDelete(DeleteBehavior.Restrict);


        }
    }
}
