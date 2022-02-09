using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Modelo.Operaciones;
using ModeloBD;
using System.Linq;

namespace WebApp.Controllers
{
    public class Citas1Controller : Controller
    {
        // DbContext
        private readonly Repositorio repos;

        public Citas1Controller(Repositorio repos)
        {
            this.repos = repos;
        }

        // Listado de citas
        public IActionResult Index()
        {
            var listaCitas = repos.citas
                .Include(cita => cita.Paciente)
                .Include(cita => cita.Medico)
             //   .Include(cita => cita.Configuracion)
                ;
            return View(listaCitas);
        }

        // Pantalla para la validación de la matrícula
        public IActionResult Validar(int id)
        {
            var cita = repos.citas
                
                //medico especialidad
                .Include(cita => cita.Paciente)
                .Include(cita => cita.Medico)
                 //  .Include(cita => cita.Configuracion)
                .Include(cita => cita.Medico)
                    .ThenInclude(especialidad => especialidad.Especialidad)

                .Single(cita => cita.CitaId == id)   // Consulta la cita id
                ;
            
            return View(cita);
        }

    }
}
