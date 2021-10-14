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
    public class MatriculasModel : PageModel
    {
        private static IRepositorioMatricula _repoMatricula = new RepositorioMatricula(new Persistencia.AppContext());
        public IEnumerable<Matricula> Matriculas {get;set;}
        public void OnGet()
        {
            Matriculas = _repoMatricula.GetAllMatriculasConEstudianteYClase();
        }
    }
}
