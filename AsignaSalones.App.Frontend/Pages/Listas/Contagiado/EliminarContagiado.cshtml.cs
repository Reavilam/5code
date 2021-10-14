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
    public class EliminarContagiadoModel : PageModel
    {
        private static IRepositorioContagiado _repoContagiado = new RepositorioContagiado(new Persistencia.AppContext());
        [BindProperty]
        public Contagiado contagiado {get; set;}
        public IActionResult OnGet(int contagiadoid)
        {
            contagiado = _repoContagiado.GetContagiado(contagiadoid);
            return Page();
        }

        public IActionResult OnPost()
        {
            _repoContagiado.DeleteContagiado(contagiado.id);
            return RedirectToPage("./Contagiados");
        }
    }
}
