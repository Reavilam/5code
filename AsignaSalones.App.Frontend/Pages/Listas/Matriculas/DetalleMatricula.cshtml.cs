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
    public class DetalleMatriculaModel : PageModel
    {
        private static IRepositorioMatricula _repoMatricula = new RepositorioMatricula(new Persistencia.AppContext());
        public Matricula matricula {get;set;}
        public IActionResult OnGet(int matriculaId)
        {
            matricula = _repoMatricula.GetMatriculaConEstudianteYClase(matriculaId);
            if (matricula ==  null)
            {
                return RedirectToPage("./Matriculas");
            }else
            {
                return Page();
            }            
        }
    }
}
