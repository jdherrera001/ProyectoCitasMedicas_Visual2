using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Modelo.Entidades
{
    public class Especialidad
    {
        public int EspecialidadId { get; set; }
        public string Nombre { get; set; }
        public ICollection<Medico> Medicos  { get; set; }   
}
}