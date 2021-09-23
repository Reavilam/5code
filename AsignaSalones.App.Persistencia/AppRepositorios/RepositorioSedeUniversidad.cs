using AsignaSalones.App.Dominio;
using System.Collections.Generic;
using System.Linq;

namespace AsignaSalones.App.Persistencia

{
    public class RepositorioSedeUniversidad : IRepositorioSedeUniversidad
    {
        private readonly AppContext _appContext;

        public RepositorioSedeUniversidad(AppContext appContext)
        {
            _appContext = appContext;
        }

        SedeUniversidad IRepositorioSedeUniversidad.AddSedeUniversidad(SedeUniversidad sedeUniversidad)
        {
            //var sedeUniversidadAdicionado = _appContext.SedeUniversidad.AddSedeUniversidad(sedeUniversidad);
            var sedeUniversidadAdicionado = _appContext.SedesUniversidad.Add(sedeUniversidad);
            _appContext.SaveChanges();
            //return sedeUniversidadAdicionado;
            return sedeUniversidadAdicionado.Entity;
        }

        SedeUniversidad IRepositorioSedeUniversidad.UpdateSedeUniversidad(SedeUniversidad sedeUniversidad)
        {
            //var sedeUniversidadEncontrado = _appContext.SedeUniversidad.FirstOrDefault(p => p.id = sedeUniversidad.id);
            var sedeUniversidadEncontrado = _appContext.SedesUniversidad.FirstOrDefault(p => p.id == sedeUniversidad.id);
            if (sedeUniversidadEncontrado != null)
            {
                sedeUniversidadEncontrado.nombre = sedeUniversidad.nombre;
                sedeUniversidadEncontrado.materias = sedeUniversidad.materias;
                sedeUniversidadEncontrado.numeroSalonesDispHora = sedeUniversidad.numeroSalonesDispHora;

                _appContext.SaveChanges();
            }
            return sedeUniversidadEncontrado;
        }

        void IRepositorioSedeUniversidad.DeleteSedeUniversidad (int idSedeUniversidad)
        {
            //var sedeUniversidadEncontrado = _appContext.SedeUniversidad.FirstOrDefault(p => p.id = idSedeUniversidad);
            var sedeUniversidadEncontrado = _appContext.SedesUniversidad.FirstOrDefault(p => p.id == idSedeUniversidad);
            if (sedeUniversidadEncontrado == null)
                return;
            _appContext.SedesUniversidad.Remove(sedeUniversidadEncontrado);
            _appContext.SaveChanges();
        }

        SedeUniversidad IRepositorioSedeUniversidad.GetSedeUniversidad(int idSedeUniversidad)
        {
            //var sedeUniversidadEncontrado= _appContext.SedeUniversidad.FirstOrDefault(p => p.id = idSedeUniversidad);
            var sedeUniversidadEncontrado= _appContext.SedesUniversidad.FirstOrDefault(p => p.id == idSedeUniversidad);
            return sedeUniversidadEncontrado;
        }

        IEnumerable<SedeUniversidad> IRepositorioSedeUniversidad.GetAllSedesUniversidad()
        {
            return _appContext.SedesUniversidad;
        }
    }
}