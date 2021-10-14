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
    public class EditarPersonalAseoModel : PageModel
    {
        private static IRepositorioPersonalAseo _repoPersonalAseo = new RepositorioPersonalAseo(new Persistencia.AppContext());
        [BindProperty]
        public PersonalAseo personalAseo {get;set;}
        public IActionResult OnGet(int? personalAseoId)
        {
            if (personalAseoId.HasValue)
            {
                personalAseo = _repoPersonalAseo.GetPersonalAseo(personalAseoId.Value);
            }else
            {
                personalAseo = new PersonalAseo();
            }

            if (personalAseo == null)
            {
                return RedirectToPage("./PersonasAseo");
            }else
            {
                return Page();
            }
        }

        public IActionResult OnPost()
        {
            if(!ModelState.IsValid)//If for form fields validation
            {
                return Page();
            }else
            {
                if(personalAseo.id > 0)
                {
                    personalAseo = _repoPersonalAseo.UpdatePersonalAseo(personalAseo);
                }else
                {
                    _repoPersonalAseo.AddPersonalAseo(personalAseo);
                }
                return RedirectToPage("./PersonasAseo");
            }
        }
    }
}
