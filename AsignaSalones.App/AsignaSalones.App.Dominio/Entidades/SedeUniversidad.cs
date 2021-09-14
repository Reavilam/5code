using System;

namespace AsignaSalones.App.Dominio
{
    public class SedeUniversidad
    {
        public int id {get;set;}
        public string nombre  {get;set;}
        public System.Collections.Generic.List<Salon> Salones {get;set;}
        public int numeroSalonesDisp {get;set;}
        
        
    }
}