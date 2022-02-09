using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Entidades
{
    public enum SexoPaciente { Masculino, Femenino}
    public class InformacionPaciente
    {
        public int InformacionPacienteId { get; set; }
        public string Ciudad { get; set; }
        public string Telefono_Convencional { get; set; }
        public string Telefono_Movil { get; set; }
        public SexoPaciente Sexo { get; set; }

        //Relacion 1 a 1 con Paciente
        public Paciente Paciente { get; set; }
    }
}
