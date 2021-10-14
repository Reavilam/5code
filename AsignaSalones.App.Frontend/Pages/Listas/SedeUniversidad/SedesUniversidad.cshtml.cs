using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using AsignaSalones.App.Persistencia;
using Microsoft.AspNetCore.Authorization;
using AsignaSalones.App.Dominio;

namespace AsignaSalones.App.Frontend.Pages
{
    public class SedesUniversidadModel : PageModel
    {
        private static IRepositorioSedeUniversidad _repoSedeUniversidad = new RepositorioSedeUniversidad(new Persistencia.AppContext());
        
        public IEnumerable<SedeUniversidad> SedesUniversidad{get;set;}
        public void OnGet()
        {
            SedesUniversidad = _repoSedeUniversidad.GetAllSedesUniversidad();
        }
    }
}
