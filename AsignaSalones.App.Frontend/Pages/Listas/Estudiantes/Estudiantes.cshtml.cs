using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using AsignaSalones.App.Persistencia;
using AsignaSalones.App.Dominio;

namespace AsignaSalones.App.Frontend.Pages
{
    public class EstudiantesModel : PageModel
    {
        private static IRepositorioEstudiante _repoEstudiante = new RepositorioEstudiante(new Persistencia.AppContext());
        public IEnumerable<Estudiante> Estudiantes { get; set;}
        public string FiltroNombre{get;set;}
        public void OnGet(string filtroNombre)
        {
            Console.WriteLine(filtroNombre);
            if (String.IsNullOrEmpty(filtroNombre))
            {
                Estudiantes = _repoEstudiante.GetAllEstudiantes();
            }else
            {
                FiltroNombre = filtroNombre;
                Estudiantes = _repoEstudiante.GetEstudiantesPorFiltroNombre(FiltroNombre);
            }            
        }
    }
}
