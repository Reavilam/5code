using System.Collections.Generic;
using AsignaSalones.App.Dominio;

namespace AsignaSalones.App.Persistencia
{
    public interface IRepositorioHorarioClase
    {
        //GetAllHorariosClases
        IEnumerable<HorarioClase> GetAllHorariosClases();
        //AddHorarioClase
        HorarioClase AddHorarioClase(HorarioClase horarioClase);
        //UpdateHorarioClase
        HorarioClase UpdateHorarioClase(HorarioClase horarioClase);
        //DeleteHorarioClase
        void DeleteHorarioClase(int idHorarioClase);
        //GetHorarioClase
        HorarioClase GetHorarioClase(int idHorarioClase);
    }
}