using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using AsignaSalones.App.Dominio;
using AsignaSalones.App.Persistencia;

namespace AsignaSalones.App.Frontend.Pages
{
    public class DetallePersonalAseoModel : PageModel
    {
        private static IRepositorioPersonalAseo _repoPersonalAseo = new RepositorioPersonalAseo(new Persistencia.AppContext());
        public PersonalAseo personalAseo {set;get;}
        public IActionResult OnGet(int personalAseoId)
        {
            personalAseo = _repoPersonalAseo.GetPersonalAseo(personalAseoId);
            if (personalAseo == null)
            {
                return RedirectToPage("./PersonasAseo");
            }else
            {
                return Page();
            }
        }
    }
}
