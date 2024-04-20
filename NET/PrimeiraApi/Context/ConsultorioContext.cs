using System;
using Microsoft.EntityFrameworkCore;
using PrimeiraApi.Models.Entities;

namespace PrimeiraApi.Context
{
    public class ConsultorioContext : DbContext
    {
        public ConsultorioContext(DbContextOptions options) : base(options)
        { }
        public DbSet<Consulta> Consultas { get; set; }
        public DbSet<Especialidade> Especialidades { get; set; }
        public DbSet<Paciente> Pacientes { get; set; }
        public DbSet<Profissional> Profissionais { get; set; }
        public DbSet<ProfissionalEspecialidade> ProfissionalEspecialidades { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(GetType().Assembly);
        }
    }
}
