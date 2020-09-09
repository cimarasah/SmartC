using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SmartC.ApplicationCore.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace SmartC.Infrastructure.Data.Mapeamento
{
    internal class ItemClinicaTypeConfiguration : IEntityTypeConfiguration<ItemClinica>
    {
        public void Configure(EntityTypeBuilder<ItemClinica> builder)
        {
            builder.ToTable("item_clinica");

            builder.HasKey(e => e.Id);

            builder.HasIndex(i => i.IdClinica).HasName("id_clinica");
            builder.Property(e => e.Status).HasColumnName("status");

            builder.HasOne(d => d.Clinica).WithMany(p => p.ItensClinica).OnDelete(DeleteBehavior.Restrict);

        }
    }
}
