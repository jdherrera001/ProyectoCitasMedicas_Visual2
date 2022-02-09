using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace Modelo.Entidades
{
    public class Horario
    {
        public int HorarioId { get; set; }
               
        public TimeSpan Hora_Inicio { get; set; }
       
        public TimeSpan Hora_Fin { get; set; }
        public int Cupo_Limite { get; set; }

        public ICollection<Dia> Dias { get; set; }
    }
}