using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace Modelo.Entidades
{
    public enum EstadoCita { Pendiente,Confirmado,Rechazado}
    
    public class Cita
    {
        public int CitaId { get; set; }
        
        [DataType(DataType.Date)]
        public DateTime Fecha_Cita { get; set; }
        
        [DataType(DataType.Date)]
        public DateTime Fecha_Registro { get; set; }
       
        public TimeSpan Hora { get; set; }
        public EstadoCita Estado { get; set; }
        //Relacion con Paciente
        public int PacienteId { get; set; }
        public Paciente Paciente { get; set; }
        //Relacion con Medico
        public int MedicoId { get; set; }
        public Medico Medico { get; set; }
        // Relación con el calendario
        public Calendario Calendario { get; set; }
        public int CalendarioId { get; set; }
      
    }
}