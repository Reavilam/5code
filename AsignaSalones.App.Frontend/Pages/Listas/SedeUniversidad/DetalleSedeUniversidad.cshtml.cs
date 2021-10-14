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
    public class DetalleSedeUniversidadModel : PageModel
    {
        private static IRepositorioSedeUniversidad _repoSedeUniversidad = new RepositorioSedeUniversidad(new Persistencia.AppContext());
        public SedeUniversidad sedeUniversidad {get; set;}
        public IActionResult OnGet(int sedeUniversidadid)
        {
            sedeUniversidad = _repoSedeUniversidad.GetSedeUniversidad(sedeUniversidadid);
            if (sedeUniversidad == null)
            {
                return RedirectToPage("./SedesUniversidad");
            }
            else
            {
                return Page();
            }
        }
    }

}
