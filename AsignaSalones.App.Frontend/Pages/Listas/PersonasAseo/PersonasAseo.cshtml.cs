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
    public class PersonasAseoModel : PageModel
    {
        private static IRepositorioPersonalAseo _repoPersonalAseo = new RepositorioPersonalAseo(new Persistencia.AppContext());
        public IEnumerable<PersonalAseo> PersonasAseo {get;set;}
        public void OnGet()
        {
            PersonasAseo = _repoPersonalAseo.GetAllPersonasAseo();
        }
    }
}
