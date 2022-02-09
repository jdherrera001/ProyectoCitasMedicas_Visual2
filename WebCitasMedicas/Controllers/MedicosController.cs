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
    public class MedicosController : Controller
    {
        private readonly Repositorio repos;
        public MedicosController(Repositorio repos)
        {
            this.repos = repos;
        }
        public IActionResult Index()
        {
            IEnumerable<Medico> listaMedicos = 
                repos.medicos
                .Include(medico => medico.Especialidad);

            return View(listaMedicos);
        }
        //creacion de un nuevo medico
        //enviar a un formulario vacio
        [HttpGet]
        public IActionResult Create()
        {
            // Lista de especialidades
            var listaEspecialidades = repos.especialidades
                .Select(especialidad => new
                {
                    EspecialidadId = especialidad.EspecialidadId,
                    Nombre = especialidad.Nombre
                }).ToList();

            // Prepara las listas
            var selectListaEspecialidades = new SelectList(listaEspecialidades, "EspecialidadId", "Nombre");
            ViewBag.selectListaEspecialidades = selectListaEspecialidades;


            return View();
        }
        //guarda un medico
        [HttpPost]
        public IActionResult Create(Medico medico)
        {
            repos.medicos.Add(medico);
            repos.SaveChanges();

            TempData["mensaje"] = $"El Medico {medico.Nombre} ha sido creado exitosamente";

            return RedirectToAction("Index");

        }
        //Edicion de Medicos
        [HttpGet]
        public IActionResult Edit(int id)
        {
            Medico medico = repos.medicos.Find(id);

            // Lista de especialidades
            var listaEspecialidades = repos.especialidades
                .Select(especialidad => new
                {
                    EspecialidadId = especialidad.EspecialidadId,
                    Nombre = especialidad.Nombre
                }).ToList();

            // Prepara las listas
            var selectListaEspecialidades = new SelectList(listaEspecialidades, "EspecialidadId", "Nombre");
            ViewBag.selectListaEspecialidades = selectListaEspecialidades;

            return View(medico);
        }
        // Actualizacion de Medicos
        [HttpPost]
        public IActionResult Edit(Medico medico)
        {
            repos.medicos.Update(medico);
            repos.SaveChanges();
            TempData["mensaje"] = $"El Medico {medico.Nombre} ha sido modificado exitosamente";
            return RedirectToAction("Index");
        }
        //Borrado de Medicos
        [HttpGet]
        public IActionResult Delete(int id)
        {
            Medico medico = repos.medicos.Find(id);
            // Lista de especialidades
            var listaEspecialidades = repos.especialidades
                .Select(especialidad => new
                {
                    EspecialidadId = especialidad.EspecialidadId,
                    Nombre = especialidad.Nombre
                }).ToList();

            // Prepara las listas
            var selectListaEspecialidades = new SelectList(listaEspecialidades, "EspecialidadId", "Nombre");
            ViewBag.selectListaEspecialidades = selectListaEspecialidades;

            return View(medico);
        }
        // Eliminar un Medico
        [HttpPost]
        public IActionResult Delete(Medico medico)
        {
            repos.medicos.Remove(medico);
            repos.SaveChanges();
            TempData["mensaje"] = $"El Medico {medico.Nombre} ha sido eliminado exitosamente";
            return RedirectToAction("Index");
        }

    }
}
