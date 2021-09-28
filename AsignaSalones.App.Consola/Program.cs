using System;
using AsignaSalones.App.Dominio;
using AsignaSalones.App.Persistencia;
using System.Collections.Generic;
using System.Linq;

namespace AsignaSalones.App.Consola
{
    class Program
    {
        private static IRepositorioSedeUniversidad _repoSedeUniversidad = new RepositorioSedeUniversidad(new Persistencia.AppContext());
        private static IRepositorioHorarioClase _repoHorarioClase = new RepositorioHorarioClase(new Persistencia.AppContext());
        private static IRepositorioPersonalAseo _repoPersonalAseo = new RepositorioPersonalAseo(new Persistencia.AppContext());
        private static IRepositorioMatricula _repoMatricula = new RepositorioMatricula(new Persistencia.AppContext());
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("Esto es un mensaje por consola");
            //AddSedeUniversidad();
            //BuscarSedeUniversidad(2);
            //EliminarSedeUniversidad(3);
            //BuscarSedeUniversidad();
            //ActualizarSedeUniversidad();
            Console.WriteLine("Fin del programa parte Alberto");
            //------------------------------------------------------------------------
            //CRUD PARTE WILTON: HorarioClase, PersonalAseo y Matricula

            //AddHorarioClase();
            //BuscarHorarioClase(5);
            //ActualizarHorarioClase();
            //EliminarHorarioClase(6);
            BuscarHorariosClases();

            //AddPersonalAseo();
            //BuscarPersonalAseo(3);
            //ActualizarPersonalAseo();
            //EliminarPersonalAseo(4);
            //BuscarPersonasAseo();

            AddMatricula();
            //BuscarMatricula(1);
            //BuscarMatriculas();
            //------------------------------------------------------------------------

        }


        //AddSedeUniversidad

        private static void AddSedeUniversidad()
        {
            var sedeUniversidad = new SedeUniversidad 
            {
               nombre = "Sede cali",
               numeroSalonesDispHora = 5
               
            };

            _repoSedeUniversidad.AddSedeUniversidad(sedeUniversidad);
        }
        //GetSedeUniversidad
        private static void BuscarSedeUniversidad(int idSedeUniversidad)
        {
            var sedeUniversidad = _repoSedeUniversidad.GetSedeUniversidad(idSedeUniversidad);
            Console.WriteLine("Nombre:  "+sedeUniversidad.nombre+"\nSalones:  "+sedeUniversidad.numeroSalonesDispHora);
        }
        //DeleteSedeuniversidad

        private static void EliminarSedeUniversidad(int idSedeUniversidad)
        {
            _repoSedeUniversidad.DeleteSedeUniversidad(idSedeUniversidad);
        }
        //UpdateSedeUniversidad
        private static void ActualizarSedeUniversidad()
        {
            var sedeUniversidad = new SedeUniversidad 
            {
               nombre = "Sede cali",
               numeroSalonesDispHora = 28
            };
            SedeUniversidad sedeUniversidad_retornado =_repoSedeUniversidad.UpdateSedeUniversidad(sedeUniversidad);                         
            if (sedeUniversidad_retornado!=null)
                Console.WriteLine("Se registró un sedeUniversidad en la base de datos");
        
        }
        //GetAllSedesUniversidad
        private static void BuscarSedeUniversidad()
        {
            IEnumerable<SedeUniversidad> sedesUniversidad = _repoSedeUniversidad.GetAllSedesUniversidad();
            
            foreach (var sedeUniversidad in sedesUniversidad)
            {
                Console.WriteLine(sedeUniversidad.nombre);
            }
            //Console.WriteLine(sedesUniversidad.First().nombre);
        }
        //---------------------------------------------------------------------------------
        //#################################################################################    
        //OPERACIONES CRUD PARA HorarioClase
        ////AddHorarioClase (Create)
        private static void AddHorarioClase()
        {
            DateTime horario = Convert.ToDateTime("2021-01-01 09:00");
            var horarioClase = new HorarioClase            
            {
                nombre = "Calculo 1",
                //profesor = _repoProfesor.GetProfesor(2),
                profesor = null,
                cantPersonas = 5,
                salonAsignado = null,
                hora = horario
            };

            Console.WriteLine(horarioClase.nombre + " " + horarioClase.hora.ToString("t"));
            if (_repoHorarioClase.AddHorarioClase(horarioClase) != null)
                Console.WriteLine("Registro de horario de clase creado");
        }
        //GetHorarioClase (Read)
        private static void BuscarHorarioClase(int idHorarioClase)
        {
            try
            {
                 var horarioClase = _repoHorarioClase.GetHorarioClase(idHorarioClase);
                 Console.WriteLine(horarioClase.nombre + " " + horarioClase.hora.ToString("t"));
            }
            catch (System.Exception e)
            {
                Console.WriteLine("Error@BuscarHorarioClase: " + e.Message);
            }
        }
        //UpdateHorarioClase (Update)
        private static void ActualizarHorarioClase()
        {
            DateTime horario = Convert.ToDateTime("2021-01-01 09:00");
            var horarioClase = new HorarioClase            
            {
                id = 1,
                nombre = "Calculo 1",
                //profesor = _repoProfesor.GetProfesor(2),
                profesor = null,
                cantPersonas = 15,
                salonAsignado = null,
                hora = horario
            };

            Console.WriteLine(horarioClase.nombre + " " + horarioClase.hora.ToString("t"));
            if (_repoHorarioClase.UpdateHorarioClase(horarioClase) != null)
                Console.WriteLine("Registro de horario de clase actualizado");
        }
        //DeleteHorarioClase (Delete)
        private static void EliminarHorarioClase(int idHorarioClase)
        {
            try
            {
                 _repoHorarioClase.DeleteHorarioClase(idHorarioClase);
            }
            catch (System.Exception e)
            {
                Console.WriteLine("Error@EliminarHorarioClase: " + e.Message);
            }
        }
        //GetAllHorariosClases
        private static void BuscarHorariosClases()
        {
            try
            {
                IEnumerable<HorarioClase> horariosClases = _repoHorarioClase.GetAllHorariosClases();
                foreach (var horarioClase in horariosClases)
                {
                    Console.WriteLine(horarioClase.id + " " + horarioClase.nombre + " " + horarioClase.hora.ToString("t"));//.ToString("t") imprime solo la hora del DateTime
                }
            }
            catch (System.Exception e)
            {
                Console.WriteLine("Error@BuscarHorariosClases:"+e.Message);
            }
        }
        //##############################################################################
        //OPERACIONES CRUD PARA PersonalAseo
        //AddPersonalAseo (Create)
        private static void AddPersonalAseo()
        {
            var personalAseo = new PersonalAseo
            {
                nombre = "Lina",
                apellidos = "Perez",
                identificacion = "1234009",
                edad = 46,
                estadoCovid = "negativo",
                turno = 2
            };
            if (_repoPersonalAseo.AddPersonalAseo(personalAseo) != null)
                Console.WriteLine("Registro de personal de aseo creado");
        }

        //GetPersonalAseo (Read)
        private static void BuscarPersonalAseo(int idPersonalAseo)
        {
            try
            {
                 var personalAseo = _repoPersonalAseo.GetPersonalAseo(idPersonalAseo);
                 Console.WriteLine(personalAseo.nombre + ", turno: " + personalAseo.turno); 
            }
            catch (System.Exception e)
            {
                Console.WriteLine("Error@BuscarPersonalAseo:\n " + e.Message);
            }
        }

        //UpdatePersonalAseo (Update)
        private static void ActualizarPersonalAseo()
        {
            var personalAseo = new PersonalAseo
            {
                id = 1,
                nombre = "Albeiro",
                apellidos = "Leon",
                identificacion = "9000001",
                edad = 41,
                estadoCovid = "negativo",
                turno = 2 
            };
            if (_repoPersonalAseo.UpdatePersonalAseo(personalAseo) != null)
                Console.WriteLine("Registro de personal de aseo actualizado");
        }

        //DeletePersonalAseo (Delete)
        private static void EliminarPersonalAseo(int idPersonalAseo)
        {
            try
            {
                 _repoPersonalAseo.DeletePersonalAseo(idPersonalAseo);
            }
            catch (System.Exception e)
            {
                Console.WriteLine("Error@EliminarPersonalAseo: " + e.Message);
            }
        }

        //GetAllPersonalAseo
        private static void BuscarPersonasAseo()
        {
            try
            {
                IEnumerable<PersonalAseo> personasAseo = _repoPersonalAseo.GetAllPersonasAseo();
                foreach (var personalAseo in personasAseo)
                {
                    Console.WriteLine(personalAseo.id + " " + personalAseo.nombre + "- turno " + personalAseo.turno);
                }
            }
            catch (System.Exception e)
            {
                Console.WriteLine("Error@BuscarPersonalAseo:"+e.Message);
            }
        }
        //##############################################################################
        //OPERACIONES CRUD PARA Matricula
        //AddMatricula (Create)
        private static void AddMatricula()
        {
            HorarioClase horarioClase1 = _repoHorarioClase.GetHorarioClase(1);
            Console.WriteLine(horarioClase1.id + horarioClase1.nombre);
            var matricula = new Matricula
            {
                estudiante = null, //_repoEstudiante.GetEstudiante(1),
                clase_1 = horarioClase1,
                clase_2 = null, //_repoHorarioClase.GetHorarioClase(2),
                clase_3 = null, //_repoHorarioClase.GetHorarioClase(3),
                clase_4 = null //_repoHorarioClase.GetHorarioClase(4)
            };
            if (_repoMatricula.AddMatricula(matricula) != null)
                Console.WriteLine("Registro matricula creado");
        }

        //GetMatricula (Read)
        private static void BuscarMatricula(int idMatricula)
        {
            try
            {
                 var matricula = _repoMatricula.GetMatricula(idMatricula);
                 Console.WriteLine("Matricula no. " + matricula.id + "de " + matricula.estudiante.nombre + " " + matricula.estudiante.apellidos);
            }
            catch (System.Exception e)
            {
                Console.WriteLine("Error@BuscarMatricula:\n " + e.Message);
            }
        }

        //UpdateMatricula (Update)
        private static void ActualizarMatricula()
        {
            var matricula = new Matricula
            {
                id = 1,
                estudiante = null, //_repoEstudiante.GetEstudiante(1),
                clase_1 = _repoHorarioClase.GetHorarioClase(1),
                clase_2 = _repoHorarioClase.GetHorarioClase(3),
                clase_3 = null, //_repoHorarioClase.GetHorarioClase(3),
                clase_4 = null //_repoHorarioClase.GetHorarioClase(4)
            };
            if (_repoMatricula.UpdateMatricula(matricula) != null)
                Console.WriteLine("Registro de matricula actualizado");            
        }

        //DeleteMatricula (Delete)
        private static void EliminarMatricula(int idMatricula)
        {
            try
            {
                 _repoMatricula.DeleteMatricula(idMatricula);
            }
            catch (System.Exception e)
            {
                Console.WriteLine("Error@EliminarMatricula: " + e.Message);
            }
        }

        //GetAllMatriculas
        private static void BuscarMatriculas()
        {
            try
            {
                IEnumerable<Matricula> matriculas = _repoMatricula.GetAllMatriculas();
                foreach (var matricula in matriculas)
                {
                    Console.WriteLine("Matricula no. " + matricula.id + "de " + matricula.estudiante.nombre + " " + matricula.estudiante.apellidos);
                }
            }
            catch (System.Exception e)
            {
                Console.WriteLine("Error@BuscarMatriculas:\n"+e.Message);
            }
        }
        //############################################################################
    }
}
