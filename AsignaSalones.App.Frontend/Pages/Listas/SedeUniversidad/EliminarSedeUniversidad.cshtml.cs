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
    public class EliminarSedeUniversidadModel : PageModel
    {
        private static IRepositorioSedeUniversidad _repoSedeUniversidad = new RepositorioSedeUniversidad(new Persistencia.AppContext());
        [BindProperty]
        public SedeUniversidad sedeUniversidad {get; set;}
        public IActionResult OnGet(int sedeUniversidadid)
        {
            sedeUniversidad = _repoSedeUniversidad.GetSedeUniversidad(sedeUniversidadid);
            return Page();
        }

        public IActionResult OnPost()
        {
            _repoSedeUniversidad.DeleteSedeUniversidad(sedeUniversidad.id);
            return RedirectToPage("./SedesUniversidad");
        }
    }
}
