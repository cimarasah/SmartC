using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SmartC.ApplicationCore.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace SmartC.Infrastructure.Entity
{
    internal class ClinicaTypeConfiguration : IEntityTypeConfiguration<Clinica>
    {
        public void Configure(EntityTypeBuilder<Clinica> builder)
        {
            builder.ToTable("clinica");

            builder.HasKey(e => e.Id);

            builder.Property(e => e.RazaoSocial).HasColumnName("razao_social");
            builder.Property(e => e.NomeFantasia).HasColumnName("nome_fantasia");
            builder.Property(e => e.Cnpj).HasColumnName("cnpj");
            builder.Property(e => e.Telefone).HasColumnName("telefone");
            builder.Property(e => e.Email).HasColumnName("email");
            builder.Property(e => e.CEP).HasColumnName("cep");
            builder.Property(e => e.Rua).HasColumnName("endereco");
            builder.Property(e => e.Numero).HasColumnName("numero_endereco");
            builder.Property(e => e.Bairro).HasColumnName("bairro");
            builder.Property(e => e.Cidade).HasColumnName("cidade");
            builder.Property(e => e.Estado).HasColumnName("estado");
            builder.Property(e => e.Ativo).HasColumnName("ativo");
            
        }
    }
}
