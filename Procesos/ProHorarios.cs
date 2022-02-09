using Microsoft.EntityFrameworkCore;
using Modelo.Entidades;
using ModeloBD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Procesos
{
    public class ProHorarios
    {
        readonly Repositorio repos;

        public ProHorarios(Repositorio repos)
        {
            this.repos = repos;
        }

        public bool Aprobo(Medico medico, Dia dia)
        {
            var prerequisitos = new List<Medico>();

            // Consultar la medico
            var tmpMateria = repos.medicos
                .Include(mat => mat.Dias)
                .Single(mat => mat.MedicoId == medico.MedicoId);

            // Consultar los horarios
            var tmpPreReq = repos.dias
                .Include(pre => pre.Medico)
                    .ThenInclude(dia => dia.Dias)
                        .ThenInclude(dia => dia.Horario);

            return true;
        }
    }
}
