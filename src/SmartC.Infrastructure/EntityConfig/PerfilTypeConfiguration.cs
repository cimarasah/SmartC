using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SmartC.ApplicationCore.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace SmartC.Infrastructure.Entity
{
    internal class PerfilTypeConfiguration : IEntityTypeConfiguration<Perfil>
    {
        public void Configure(EntityTypeBuilder<Perfil> builder)
        {
            builder.ToTable("perfil");

            builder.HasKey(e => e.Id);

            builder.HasIndex(i => i.Descricao).HasName("descricao");

        }
    }
}
