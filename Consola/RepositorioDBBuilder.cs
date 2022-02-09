using Microsoft.EntityFrameworkCore;
using ModeloBD;
using System.Configuration;

namespace Consola
{
    public class RepositorioDBBuilder
    {
        const string DBTipo = "DBTipo";
        enum DBTipoConn { SqlServer, Postgres, MySql, Memoria }
        static Repositorio repos ;

        public static Repositorio Crear()
        {
            // Lee la configuración acerca de qué base usar del archivo App.config
            string dbtipo = ConfigurationManager.AppSettings[DBTipo];
            string conn = ConfigurationManager.ConnectionStrings[dbtipo].ConnectionString;
            // Construye la conección acorde con el tipo
            DbContextOptions<Repositorio> contextOptions;
            switch (dbtipo)
            {
                case nameof(DBTipoConn.SqlServer) :
                    contextOptions = new DbContextOptionsBuilder<Repositorio>()
                        .UseSqlServer(conn)
                        .Options;
                    break;
                case nameof(DBTipoConn.Postgres):
                    contextOptions = new DbContextOptionsBuilder<Repositorio>()
                        .UseNpgsql(conn)
                        .Options;
                    break;
                case nameof(DBTipoConn.MySql):
                    contextOptions = new DbContextOptionsBuilder<Repositorio>()
                        .UseNpgsql(conn)
                        .Options;
                    break;
                default: // Por defecto usa la memoria como base de datos
                    contextOptions = new DbContextOptionsBuilder<Repositorio>()
                        .UseInMemoryDatabase(conn)
                        .Options;
                    break;
            }

            repos = new Repositorio(contextOptions);

            return repos;
        }        
    }
}
