using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SmartC.ApplicationCore.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace SmartC.Infrastructure.Entity
{
    internal class UsuarioTypeConfiguration : IEntityTypeConfiguration<Usuario>
    {
        public void Configure(EntityTypeBuilder<Usuario> builder)
        {
            builder.ToTable("usuario");

            builder.HasKey(e => e.Id);
             
            builder.Property(e => e.Email).HasColumnName("email");
            builder.Property(e => e.Senha).HasColumnName("senha");
            builder.HasIndex(i => i.IdPerfil).HasName("id_perfil");

            builder.HasOne(d => d.Perfil).WithMany(p => p.Usuarios).OnDelete(DeleteBehavior.Restrict);
        }
    }
}
