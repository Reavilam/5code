using AsignaSalones.App.Dominio;
using System.Collections.Generic;
using System.Linq;

namespace AsignaSalones.App.Persistencia
{
    public class RepositorioHorarioClase : IRepositorioHorarioClase
    {
        private readonly AppContext _appContext;
        public RepositorioHorarioClase(AppContext appContext)
        {
            _appContext = appContext;
        }

        HorarioClase IRepositorioHorarioClase.AddHorarioClase(HorarioClase horarioClase)
        {
            var horarioClaseAdicionado = _appContext.HorariosClases.Add(horarioClase) ;
            _appContext.SaveChanges();
            return horarioClaseAdicionado.Entity ;
        }

        HorarioClase IRepositorioHorarioClase.UpdateHorarioClase(HorarioClase horarioClase)
        {
            var horarioClaseEncontrado = _appContext.HorariosClases.FirstOrDefault(h => h.id == horarioClase.id);
            if (horarioClaseEncontrado != null)
            {
                horarioClaseEncontrado.nombre = horarioClase.nombre;
                horarioClaseEncontrado.profesor = horarioClase.profesor;
                horarioClaseEncontrado.cantPersonas = horarioClase.cantPersonas;
                horarioClaseEncontrado.salonAsignado = horarioClase.salonAsignado;
                horarioClaseEncontrado.hora = horarioClase.hora;
                _appContext.SaveChanges();
            }
            return horarioClaseEncontrado;
        }

        void IRepositorioHorarioClase.DeleteHorarioClase(int idHorarioClase)
        {
            var horarioClaseEncontrado = _appContext.HorariosClases.FirstOrDefault(h => h.id == idHorarioClase);
            if (horarioClaseEncontrado == null)
                return;
            _appContext.HorariosClases.Remove(horarioClaseEncontrado);
            _appContext.SaveChanges();
        }

        HorarioClase IRepositorioHorarioClase.GetHorarioClase(int idHorarioClase)
        {
            var horarioClaseEncontrado = _appContext.HorariosClases.FirstOrDefault(h => h.id == idHorarioClase);
            return horarioClaseEncontrado;
        }

         IEnumerable<HorarioClase> IRepositorioHorarioClase.GetAllHorariosClases()
        {
            return _appContext.HorariosClases;
        }
    }
}