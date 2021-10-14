using System.Collections.Generic;
using AsignaSalones.App.Dominio;

namespace AsignaSalones.App.Persistencia
{
    public interface IRepositorioSalon
    {
        //CRUD
        //GetAllalones
        IEnumerable<Salon> GetAllSalones();
        //AddSalon
        Salon AddSalon(Salon salon);
        //UpdateSalon
        Salon UpdateSalon(Salon salon);
        //DeleteSalon
        void DeleteSalon(int idSalon);
        //GetSalon
        Salon GetSalon(int idSalon);
    }
}