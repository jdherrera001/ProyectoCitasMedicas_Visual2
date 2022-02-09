using Microsoft.AspNetCore.Mvc;
using Modelo.Entidades;
using ModeloBD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebCitasMedicas.Controllers
{
    public class PacientesController : Controller
    {
        private readonly Repositorio repos;
        public PacientesController(Repositorio repos)
        {
            this.repos = repos;
        }
        //recupera la lista de paciente y envia a la vista
        public IActionResult Index()
        {
            
            IEnumerable<Paciente> listaPaciente = repos.pacientes;

            return View(listaPaciente);
        }
        //creacion de un nuevo paciente
        //enviar a un formulario vacio
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Paciente paciente)
        {
            repos.pacientes.Add(paciente);
            repos.SaveChanges();

            TempData["mensaje"] = $"El paciente {paciente.Nombre} ha sido creado exitosamente";

            return RedirectToAction("Index");
            
        }
        //Edicion de Pacientes
        [HttpGet]
        public IActionResult Edit(int id)
        {
            Paciente paciente = repos.pacientes.Find(id);
            return View(paciente);
        }
        // Actualizacion de Pacientes
        [HttpPost]
        public IActionResult Edit(Paciente paciente)
        {
            repos.pacientes.Update(paciente);
            repos.SaveChanges();
            TempData["mensaje"] = $"El paciente {paciente.Nombre} ha sido actualizado exitosamente";
            return RedirectToAction("Index");
        }
        //Borrado de Pacientes
        [HttpGet]
        public IActionResult Delete(int id)
        {
            Paciente paciente = repos.pacientes.Find(id);
            return View(paciente);
        }
        // Eliminar un Pacientes
        [HttpPost]
        public IActionResult Delete(Paciente paciente)
        {
            repos.pacientes.Remove(paciente);
            repos.SaveChanges();
            TempData["mensaje"] = $"El paciente {paciente.Nombre} ha sido eliminado exitosamente";
            return RedirectToAction("Index");
        }

    }
}
