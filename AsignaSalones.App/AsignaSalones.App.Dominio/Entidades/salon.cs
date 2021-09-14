using System;

namespace AsignaSalones.App.Dominio
{
    public class Salon
    {
        public int id {get;set;}
        public System.Collections.Generic.List<Persona> personas {get;set;}
        public int aforo {get;set;}
        
    }
}