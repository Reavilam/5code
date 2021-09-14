using System;

namespace AsignaSalones.App.Dominio
{
    public class Contagiado
    {
        public int id {get;set;}
        public Persona persona {get;set;}
        public dateTime fechaContagio {get;set;}
        public Sintomas sintomas {get;set;}
        public dateTime periodoAislamiento {get;set;}
        
    }
}