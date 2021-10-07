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
    public class EliminarHorarioClaseModel : PageModel
    {
        private static IRepositorioHorarioClase _repoHorarioClase = new RepositorioHorarioClase(new Persistencia.AppContext());
        [BindProperty]
        public HorarioClase horarioClase {get; set;}
        public IActionResult OnGet(int horarioClaseId)
        {
            horarioClase = _repoHorarioClase.GetHorarioClase(horarioClaseId);
            return Page();
        }

        public IActionResult OnPost()
        {
            _repoHorarioClase.DeleteHorarioClase(horarioClase.id);
            return RedirectToPage("./HorariosClases");
        }
    }
}
