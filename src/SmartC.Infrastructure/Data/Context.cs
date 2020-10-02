using Microsoft.EntityFrameworkCore;
using SmartC.ApplicationCore.Entities;
using SmartC.Infrastructure.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace SmartC.Infrastructure.Data
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options) : base(options)
        {

        }
        public DbSet<Paciente> Pacientes { get; set; }
        public DbSet<Sessao> Sessoes { get; set; }
        public DbSet<Profissional> Profissionais { get; set; }
        public DbSet<Clinica> Clinicas { get; set; }
        public DbSet<ItemClinica> ItensClinica { get; set; }
        public DbSet<ItemVenda> ItensVenda { get; set; }
        public DbSet<Perfil> Perfis { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Venda> Vendas { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.ApplyConfiguration(new ItemVendaTypeConfiguration());
            modelBuilder.ApplyConfiguration(new SessaoTypeConfiguration());
            modelBuilder.ApplyConfiguration(new PacienteTypeConfiguration());
            modelBuilder.ApplyConfiguration(new ClinicaTypeConfiguration());
            modelBuilder.ApplyConfiguration(new ItemClinicaTypeConfiguration());
            modelBuilder.ApplyConfiguration(new PerfilTypeConfiguration());
            modelBuilder.ApplyConfiguration(new ProfissionalTypeConfiguration());
            modelBuilder.ApplyConfiguration(new UsuarioTypeConfiguration());
            modelBuilder.ApplyConfiguration(new VendaTypeConfiguration());
        }
    }
}
