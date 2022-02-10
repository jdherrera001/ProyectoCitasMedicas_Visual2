using Consola;
using Microsoft.EntityFrameworkCore;
using ModeloBD;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pruebas_U
{
    public sealed class DBBuilder
    {
        private DBBuilder() { }

        private static Repositorio repos;

        public static Repositorio GetDB()
        {
            if (repos == null)
            {
                Grabar grabar = new Grabar();
                grabar.DatosIni();
                repos = RepositorioDBBuilder.Crear();
            }
            return repos;
        }
    }
}
