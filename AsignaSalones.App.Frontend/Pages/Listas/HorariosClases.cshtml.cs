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
    public class HorariosClasesModel : PageModel
    {
        private static IRepositorioHorarioClase  _repoHorarioClase = new RepositorioHorarioClase(new Persistencia.AppContext());
        public IEnumerable<HorarioClase> HorariosClases {get; set;}
        public void OnGet()
        {
            HorariosClases = _repoHorarioClase.GetAllHorariosClases();
        }
    }
}
