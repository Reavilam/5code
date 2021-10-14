using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using AsignaSalones.App.Persistencia;
//using AsignaSalones.App.Consola;
using Microsoft.AspNetCore.Authorization;
using AsignaSalones.App.Dominio;


namespace AsignaSalones.App.Frontend.Pages
{
    public class ContagiadosModel : PageModel
    {
        private static IRepositorioContagiado _repoContagiado = new RepositorioContagiado(new Persistencia.AppContext());
        
        public IEnumerable<Contagiado> Contagiados{get;set;}
        public void OnGet()
        {
            Contagiados = _repoContagiado.GetAllContagiados();
        }
    }
}
