using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SmartC.ApplicationCore.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace SmartC.Infrastructure.Data.Mapeamento
{
    internal class ProfissionalTypeConfiguration : IEntityTypeConfiguration<Profissional>
    {
        public void Configure(EntityTypeBuilder<Profissional> builder)
        {
            builder.ToTable("profissional");

            builder.HasKey(e => e.Id);

            builder.HasIndex(i => i.IdClinica).HasName("id_clinica");
            builder.HasIndex(i => i.IdUsuario).HasName("id_usuario");
            builder.Property(e => e.Nome).HasColumnName("nome");
            builder.Property(e => e.Telefone).HasColumnName("telefone");

            builder.HasOne(d => d.Clinica).WithMany(p => p.Profissionais).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(d => d.Usuario).WithMany(p => p.Profissionais).OnDelete(DeleteBehavior.Restrict);


        }
    }
}
