using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SmartC.ApplicationCore.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace SmartC.Infrastructure.Entity
{
    internal class CaixaTypeConfiguration : IEntityTypeConfiguration<Caixa>
    {
        public void Configure(EntityTypeBuilder<Caixa> builder)
        {
            builder.ToTable("caixa");

            builder.HasKey(e => e.Id);

            builder.Property(e => e.ValorAtual).HasColumnName("valor_total");
            builder.HasIndex(i => i.IdClinica).HasName("id_clinica");            
            builder.HasOne(d => d.Clinica).WithOne(p => p.Caixa).OnDelete(DeleteBehavior.Restrict);


        }
    }
}
