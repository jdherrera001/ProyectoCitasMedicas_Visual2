using CargaDatos;
using Modelo.Entidades;
using ModeloBD;
using System.Collections.Generic;
using static CargaDatos.DatosIniciales;

namespace Consola
{
    public class Grabar
    {
        public void DatosIni()
        {
            DatosIniciales datos = new DatosIniciales();
            var listas = datos.Carga();

            // Extraer del diccionario las listas            
            var listaPacientes = (List<Paciente>)listas[ListasTipo.Pacientes];
            var listaEspecialidades = (List<Especialidad>)listas[ListasTipo.Especialidades];
            var listaMedicos = (List<Medico>)listas[ListasTipo.Medicos];
            var listaHorarios = (List<Horario>)listas[ListasTipo.Horarios];
            var listaDias = (List<Dia>)listas[ListasTipo.Dias];
            var listaCalendarios = (List<Calendario>)listas[ListasTipo.Calendarios];
            var listaCitas = (List<Cita>)listas[ListasTipo.Citas];
            

            using (Repositorio repos = RepositorioDBBuilder.Crear())
            {
                // Se asegura que se borre y vuelva a crear la base de datos
                repos.PreparaDB();
                // Agrega los listados                
                repos.pacientes.AddRange(listaPacientes);
                repos.especialidades.AddRange(listaEspecialidades);
                repos.medicos.AddRange(listaMedicos);
                repos.horarios.AddRange(listaHorarios);
                repos.dias.AddRange(listaDias);
                repos.calendarios.AddRange(listaCalendarios);
                repos.citas.AddRange(listaCitas);
                // Guarda todos los datos
                repos.SaveChanges();
            }
        }
    }
}
