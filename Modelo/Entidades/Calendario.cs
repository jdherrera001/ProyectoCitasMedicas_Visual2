using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Modelo.Entidades
{
    public enum CalendarioEstado { Abierto, Cerrado}

    public class Calendario : IEntidad
    {
        public int CalendarioId { get; set; }
        public string Nombre { get; set; }
        public int Anio { get; set; }

        [DataType(DataType.Date)]
        public DateTime FechaInicio { get; set; }
        
        [DataType(DataType.Date)]
        public DateTime FechaFin { get; set; }
        
        public CalendarioEstado Estado { get; set; } // Abierto Cerrado

        // Relación con los medicos habilitados en un calendario
        public List<Medico> Medicos { get; set; }
        // Relación con las citas realizadas en un calendario
        public List<Cita> Citas { get; set; }
    }
}
