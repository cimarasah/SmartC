using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SmartC.ApplicationCore.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace SmartC.Infrastructure.Entity
{
    internal class VendaTypeConfiguration : IEntityTypeConfiguration<Venda>
    {
        public void Configure(EntityTypeBuilder<Venda> builder)
        {
            builder.ToTable("venda");

            builder.HasKey(e => e.Id);

            builder.HasIndex(i => i.IdPaciente).HasName("id_paciente");
            builder.HasIndex(i => i.IdProfissional).HasName("id_profissional");
            builder.Property(e => e.DataHora).HasColumnName("data_hora");
            builder.Property(e => e.QuantidadeItens).HasColumnName("qtd_itens");
            builder.Property(e => e.ValorTotal).HasColumnName("valor_total");
            builder.Property(e => e.Desconto).HasColumnName("desconto");

            builder.HasOne(d => d.Paciente).WithMany(p => p.Vendas).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(d => d.Profissional).WithMany(p => p.Vendas).OnDelete(DeleteBehavior.Restrict);

        }
    }
}
