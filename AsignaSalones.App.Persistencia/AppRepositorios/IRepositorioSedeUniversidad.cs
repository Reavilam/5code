using System.Collections.Generic;
using AsignaSalones.App.Dominio;

namespace AsignaSalones.App.Persistencia
{
    public interface IRepositorioSedeUniversidad
    {
        //CRUD
        //GetAllSedesUniversidad
        IEnumerable<SedeUniversidad> GetAllSedesUniversidad();
        //AddSedeUniversidad
        SedeUniversidad AddSedeUniversidad(SedeUniversidad sedeUniversidad);
        //UpdateSedeUniversidad
        SedeUniversidad UpdateSedeUniversidad(SedeUniversidad sedeUniversidad);
        //DeleteSedeUniversidad
        void DeleteSedeUniversidad(int idSedeUniversidad);
        //GetSedeUniversidad
        SedeUniversidad GetSedeUniversidad(int idSedeUniversidad);
    }
}