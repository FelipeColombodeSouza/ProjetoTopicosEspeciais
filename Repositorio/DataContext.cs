using Entidades;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositorio
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        public DbSet<Paciente> Paciente { get; set; }
        public DbSet<Profissional> Profissional { get; set; }
        public DbSet<Atendimento> Atendimento { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Paciente>().HasKey(p => p.Id);
            modelBuilder.Entity<Profissional>().HasKey(p => p.Id);
            modelBuilder.Entity<Atendimento>().HasKey(p => p.Id);

            modelBuilder.Entity<Atendimento>().HasOne(p => p.Paciente).WithMany().HasForeignKey(p => p.CodigoPaciente);
            modelBuilder.Entity<Atendimento>().HasOne(p => p.Profissional).WithMany().HasForeignKey(p => p.CodigoProfissional);

            base.OnModelCreating(modelBuilder);
        }
    }
}
