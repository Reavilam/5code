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
        private static IRepositorioEstudiante _repoEstudiante = new RepositorioEstudiante(new Persistencia.AppContext());
        private static IRepositorioSalon _repoSalon = new RepositorioSalon(new Persistencia.AppContext());
        private static IRepositorioProfesor _repoProfesor = new RepositorioProfesor(new Persistencia.AppContext());
        private static IRepositorioContagiado  _repoContagiado = new RepositorioContagiado(new Persistencia.AppContext());

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("Esto es por consola");
            //------------------------------------------------------------------------
            //CRUD PARTE Alberto: sede universidad
            //AddSedeUniversidad();
            //BuscarSedeUniversidad(2);
            //EliminarSedeUniversidad(3);
            //BuscarSedeUniversidad();
            //ActualizarSedeUniversidad();
            //Console.WriteLine("Fin del programa parte Alberto");
            //------------------------------------------------------------------------
            //CRUD PARTE WILTON: HorarioClase, PersonalAseo y Matricula

            //AddHorarioClase();
            //BuscarHorarioClase(5);
            //ActualizarHorarioClase();
            //EliminarHorarioClase(6);
            //BuscarHorariosClases();

            //AddPersonalAseo();
            //BuscarPersonalAseo(3);
            //ActualizarPersonalAseo();
            //EliminarPersonalAseo(4);
            //BuscarPersonasAseo();

            //AddMatricula();
            //AddMatricula(_repoEstudiante.GetEstudiante(2), _repoHorarioClase.GetHorarioClase(1), _repoHorarioClase.GetHorarioClase(2), _repoHorarioClase.GetHorarioClase(3));
            //ActualizarMatricula();
            //BuscarMatricula(1);
            //BuscarMatriculas();

            //AddEstudiante();
            //var estudianteEncontrado = BuscarEstudiante(1);

            //AddProfesor();
            //BuscarProfesor(5);
            //------------------------------------------------------------------------
            //CRUD PARTE Sebastian: Contagiado

            //AddContagiado();
            //BuscarContagiado(1);
            //DeleteContagiado();
            //UpdateProfesor();            

            //Console.WriteLine("Fin del programa parte Sebastian");



            //------------------------------------------------------------------------

        }

            //AddContagiado();

        private static void AddContagiado()
        {
            var personai = new Persona
            {
                nombre = "Julian",
                apellidos = "Navarrete Molina",
                identificacion = "231245346",
                edad = 25,
                estadoCovid = "Positivo"

            };
            var contagiado = new Contagiado
            {
                persona = personai,
                fechaContagio =new DateTime(2021,05,25),
                sintomas = "muy enfermo",
                periodoAislamiento = new DateTime (2021,06,10)
            };
            _repoContagiado.AddContagiado(contagiado);
        }

            //GetContagiado();
        private static void BuscarContagiado(int idContagiado)
        {
            var contagiado = _repoContagiado.GetContagiado(idContagiado);
            Console.WriteLine(contagiado.persona+"");
        }

            //DeleteContagiado();
            //UpdateProfesor(); 






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
            var profesor = _repoProfesor.GetProfesor(6);
            DateTime horario = Convert.ToDateTime("2021-01-01 12:00");
            var horarioClase = new HorarioClase            
            {
                nombre = profesor.materia,
                //profesor = ,
                profesor = profesor,
                cantPersonas = 4,
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
            var profesor = _repoProfesor.GetProfesor(6);
            DateTime horario = Convert.ToDateTime("2021-01-01 18:00");
            var horarioClase = new HorarioClase            
            {
                id = 5,
                nombre = profesor.materia,
                //profesor = _repoProfesor.GetProfesor(2),
                profesor = profesor,
                cantPersonas = 12,
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
        private static void AddMatricula(Estudiante estudiante, HorarioClase horarioClase1, HorarioClase horarioClase2, HorarioClase horarioClase3)
        {
            //HorarioClase horarioClase1 = _repoHorarioClase.GetHorarioClase(1);
            Console.WriteLine(horarioClase1.id + horarioClase1.nombre);
            var matricula = new Matricula
            {
                estudiante = estudiante, //_repoEstudiante.GetEstudiante(1),
                clase_1 = horarioClase1,
                clase_2 = horarioClase2, //_repoHorarioClase.GetHorarioClase(2),
                clase_3 = horarioClase3, //_repoHorarioClase.GetHorarioClase(3),
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
                estudiante = _repoEstudiante.GetEstudiante(1),
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

        //##############################################################################
        //OPERACIONES CRUD PARA ESTUDIANTE
        //----------------
        //AddEstudiante
        private static void AddEstudiante()
        {
            var estudiante = new Estudiante            
            {
                nombre = "Anne",
                apellidos = "Frank",
                identificacion = "8764234",
                edad = 23,
                estadoCovid = "positivo",
                carrera = "Ingenieria Quimica",
                semestre = 5
            };

            Console.WriteLine(estudiante.nombre + " " + estudiante.apellidos);
            if (_repoEstudiante.AddEstudiante(estudiante) != null)
                Console.WriteLine("Registro de estudiante adicionado");
        }

        //GetEstudiante
        private static Estudiante BuscarEstudiante(int idEstudiante)
        {
            try
            {
                var estudiante = _repoEstudiante.GetEstudiante(idEstudiante);
                //Console.WriteLine( "{0} {1}", estudiante.nombre, estudiante.apellidos);
                return estudiante;
            }
            catch (System.Exception e)
            {
                Console.WriteLine("Error@BuscarEstudiante:\n" + e.Message);
                return null;
            }
        }
        //############################################################################

        //##############################################################################
        //OPERACIONES CRUD PARA SALON
        //----------------
        //AddSalon

        private static void AddSalon()
        {
            var salon = new Salon
            {
               aforo = 8
               
            };

            _repoSalon.AddSalon(salon);
        }
        //GetSalon
        private static void BuscarSalon(int idSalon)
        {
            var salon = _repoSalon.GetSalon(idSalon);
            Console.WriteLine("Aforo:  "+salon.aforo);
        }
        //DeleteSalon

        private static void EliminarSalon(int idSalon)
        {
            _repoSalon.DeleteSalon(idSalon);
        }
        //UpdateSalon
        private static void ActualizarSalon()
        {
            var salon = new Salon 
            {
               aforo = 4
            };
            Salon salon_retornado =_repoSalon.UpdateSalon(salon);                         
            if (salon_retornado!=null)
                Console.WriteLine("Se registró un salon en la base de datos");
        
        }
        //GetAllSalones
        private static void BuscarSalones()
        {
            IEnumerable<Salon> salones = _repoSalon.GetAllSalones();
            
            foreach (var salon in salones)
            {
                Console.WriteLine(salon.aforo);
                //Console.WriteLine(salon.nombre);
            }
            //Console.WriteLine(salones.First().nombre);
        }

        //############################################################################

        //##############################################################################
        //OPERACIONES CRUD PARA Profesor
        //----------------
        //AddProfesor
        private static void AddProfesor()
        {
            var profesor = new Profesor            
            {
                nombre = "Mark",
                apellidos = "Milan",
                identificacion = "1012345",
                edad = 33,
                estadoCovid = "negativo",
                materia = "Bases de Datos",
                departamento = "Ciencias Computacionales"
            };

            Console.WriteLine(profesor.nombre + " " + profesor.apellidos);
            if (_repoProfesor.AddProfesor(profesor) != null)
                Console.WriteLine("Registro de profesor adicionado");
        }

        //GetProfesor
        private static void BuscarProfesor(int idProfesor)
        {
            try
            {
                var profesor = _repoProfesor.GetProfesor(idProfesor);
                Console.WriteLine( "{0} {1}", profesor.nombre, profesor.apellidos);
            }
            catch (System.Exception e)
            {
                Console.WriteLine("Error@BuscarProfesor:\n" + e.Message);
            }
        }
        //############################################################################
    }
}
