using AsignaSalones.App.Dominio;
using System.Collections.Generic;
using System.Linq;

namespace AsignaSalones.App.Persistencia

{
    public class RepositorioSalon : IRepositorioSalon
    {
        private static AppContext _appContext;

        public RepositorioSalon(AppContext appContext)
        {
            _appContext = appContext;
        }

        Salon IRepositorioSalon.AddSalon(Salon salon)
        {
            //var profesorAdicionado = _appContext.Salones.AddProfesor(salon);
            var salonAdicionado = _appContext.Salones.Add(salon);
            _appContext.SaveChanges();
            //return profesorAdicionado;
            return salonAdicionado.Entity;
        }

        Salon IRepositorioSalon.UpdateSalon(Salon salon)
        {
            //var salonEncontrado = _appContext.Salones.FirstOrDefault(p => p.id = salon.id);
            var salonEncontrado = _appContext.Salones.FirstOrDefault(p => p.id == salon.id);
            if (salonEncontrado != null)
            {
                salonEncontrado.aforo = salon.aforo;
                _appContext.SaveChanges();
            }
            return salonEncontrado;
        }

        void IRepositorioSalon.DeleteSalon (int idSalon)
        {
            //var salonEncontrado = _appContext.Salones.FirstOrDefault(p => p.id = idSalon);
            var salonEncontrado = _appContext.Salones.FirstOrDefault(p => p.id == idSalon);
            if (salonEncontrado == null)
                return;
            _appContext.Salones.Remove(salonEncontrado);
            _appContext.SaveChanges();
        }

        Salon IRepositorioSalon.GetSalon(int idSalon)
        {
            //var salonEncontrado= _appContext.Salones.FirstOrDefault(p => p.id = idSalon);
            var salonEncontrado= _appContext.Salones.FirstOrDefault(p => p.id == idSalon);
            return salonEncontrado;
        }

        IEnumerable<Salon> IRepositorioSalon.GetAllSalones()
        {
            return _appContext.Salones;
        }
    }
}