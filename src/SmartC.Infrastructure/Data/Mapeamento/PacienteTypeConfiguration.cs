using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SmartC.ApplicationCore.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace SmartC.Infrastructure.Data.Mapeamento
{
    internal class PacienteTypeConfiguration : IEntityTypeConfiguration<Paciente>
    {
        public void Configure(EntityTypeBuilder<Paciente> builder)
        {
            builder.ToTable("paciente");

            builder.HasKey(e => e.Id);

            builder.HasIndex(i => i.IdClinica).HasName("id_clinica");
            builder.Property(e => e.Nome).HasColumnName("nome");
            builder.Property(e => e.DataNascimento).HasColumnName("data_nascimento");
            builder.Property(e => e.Telefone).HasColumnName("telefone");
            builder.Property(e => e.Email).HasColumnName("email");
            builder.Property(e => e.CEP).HasColumnName("cep");
            builder.Property(e => e.Rua).HasColumnName("endereco");
            builder.Property(e => e.Numero).HasColumnName("numero_endereco");
            builder.Property(e => e.Bairro).HasColumnName("bairro");
            builder.Property(e => e.Cidade).HasColumnName("cidade");
            builder.Property(e => e.Estado).HasColumnName("estado");
            builder.Property(e => e.Ativo).HasColumnName("ativo");

            builder.HasOne(d => d.Clinica).WithMany(p => p.Pacientes).OnDelete(DeleteBehavior.Restrict);

        }
    }
}
