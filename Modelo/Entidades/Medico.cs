using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Modelo.Entidades
{
    public class Medico
    {
        public int MedicoId { get; set; }
        public int Cedula { get; set; }
        public string Nombre { get; set; }
        public string Telefono { get; set; }
        public string Email { get; set; }

        //Relacion con Especialidad
        public int EspecialidadId { get; set; }
        public Especialidad Especialidad { get; set; }
        // Relación con el calendario
        public Calendario Calendario { get; set; }
        public int CalendarioId { get; set; }
        public ICollection<Cita> Citas { get; set; }
        public ICollection<Dia> Dias { get; set; }
       
    }
}