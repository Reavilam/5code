using System.Collections.Generic;
using AsignaSalones.App.Dominio;

namespace AsignaSalones.App.Persistencia
{
    public interface IRepositorioPersonalAseo
    {
         //GetAllPersonasAseo
        IEnumerable<PersonalAseo> GetAllPersonasAseo();
        //AddPersonalAseo
        PersonalAseo AddPersonalAseo(PersonalAseo personalAseo);
        //UpdatePersonalAseo
        PersonalAseo UpdatePersonalAseo(PersonalAseo personalAseo);
        //DeletePersonalAseo
        void DeletePersonalAseo(int idPersonalAseo);
        //GetPersonalAseo
        PersonalAseo GetPersonalAseo(int idPersonalAseo);
    }
}