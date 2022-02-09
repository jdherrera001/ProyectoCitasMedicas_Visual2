using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Modelo.Entidades
{
    public class Paciente
    {
        public int PacienteId { get; set; }
        public int Cedula { get; set; }
        public string Nombre { get; set; }
        public string Email { get; set; }

        //Relacion 1 a 1 con informacion paciente
        public InformacionPaciente InformacionPaciente { get; set; }
        public ICollection<Cita> Citas { get; set; }
    }
}