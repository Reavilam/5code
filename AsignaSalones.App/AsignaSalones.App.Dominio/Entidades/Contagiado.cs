using System;

namespace AsignaSalones.App.Dominio
{
    public class Contagiado
    {
        public int id {get;set;}
        public Persona Persona {get;set;}
        public dateTime FechaContagio {get;set;}
        public Sintomas Sintomas {get;set;}
        public dateTime PeriodoAislamiento {get;set;}
        
    }
}
