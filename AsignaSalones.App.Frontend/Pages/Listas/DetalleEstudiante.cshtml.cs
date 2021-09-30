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
    public class DetalleEstudianteModel : PageModel
    {
        private static IRepositorioEstudiante _repoEstudiante = new RepositorioEstudiante(new Persistencia.AppContext());
        public Estudiante estudiante {get; set;}
        public IActionResult OnGet(int estudianteId)
        {
            Console.WriteLine("entra a detalleestudiante" + estudianteId);
            estudiante = _repoEstudiante.GetEstudiante(estudianteId);
            if (estudiante == null)
            {
                return RedirectToPage("./Estudiantes");
            }
            else
            {
                return Page();
            }
        }
    }
}
