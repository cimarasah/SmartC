using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SmartC.ApplicationCore.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace SmartC.Infrastructure.Data.Mapeamento
{
    internal class SessaoTypeConfiguration : IEntityTypeConfiguration<Sessao>
    {
        public void Configure(EntityTypeBuilder<Sessao> builder)
        {
            builder.ToTable("sessao");

            builder.HasKey(e => e.Id);

            builder.HasIndex(i => i.IdProfissional).HasName("id_profissional");
            
            builder.Property(e => e.NumeroSessao).HasColumnName("numero");
            builder.Property(e => e.DataHoraSessao).HasColumnName("data_hora");
            builder.Property(e => e.Situacao).HasColumnName("situacao");

            

            builder.HasOne(d => d.Profissional).WithMany(p => p.Sessoes).HasForeignKey(e => e.IdProfissional).OnDelete(DeleteBehavior.Restrict);

        }
    }
}
