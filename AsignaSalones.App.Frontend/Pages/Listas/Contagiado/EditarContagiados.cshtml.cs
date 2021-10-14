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
    public class EditarContagiadoModel : PageModel
    {
        private static IRepositorioContagiado _repoContagiado = new RepositorioContagiado(new Persistencia.AppContext());
        [BindProperty]
        public Contagiado contagiado {get; set;}
        public IActionResult OnGet(int? contagiadoid)
        {
            if(contagiadoid.HasValue)
            {
                contagiado = _repoContagiado.GetContagiado(contagiadoid.Value);
            }else
            {
                contagiado = new Contagiado();
            }

            if (contagiado == null)
            {
                return RedirectToPage("./Contagiados");
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
                if(contagiado.id > 0)
                {
                    contagiado = _repoContagiado.UpdateContagiado(contagiado);
                }else
                {
                    _repoContagiado.AddContagiado(contagiado);
                }
                return RedirectToPage("./Contagiados");
            }
        }
    }
}
