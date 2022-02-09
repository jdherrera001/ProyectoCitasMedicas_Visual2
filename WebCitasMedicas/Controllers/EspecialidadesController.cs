using Microsoft.AspNetCore.Mvc;
using Modelo.Entidades;
using ModeloBD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebCitasMedicas.Controllers
{
    public class EspecialidadesController : Controller
    {
        private readonly Repositorio repos;
        public EspecialidadesController(Repositorio repos)
        {
            this.repos = repos;
        }
        public IActionResult Index()
        {
            
            IEnumerable<Especialidad> listaEspecialidades = repos.especialidades;

            return View(listaEspecialidades);
        }
        //creacion de un nuevo especialidad
        //enviar a un formulario vacio
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Especialidad especialidad)
        {
            repos.especialidades.Add(especialidad);
            repos.SaveChanges();

            TempData["mensaje"] = $"La especialidad {especialidad.Nombre} ha sido creado exitosamente";

            return RedirectToAction("Index");

        }
        //Edicion de especialidades
        [HttpGet]
        public IActionResult Edit(int id)
        {
            Especialidad especialidad = repos.especialidades.Find(id);
            return View(especialidad);
        }
        // Actualizacion de especialidades
        [HttpPost]
        public IActionResult Edit(Especialidad especialidad)
        {
            repos.especialidades.Update(especialidad);
            repos.SaveChanges();
            TempData["mensaje"] = $"La especialidad {especialidad.Nombre} ha sido modificado exitosamente";
            return RedirectToAction("Index");
        }
        //Borrado de especialidades
        [HttpGet]
        public IActionResult Delete(int id)
        {
            Especialidad especialidad = repos.especialidades.Find(id);
            return View(especialidad);
        }
        // Eliminar una Especialidad
        [HttpPost]
        public IActionResult Delete(Especialidad especialidad)
        {
            repos.especialidades.Remove(especialidad);
            repos.SaveChanges();
            TempData["mensaje"] = $"La especialidad {especialidad.Nombre} ha sido eliminado exitosamente";
            return RedirectToAction("Index");
        }

    }
}
