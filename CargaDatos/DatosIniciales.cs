using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo.Entidades;


namespace CargaDatos
{
    public class DatosIniciales
    {
        public enum ListasTipo
        {
            Pacientes,Especialidades,Medicos,Horarios,Dias,Calendarios,Citas
        }
        public Dictionary<ListasTipo, object> Carga()
        {
           
            #region
            //lista de pacientes
            Paciente p1 = new Paciente()
            {
                Cedula = 1812234562,
                Nombre = "Pablo Marmol",
                Email = "pm@gmail.com",
            };
         
            Paciente p2 = new Paciente()
            {
                Cedula = 1721234518,
                Nombre = "Maria Aguirre",
                Email = "mag@gmail.com",

            };
           
            Paciente p3 = new Paciente()
            {
                Cedula = 1723124686,
                Nombre = "Juan Velasco",
                Email = "juan@gmail.com",

            };
            Paciente p4 = new Paciente()
            {
                Cedula = 1272124681,
                Nombre = "Pedro Navaja",
                Email = "pn@hotmail.com",

            };
            Paciente p5 = new Paciente()
            {
                Cedula = 1723468980,
                Nombre = "Julio García",
                Email = "jg@hotmail.com",

            };
            Paciente p6 = new Paciente()
            {
                Cedula = 1723468980,
                Nombre = "Juana Falconi",
                Email = "jfal@hotmail.com",

            };
            Paciente p7 = new Paciente()
            {
                Cedula = 1551334567,
                Nombre = "Yessica Tipan",
                Email = "ygpg@hotmail.com",

            };
            Paciente p8 = new Paciente()
            {
                Cedula = 1346672120,
                Nombre = "Carolina Bustamante",
                Email = "cb@hotmail.com",

            };
            Paciente p9 = new Paciente()
            {
                Cedula = 1356785380,
                Nombre = "Juan Barrera",
                Email = "jb@hotmail.com",

            };
            Paciente p10 = new Paciente()
            {
                Cedula = 1234578212,
                Nombre = "Monica García",
                Email = "mo@hotmail.com",

            };
            List<Paciente> listaPacientes = new List<Paciente>()
            {
                p1,p2,p3,p4,p5,p6,p7,p8,p9,p10
            };
            #endregion
            // --------------------------------------------
            // Lista de Pacientes
            // --------------------------------------------
            #region
            //lista de especialidades          
            Especialidad e1 = new Especialidad()
            {
                Nombre = "General",
            };
            Especialidad e2 = new Especialidad()
            {
                Nombre = "Odontologia",
            };
            Especialidad e3 = new Especialidad()
            {
                Nombre = "Neurología",
            };
            Especialidad e4 = new Especialidad()
            {
                Nombre = "Ginecología",
            };
            Especialidad e5 = new Especialidad()
            {
                Nombre = "Obstetricia",
            };
            Especialidad e6 = new Especialidad()
            {
                Nombre = "Pediatría",
            };
            Especialidad e7 = new Especialidad()
            {
                Nombre = "Neumología",
            };
            Especialidad e8 = new Especialidad()
            {
                Nombre = "Hematología",
            };
            Especialidad e9 = new Especialidad()
            {
                Nombre = "Gastroenterología",
            };
            Especialidad e10 = new Especialidad()
            {
                Nombre = "Ginecología",
            };
            List<Especialidad> listaEspecialidades = new List<Especialidad>()
            {
                e1,e2,e3,e4,e5,e6,e7,e8,e8,e10
            };
            #endregion
            // --------------------------------------------
            // Lista de Especialidades
            // --------------------------------------------
            #region
            //lista de calendario                     

            //datos de calendario
            Calendario ca1 = new Calendario()
            {
                Nombre = "CA2021",
                Anio = 2021,
                FechaInicio = new DateTime(2021, 01, 01),
                FechaFin = new DateTime(2021, 12, 31),

            };
            Calendario ca2 = new Calendario()
            {
                Nombre = "CA2022",
                Anio = 2022,
                FechaInicio = new DateTime(2022, 01, 01),
                FechaFin = new DateTime(2022, 12, 31),
            };

            List<Calendario> listaCalendarios = new List<Calendario>()
            {
                ca1,ca2
            };
            #endregion            
            // --------------------------------------------
            // Lista de Calendarios
            // --------------------------------------------
            #region
            //lista de medicos                      
            Medico m1 = new Medico()
            {
                Cedula = 1701212216,
                Nombre = "Jesús Carrera",
                Telefono = "023123831",
                Email = "jes@gmail.com",
                Especialidad = e1,
                Calendario=ca2
            };
            //lista de medico
            Medico m2 = new Medico()
            {
                Cedula = 1722467111,
                Nombre = "Freddy Oyana",
                Telefono = "026243833",
                Email = "fsssqq@g.com",
                Especialidad = e2,
                Calendario = ca2
            };
            //lista de medico
            Medico m3 = new Medico()
            {
                Cedula = 1823567112,
                Nombre = "Manuel Garcia",
                Telefono = "0908234681",
                Email = "mani@g.com",
                Especialidad = e3,
                Calendario = ca2
            };
            Medico m4 = new Medico()
            {
                Cedula = 1621256130,
                Nombre = "Luisa Montalvo",
                Telefono = "0808233478",
                Email = "luii@g.com",
                Especialidad = e4,
                Calendario = ca2
            };
            Medico m5 = new Medico()
            {
                Cedula = 1921256173,
                Nombre = "Karla Rodriguez",
                Telefono = "0908173482",
                Email = "car@g.com",
                Especialidad = e5,
                Calendario = ca2
            };
            Medico m6 = new Medico()
            {
                Cedula = 0621256121,
                Nombre = "Fabian Betancourt",
                Telefono = "0938173247",
                Email = "mfab@g.com",
                Especialidad = e6,
                Calendario = ca2
            };
            Medico m7 = new Medico()
            {
                Cedula = 1723467791,
                Nombre = "Gustavo Maldonado",
                Telefono = "0803357890",
                Email = "gusb@g.com",
                Especialidad = e7,
                Calendario = ca2
            };
            Medico m8 = new Medico()
            {
                Cedula = 0621256121,
                Nombre = "Bertha Calahorrano",
                Telefono = "021245053",
                Email = "beb@g.com",
                Especialidad = e8,
                Calendario = ca2
            };
            Medico m9 = new Medico()
            {
                Cedula = 0983456981,
                Nombre = "Manolo Gavilanez",
                Telefono = "024457808",
                Email = "mfab@g.com",
                Especialidad = e9,
                Calendario = ca2
            };
            Medico m10 = new Medico()
            {
                Cedula = 0923457821,
                Nombre = "Mercedes Cañar",
                Telefono = "0923567890",
                Email = "mcab@g.com",
                Especialidad = e1,
                Calendario = ca2
            };
            List<Medico> listaMedicos = new List<Medico>()
            {
                m1,m2,m3,m4,m5,m6,m7,m8,m9,m10
            };
            #endregion
            // --------------------------------------------
            // Lista de Medicos
            // --------------------------------------------
            #region
            //lista de horarios                     
            //horarios del medico
            Horario h1 = new Horario()
            {
                Hora_Inicio = new TimeSpan(7, 0, 0),
                Hora_Fin = new TimeSpan(8, 0, 0),
                Cupo_Limite = 1
            };
            Horario h2 = new Horario()
            {
                Hora_Inicio = new TimeSpan(8, 0, 0),
                Hora_Fin = new TimeSpan(9, 0, 0),
                Cupo_Limite = 1
            };
            Horario h3 = new Horario()
            {
                Hora_Inicio = new TimeSpan(9, 0, 0),
                Hora_Fin = new TimeSpan(10, 0, 0),
                Cupo_Limite = 1
            };
            Horario h4 = new Horario()
            {
                Hora_Inicio = new TimeSpan(10, 0, 0),
                Hora_Fin = new TimeSpan(13, 0, 0),
                Cupo_Limite = 3
            };
            Horario h5 = new Horario()
            {
                Hora_Inicio = new TimeSpan(11, 0, 0),
                Hora_Fin = new TimeSpan(14, 0, 0),
                Cupo_Limite = 3
            };
            Horario h6 = new Horario()
            {
                Hora_Inicio = new TimeSpan(12, 0, 0),
                Hora_Fin = new TimeSpan(13, 0, 0),
                Cupo_Limite = 1
            };
            Horario h7 = new Horario()
            {
                Hora_Inicio = new TimeSpan(10, 0, 0),
                Hora_Fin = new TimeSpan(15, 0, 0),
                Cupo_Limite = 5 
            };
            Horario h8 = new Horario()
            {
                Hora_Inicio = new TimeSpan(15, 0, 0),
                Hora_Fin = new TimeSpan(17, 0, 0),
                Cupo_Limite = 2
            };
            List<Horario> listaHorarios = new List<Horario>()
            {
                h1,h2,h3,h4,h5,h6,h7,h8
            };
            #endregion
            // --------------------------------------------
            // Lista de Horarios
            // --------------------------------------------
            #region
            //lista de dias                     
            //dia x horario x medico
            Dia d1 = new Dia()
            {
                dia = "Lunes",
                Medico = m1,
                Horario = h1
            };

            Dia d2 = new Dia()
            {
                dia = "Martes",
                Medico = m2,
                Horario = h1
            };
            Dia d3 = new Dia()
            {
                dia = "Miércoles",
                Medico = m2,
                Horario = h3
            };
            Dia d4 = new Dia()
            {
                dia = "Jueves",
                Medico = m2,
                Horario = h4
            };
            Dia d5 = new Dia()
            {
                dia = "Viernes",
                Medico = m4,
                Horario = h5
            };
            Dia d6 = new Dia()
            {
                dia = "Sábado",
                Medico = m3,
                Horario = h6
            };
            Dia d7 = new Dia()
            {
                dia = "Domingo",
                Medico = m3,
                Horario = h8
            };
            Dia d8 = new Dia()
            {
                dia = "Lunes",
                Medico = m5,
                Horario = h7
            };
            Dia d9 = new Dia()
            {
                dia = "Lunes",
                Medico = m6,
                Horario = h7
            };
            Dia d10 = new Dia()
            {
                dia = "Martes",
                Medico = m10,
                Horario = h2
            };
            Dia d11 = new Dia()
            {
                dia = "Miércoles",
                Medico = m3,
                Horario = h2
            };
            Dia d12 = new Dia()
            {
                dia = "Miércoles",
                Medico = m9,
                Horario = h8
            };
            Dia d13 = new Dia()
            {
                dia = "Jueves",
                Medico = m4,
                Horario = h3
            };
            Dia d14 = new Dia()
            {
                dia = "Viernes",
                Medico = m8,
                Horario = h3
            };
            Dia d15 = new Dia()
            {
                dia = "Sabado",
                Medico = m10,
                Horario = h1
            };

            List<Dia> listaDias = new List<Dia>()
            {
                d1,d2,d3,d4,d5,d6,d7,d8,d9,d10,d11,d12,d13,d14,d15
            };
            #endregion
            // --------------------------------------------
            // Lista de Dias
            // --------------------------------------------
            #region
            //lista de Citas                     
            //paciente x medico x especialidad
            //datos de citas
            Cita c1 = new Cita()
            {
                Fecha_Cita = new DateTime(2022, 02, 04),
                Fecha_Registro = new DateTime(2022, 01, 18,15,21,0,0),
                Hora = new TimeSpan(10, 0, 0),
                Estado = 0,
                Paciente = p1,
                Medico = m1,
                Calendario=ca2
            };
            Cita c2 = new Cita()
            {
                Fecha_Cita = new DateTime(2022, 02, 05),
                Fecha_Registro = new DateTime(2022, 01, 30,11,58,0,0),
                Hora = new TimeSpan(17, 0, 0),
                Estado = 0,
                Paciente = p2,
                Medico = m2,
                Calendario = ca2
            };
            Cita c3 = new Cita()
            {
                Fecha_Cita = new DateTime(2022, 02, 06),
                Fecha_Registro = new DateTime(2022, 01, 30,10,20,0,0),
                Hora = new TimeSpan(7, 0,0),
                Estado = 0,
                Paciente = p3,
                Medico = m3,
                Calendario = ca2
            };
            Cita c4 = new Cita()
            {
                Fecha_Cita = new DateTime(2022, 02, 21),
                Fecha_Registro = new DateTime(2022, 01, 30, 12, 22, 0, 0),
                Hora = new TimeSpan(11, 0, 0),
                Estado = 0,
                Paciente = p4,
                Medico = m3,
                Calendario = ca2
            };
            Cita c5 = new Cita()
            {
                Fecha_Cita = new DateTime(2022, 02, 12),
                Fecha_Registro = new DateTime(2022, 01, 30, 12, 22, 0, 0),
                Hora = new TimeSpan(16, 0, 0),
                Estado = 0,
                Paciente = p5,
                Medico = m3,
                Calendario = ca2
            };
            Cita c6 = new Cita()
            {
                Fecha_Cita = new DateTime(2022, 02, 08),
                Fecha_Registro = new DateTime(2022, 01, 30, 12, 22, 0, 0),
                Hora = new TimeSpan(9, 0, 0),
                Estado = 0,
                Paciente = p6,
                Medico = m3,
                Calendario = ca2
            };
            Cita c7 = new Cita()
            {
                Fecha_Cita = new DateTime(2022, 02, 08),
                Fecha_Registro = new DateTime(2022, 01, 30, 12, 22, 0, 0),
                Hora = new TimeSpan(8, 0, 0),
                Estado = 0,
                Paciente = p7,
                Medico = m4,
                Calendario = ca2
            };
            Cita c8 = new Cita()
            {
                Fecha_Cita = new DateTime(2022, 02, 28),
                Fecha_Registro = new DateTime(2022, 02, 02, 12, 9, 0, 0),
                Hora = new TimeSpan(8, 0, 0),
                Estado = 0,
                Paciente = p8,
                Medico = m7,
                Calendario = ca2
            };
            Cita c9 = new Cita()
            {
                Fecha_Cita = new DateTime(2022, 03, 11),
                Fecha_Registro = new DateTime(2022, 02, 12, 12, 9, 0, 0),
                Hora = new TimeSpan(13, 0, 0),
                Estado = 0,
                Paciente = p8,
                Medico = m7,
                Calendario = ca2
            };
            Cita c10 = new Cita()
            {
                Fecha_Cita = new DateTime(2022, 03, 11),
                Fecha_Registro = new DateTime(2022, 02, 12, 12, 9, 0, 0),
                Hora = new TimeSpan(13, 0, 0),
                Estado = 0,
                Paciente = p8,
                Medico = m10,
                Calendario = ca2
            };
            List<Cita> listaCitas = new List<Cita>()
            {
                c1,c2,c3,c4,c5,c6,c7,c8,c9,c10
            };

            #endregion
            // --------------------------------------------
            // Lista de Citas
            // --------------------------------------------
            
            
            // --------------------------------------------
            // Diccionario contiene todas las listas
            // --------------------------------------------
            Dictionary<ListasTipo, object> dicListasDatos = new Dictionary<ListasTipo, object>()
            {
                { ListasTipo.Pacientes, listaPacientes },
                { ListasTipo.Especialidades, listaEspecialidades },
                { ListasTipo.Medicos, listaMedicos },
                { ListasTipo.Horarios, listaHorarios },
                { ListasTipo.Dias, listaDias },
                { ListasTipo.Calendarios, listaCalendarios },
                { ListasTipo.Citas, listaCitas }
            };

            return dicListasDatos;
        }
    }
}
