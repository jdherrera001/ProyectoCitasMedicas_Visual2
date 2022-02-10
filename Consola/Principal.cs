using Microsoft.EntityFrameworkCore;
using Modelo.Entidades;
using ModeloBD;
using System;
using System.Collections.Generic;
using System.Linq;
using Procesos;

namespace Consola
{
    class Principal
    {
        static void Main(string[] args)
        {
            Grabar grabar = new Grabar();
            grabar.DatosIni();

            using (var repos = RepositorioDBBuilder.Crear())
            {
                /*var listaPacientes = repos.pacientes
                    ;

                Console.WriteLine("\nListado de Pacientes:\n");
                foreach (var paciente in listaPacientes)
                {
                    Console.WriteLine(
                        "Cedula:" +
                        paciente.Cedula + ", " +
                        "Nombre:" +
                        paciente.Nombre + ", " +
                        "Correo electronico:" +
                        paciente.Email + ", "
                    );
                }
                var listaEspecialidades = repos.especialidades
                        ;

                Console.WriteLine("\nListado de Especialidades:\n");
                foreach (var especialidad in listaEspecialidades)
                {
                    Console.WriteLine(
                        "Nombre:" +
                        especialidad.Nombre + " "
                    );
                }
                var listaMedicos = repos.medicos
                    .Include(medico => medico.Especialidad)
                       ;
                Console.WriteLine("\nListado de Médicos:\n");
                foreach (var medico in listaMedicos)
                {
                    Console.WriteLine(
                        "Cedula:" +
                        medico.Cedula + ", " +
                        "Nombre:" +
                        medico.Nombre + ", " +
                        "Teléfono:" +
                        medico.Telefono + ", " +
                        "Correo electronico:" +
                        medico.Email + " "+ " Especialidad: " +
                        medico.Especialidad.Nombre
                    );
                }
                var listaHorarios = repos.horarios
                    ;
                Console.WriteLine("\nListado de Horarios Médicos:\n");
                foreach (var horario in listaHorarios)
                {
                    Console.WriteLine(
                        "Hora Inicio:" +
                        horario.Hora_Inicio + ", " +
                        "Hora Fin:" +
                        horario.Hora_Fin + ", " +
                        "Cupos Disponibles:" +
                        horario.Cupos_Totales + ", "
                    );
                }
                var listaDias = repos.dias
                  .Include(medico => medico.Medico)
                  .Include(horario => horario.Horario)
                     ;
                Console.WriteLine("\nListado de Días:\n");
                foreach (var dia in listaDias)
                {
                    Console.WriteLine(
                        "HorarioId:" +
                        dia.Horario + ", " +
                        "MedicoId:" +
                        dia.MedicoId + ", " +
                        "Dia:" +
                        dia.dia + ", "                        
                    );
                }
                var listaCitas = repos.citas
                 .Include(medico => medico.Medico)
                 .Include(paciente => paciente.Paciente)
                    ;
                Console.WriteLine("\nListado de Citas:\n");
                foreach (var cita in listaCitas)
                {
                    Console.WriteLine(
                        "Fecha de Cita:" +
                        cita.Fecha_Cita + ", " +
                        "Fecha de Registro:" +
                        cita.Fecha_Registro + ", " +
                        "Hora de Cita:" +
                        cita.Hora + ", " +
                        "Paciente:" +
                        cita.PacienteId + ", "+                                                
                        "Medico:" +
                        cita.MedicoId + ", " 
                    );
                }*/
               
            //    var tmpDia = repos.dias
            //        .Where(dia =>
            //        dia.dia == "Lunes"                   
            //        );
            //    var tmpHora = repos.horarios
            //        .Where(hora_i =>
            //        hora_i.Hora_Inicio == new TimeSpan(7, 0, 0)
            //        );
            //    var tmpMedico = repos.medicos
            //       .Single(medico => medico.Nombre == "Jesús Carrera");

            //    ProHorarios proaprobaciones = new ProHorarios(repos);
                
            //    foreach (var mat in tmpDia)
            //    {
            //        var resultado = proaprobaciones.Aprobo(tmpMedico, mat);
            //        Console.WriteLine("El medico: " + tmpMedico.Nombre +
            //            (resultado ? " SI TIENE CITA " : " NO TIENE CITA ") +
            //            "el dia que trabaja es: " + mat.dia
            //            +
            //            " id med: " + mat.MedicoId
            //            );
            //    }
            }
        }

    }
}