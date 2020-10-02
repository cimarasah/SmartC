using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SmartC.ApplicationCore.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace SmartC.Infrastructure.Entity
{
    internal class ItemPacoteTypeConfiguration : IEntityTypeConfiguration<ItemPacote>
    {
        public void Configure(EntityTypeBuilder<ItemPacote> builder)
        {
            builder.ToTable("item_pacote");

            builder.HasKey(e => e.Id);

            builder.HasIndex(i => i.IdPacote).HasName("id_pacote");
            builder.HasIndex(i => i.IdServico).HasName("id_servico");

            builder.HasOne(d => d.Pacote).WithMany(p => p.ItensPacote).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(d => d.Servico).WithMany(p => p.ItensPacote).OnDelete(DeleteBehavior.Restrict);

        }
    }
}
