using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Modelo.Entidades;
using ModeloBD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebCitasMedicas.Controllers
{
    public class CitasController : Controller
    {
        private readonly Repositorio repos;
        public CitasController(Repositorio repos)
        {
            this.repos = repos;
        }
        public IActionResult Index()
        {
            IEnumerable<Cita> listaCitas =
                repos.citas
                .Include(paciente => paciente.Paciente)
                .Include(medico => medico.Medico)
                    .ThenInclude(dia => dia.Dias)
                        .ThenInclude(horario => horario.Horario)
                        ;

            return View(listaCitas);
            
        }
        //creacion de un nueva cita
        //enviar a un formulario vacio
        [HttpGet]
        public IActionResult Create()
        {
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

            return View();
        }
        //guarda un medico
        [HttpPost]
        public IActionResult Create(Cita cita)
        {
            repos.citas.Add(cita);
            repos.SaveChanges();

            TempData["mensaje"] = $"La cita {cita.CitaId} ha sido creado exitosamente";

            return RedirectToAction("Index");

        }
        //Edicion de Citas
        [HttpGet]
        public IActionResult Edit(int id)
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
        public IActionResult Edit(Cita cita)
        {
            repos.citas.Update(cita);
            repos.SaveChanges();
            TempData["mensaje"] = $"La cita {cita.CitaId} ha sido modificada exitosamente";
            return RedirectToAction("Index");
        }
        //Borrado de Citas
        [HttpGet]
        public IActionResult Delete(int id)
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


            return View(cita);
        }
        // Eliminar una Cita
        [HttpPost]
        public IActionResult Delete(Cita cita)
        {
            repos.citas.Remove(cita);
            repos.SaveChanges();
            TempData["mensaje"] = $"La cita {cita.CitaId} ha sido eliminada exitosamente";
            return RedirectToAction("Index");
        }
    }
}
