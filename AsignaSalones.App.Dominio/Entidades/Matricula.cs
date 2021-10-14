using System;
using System.Collections.Generic;
namespace AsignaSalones.App.Dominio
{
    public class Matricula
    {
        public int id { get; set; }
        public Estudiante estudiante { get; set; }
        public HorarioClase clase_1 { get; set; }
        public HorarioClase clase_2 { get; set; }
        public HorarioClase clase_3 { get; set; }
        public HorarioClase clase_4 { get; set; }
    }
}