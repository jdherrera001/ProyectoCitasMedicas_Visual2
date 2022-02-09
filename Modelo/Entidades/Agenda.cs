using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Entidades
{
    public class Agenda
    {
        public int AgendaId { get; set; }
        public int Cupos_Disponibles { get; set; }
        public string Estado { get; set; }
    }
}
