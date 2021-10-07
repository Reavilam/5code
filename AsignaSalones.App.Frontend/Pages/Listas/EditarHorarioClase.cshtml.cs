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
    public class EditarHorarioClaseModel : PageModel
    {
        private static IRepositorioHorarioClase _repoHorarioClase = new RepositorioHorarioClase(new Persistencia.AppContext());
        [BindProperty]
        public HorarioClase horarioClase {get; set;}
        public IActionResult OnGet(int? horarioClaseId)
        {
            if(horarioClaseId.HasValue)
            {
                horarioClase = _repoHorarioClase.GetHorarioClase(horarioClaseId.Value);
            }else
            {
                horarioClase = new HorarioClase();
            }

            if (horarioClase == null)
            {
                return RedirectToPage("./HorariosClases");
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
                if(horarioClase.id > 0)
                {
                    horarioClase = _repoHorarioClase.UpdateHorarioClase(horarioClase);
                }else
                {
                    _repoHorarioClase.AddHorarioClase(horarioClase);
                }
                return RedirectToPage("./HorariosClases");
            }
        }
    }
}
