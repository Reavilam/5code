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
    public class EditarSedeUniversidadModel : PageModel
    {
        private static IRepositorioSedeUniversidad _repoSedeUniversidad = new RepositorioSedeUniversidad(new Persistencia.AppContext());
        [BindProperty]
        public SedeUniversidad sedeUniversidad {get; set;}
        public IActionResult OnGet(int? contagiadoid)
        {
            if(contagiadoid.HasValue)
            {
                sedeUniversidad = _repoSedeUniversidad.GetSedeUniversidad(contagiadoid.Value);
            }else
            {
                sedeUniversidad = new SedeUniversidad();
            }

            if (sedeUniversidad == null)
            {
                return RedirectToPage("./SedesUniversidad");
            }else
            {
                return Page();
            }
        }

        public IActionResult OnPost()
        {
            if(!ModelState.IsValid)
            {
                return Page();
            }else
            {
                if(sedeUniversidad.id > 0)
                {
                    sedeUniversidad = _repoSedeUniversidad.UpdateSedeUniversidad(sedeUniversidad);
                }else
                {
                    _repoSedeUniversidad.AddSedeUniversidad(sedeUniversidad);
                }
                return RedirectToPage("./SedesUniversidad");
            }
        }
    }
}
