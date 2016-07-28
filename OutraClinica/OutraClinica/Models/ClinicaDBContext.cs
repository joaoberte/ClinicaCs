using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace OutraClinica.Models
{
    public class ClinicaDBContext : DbContext
    {
        public DbSet<Paciente> Paciente { get; set; }
        public DbSet<PlanoDeSaude> PlanoDeSaude { get; set; }
        public DbSet<Funcionario> Funcionario { get; set; }
        public DbSet<Medico> Medico { get; set; }
        public DbSet<Consulta> Consulta { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

            modelBuilder.Entity<Paciente>().ToTable("Pacientes");
            modelBuilder.Entity<PlanoDeSaude>().ToTable("PlanosDeSaude");
            modelBuilder.Entity<Funcionario>().ToTable("Funcionarios");
            modelBuilder.Entity<Medico>().ToTable("Medicos");
            modelBuilder.Entity<Consulta>().ToTable("Consultas");
        }
    }
}