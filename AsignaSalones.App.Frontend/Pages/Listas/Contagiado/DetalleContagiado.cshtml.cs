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
    public class DetalleContagiadoModel : PageModel
    {
        private static IRepositorioContagiado _repoContagiado = new RepositorioContagiado(new Persistencia.AppContext());
        public Contagiado contagiado {get; set;}
        public IActionResult OnGet(int contagiadoid)
        {
            contagiado = _repoContagiado.GetContagiado(contagiadoid);
            if (contagiado == null)
            {
                return RedirectToPage("./Contagiados");
            }
            else
            {
                return Page();
            }
        }
    }
}
