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
    public class DetalleHorarioClaseModel : PageModel
    {
        private static IRepositorioHorarioClase _repoHorarioClase = new RepositorioHorarioClase(new Persistencia.AppContext());
        public HorarioClase horarioClase {get; set;}
        public IActionResult OnGet(int horarioClaseId)
        {
            horarioClase = _repoHorarioClase.GetHorarioClase(horarioClaseId);
            if (horarioClase == null)
            {
                return RedirectToPage("./HorariosClases");
            }
            else
            {
                return Page();
            }
        }
    }
}
