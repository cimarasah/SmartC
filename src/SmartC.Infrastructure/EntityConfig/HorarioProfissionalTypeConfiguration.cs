using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SmartC.ApplicationCore.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace SmartC.Infrastructure.Entity
{
    internal class HorarioProfissionalTypeConfiguration : IEntityTypeConfiguration<HorarioProfissional>
    {
        public void Configure(EntityTypeBuilder<HorarioProfissional> builder)
        {
            builder.ToTable("horario_profissional");

            builder.HasKey(e => e.Id);

            builder.HasIndex(i => i.IdProfissional).HasName("id_profissional");
            builder.Property(e => e.DiaSemana).HasColumnName("dia_semana");
            builder.Property(e => e.HoraInicial).HasColumnName("hora_inicial");
            builder.Property(e => e.HoraFinal).HasColumnName("hora_final");
            builder.HasOne(d => d.Profissional).WithMany(p => p.Horarios).OnDelete(DeleteBehavior.Restrict);


        }
    }
}
