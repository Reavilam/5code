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
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("Esto es un mensaje por consola");
            //AddSedeUniversidad();
            //BuscarSedeUniversidad(2);
            //EliminarSedeUniversidad(3);
            //BuscarSedeUniversidad();
            ActualizarSedeUniversidad();
            Console.WriteLine("Fin del programa");
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

    }
}

