using Microsoft.AspNetCore.Mvc;
using Modelo.Entidades;
using ModeloBD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebCitasMedicas.Controllers
{
    public class HorariosController : Controller
    {
        private readonly Repositorio repos;
        public HorariosController(Repositorio repos)
        {
            this.repos = repos;
        }
        public IActionResult Index()
        {
            
            IEnumerable<Horario> listaHorario = repos.horarios;

            return View(listaHorario);
        }
        //creacion de un nuevo horario
        //enviar a un formulario vacio
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Horario horario)
        {
            repos.horarios.Add(horario);
            repos.SaveChanges();

            TempData["mensaje"] = $"El horario {horario.HorarioId} ha sido creado exitosamente";

            return RedirectToAction("Index");

        }
        //Edicion de horarios
        [HttpGet]
        public IActionResult Edit(int id)
        {
            Horario horario = repos.horarios.Find(id);
            return View(horario);
        }
        // Actualizacion de horario
        [HttpPost]
        public IActionResult Edit(Horario horario)
        {
            repos.horarios.Update(horario);
            repos.SaveChanges();
            TempData["mensaje"] = $"El horario {horario.HorarioId} ha sido modificado exitosamente";
            return RedirectToAction("Index");
        }
        //Borrado de horarios
        [HttpGet]
        public IActionResult Delete(int id)
        {
            Horario horario = repos.horarios.Find(id);
            return View(horario);
        }
        // Eliminar un Horario
        [HttpPost]
        public IActionResult Delete(Horario horario)
        {
            repos.horarios.Remove(horario);
            repos.SaveChanges();
            TempData["mensaje"] = $"El horario {horario.HorarioId} ha sido eliminado exitosamente";
            return RedirectToAction("Index");
        }
    }
}
