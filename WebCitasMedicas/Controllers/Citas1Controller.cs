using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Modelo.Entidades;
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

        //Pantalla para la validación de la matrícula
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
        //Edicion de Citas
        [HttpGet]
        public IActionResult Validar2(int id)
        {
            Cita cita = repos.citas.Find(id);

            // Lista de pacientes
            var listaPacientes = repos.pacientes
                .Select(paciente => new
                {
                    PacienteId = paciente.PacienteId,
                    Nombre = paciente.Nombre
                }).ToList();
            // Prepara las listas
            var selectListaPacientes = new SelectList(listaPacientes, "PacienteId", "Nombre");
            ViewBag.selectListaPacientes = selectListaPacientes;

            // Lista de medicos
            var listaMedicos = repos.medicos
                .Select(medico => new
                {
                    MedicoId = medico.MedicoId,
                    Nombre = medico.Nombre
                }).ToList();

            // Prepara las listas
            var selectListaMedicos = new SelectList(listaMedicos, "MedicoId", "Nombre");
            ViewBag.selectListaMedicos = selectListaMedicos;

            // Lista de horarios
            var listaHorarios = repos.horarios
                .Select(horario => new
                {
                    HorarioId = horario.HorarioId,
                    Hora_Inicio = horario.Hora_Inicio
                }).ToList();
            // Prepara las listas
            var selectListaHorarios = new SelectList(listaHorarios, "HorarioId", "Hora_Inicio");
            ViewBag.selectListaHorarios = selectListaHorarios;


            return View(cita);
        }
        // Actualizacion de Citas
        [HttpPost]
        public IActionResult Validar2(Cita cita)
        {
            repos.citas.Update(cita);
            repos.SaveChanges();
            TempData["mensaje"] = $"La cita {cita.CitaId} ha sido asignada exitosamente";
            return RedirectToAction("Index");
        }
    }
}
