using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace AsignaSalones.App.Dominio
{
    public class HorarioClase
    {
        public int id { get; set; }
        public String nombre { get; set; }
        public Profesor profesor { get; set; }
        public int cantPersonas { get; set; }
        public Salon salonAsignado { get; set; }
        [DisplayFormat(DataFormatString = "{0:hh:mm}", ApplyFormatInEditMode = true)]
        //[DisplayFormat(DataFormatString = "{0:hh-mm}")]
        public DateTime hora { get; set; }
    }
}