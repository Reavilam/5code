using System;

namespace AsignaSalones.App.Dominio
{
    public class Contagiado: Persona

    {
/*         public int id {get;set;}
        public String nombre { get; set; }
        public String apellidos { get; set; } */
        public DateTime fechaContagio {get;set;}
       
        public Sintomas sintomas {get;set;}
        
        public DateTime periodoAislamiento {get;set;}
        
    }
}
