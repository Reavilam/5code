using System;

namespace AsignaSalones.App.dominio  {

    // Entidad persona
    public class Persona{
        public string nombre{get;set;}   
        public string apellido{get;set;}
        public string identificacion{get;set;}
        public int edad{get;set;}
        public bool estadoCovid{get;set;}
        public int id{get;set;}


        //Roles 
        public class _Estudiante{
            public string carrera{get ;set;}
            public int semestre{get;set;}
        }
        public class _Profesor{
            public string departamento{get;set;}
            public string materia{get;set;}
        }
        public class _Directivo{
            public string dependencia{get;set;}
        }
        public class _personalAseo{
            public int turno{get;set;}
        }

    }
