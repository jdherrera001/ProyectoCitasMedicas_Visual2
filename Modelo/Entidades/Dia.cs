using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Modelo.Entidades
{
    public class Dia
    {
        //public int DiaId { get; set; }
        public string dia { get; set; }

        //Relacion muchos a muchos Horario-Medico
        public int HorarioId { get; set; }
        public Horario Horario { get; set; }
        //Relacion muchos a muchos Horario-Medico
        public int MedicoId { get; set; }
        public Medico Medico { get; set; }
    }
}