using Microsoft.EntityFrameworkCore;
using Modelo.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModeloBD
{
    public class Repositorio :DbContext
    {

        public Repositorio(DbContextOptions<Repositorio> options)
            : base(options)
        {

        }
        // Se asegura el borrado y la creación de la base de datos
        public void PreparaDB()
        {
            Database.EnsureDeleted();
            Database.EnsureCreated();
        }
        public DbSet<Cita> citas { get; set; }
        public DbSet<Paciente> pacientes { get; set; }
        public DbSet<Medico> medicos { get; set; }
        public DbSet<Dia> dias { get; set; }
        public DbSet<Horario> horarios { get; set; }
        public DbSet<Especialidad> especialidades { get; set; }
        public DbSet<InformacionPaciente> informacionpacientes { get; set; }
        public DbSet<Calendario> calendarios { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
           //// if (!options.IsConfigured)
           //// {
           //     //options.UseSqlServer("Data Source=DESKTOP-RLNFUSA;Integrated Security=true; Initial Catalog=CitasMedicasV3");
           //     options.UseMySQL("server=localhost;database=sga2; user=root; password=soporte");
           //// }
        }
        protected override void OnModelCreating(ModelBuilder model)
        {
            //CITA - PACIENTE           ----UNO A  VARIOS
            model.Entity<Cita>()
            .HasOne(cita => cita.Paciente)
            .WithMany(paciente => paciente.Citas)
            //.OnDelete(DeleteBehavior.NoAction)          //DESACTIVAR BORRADO EN CASCADA
            .HasForeignKey(cita => cita.PacienteId);
            
            //CITA - MEDICO             ----UNO A  VARIOS
            model.Entity<Cita>()
            .HasOne(cita => cita.Medico)
            .WithMany(medico => medico.Citas)
            .HasForeignKey(cita => cita.MedicoId);

            // CITA y CALENDARIOS
            model.Entity<Cita>()
                .HasOne(cita => cita.Calendario)
                .WithMany(calendario => calendario.Citas)
                .OnDelete(DeleteBehavior.NoAction)
                .HasForeignKey(cita => cita.CalendarioId);

            //MEDICO - ESPECIALIDAD     ----UNO A  VARIOS
            model.Entity<Medico>()
            .HasOne(medico => medico.Especialidad)
            .WithMany(especialidad => especialidad.Medicos)
            .OnDelete(DeleteBehavior.NoAction)
            .HasForeignKey(medico => medico.EspecialidadId);
            
            // CLAVE PRIMARIA COMPUESTA
            model.Entity<Dia>()               
               .HasKey(dh => new { dh.HorarioId, dh.MedicoId });
            
            //DIAS - HORARIO       ----UNO A  VARIOS
            model.Entity<Dia>()            
            .HasOne(dia => dia.Horario)
            .WithMany(horario => horario.Dias)
            .OnDelete(DeleteBehavior.NoAction)
            .HasForeignKey(dia => dia.HorarioId);
            
            // MEDICO - DIA         ----UNO A  VARIOS
            model.Entity<Dia>()            
            .HasOne(dia => dia.Medico)
            .WithMany(medico => medico.Dias)
            .OnDelete(DeleteBehavior.NoAction)      
            .HasForeignKey(dia => dia.MedicoId);

            // PACIENTE - INFORMACION PACIENTE      ----UNO A UNO
            model.Entity<Paciente>()
            .HasOne<InformacionPaciente>(inf => inf.InformacionPaciente)
            .WithOne(p => p.Paciente)
            .HasForeignKey<InformacionPaciente>(p => p.InformacionPacienteId);
        }
    }
}
