using AsignaSalones.App.Dominio;
using System.Collections.Generic;
using System.Linq;

namespace AsignaSalones.App.Persistencia
{
    public class RepositorioPersonalAseo : IRepositorioPersonalAseo
    {
        private static AppContext _appContext;
        public RepositorioPersonalAseo(AppContext appContext)
        {
            _appContext = appContext;
        }

        PersonalAseo IRepositorioPersonalAseo.AddPersonalAseo(PersonalAseo personalAseo)
        {
            var personalAseoAdicionado = _appContext.PersonasAseo.Add(personalAseo) ;
            _appContext.SaveChanges();
            return personalAseoAdicionado.Entity ;
        }

        PersonalAseo IRepositorioPersonalAseo.UpdatePersonalAseo(PersonalAseo personalAseo)
        {
            var personalAseoEncontrado = _appContext.PersonasAseo.FirstOrDefault(p => p.id == personalAseo.id);
            if (personalAseoEncontrado != null)
            {
                personalAseoEncontrado.nombre = personalAseo.nombre;
                personalAseoEncontrado.apellidos = personalAseo.apellidos;
                personalAseoEncontrado.identificacion = personalAseo.identificacion;
                personalAseoEncontrado.edad = personalAseo.edad;
                personalAseoEncontrado.estadoCovid = personalAseo.estadoCovid;
                personalAseoEncontrado.turno = personalAseo.turno;
                _appContext.SaveChanges();
            }
            return personalAseoEncontrado;
        }

        void IRepositorioPersonalAseo.DeletePersonalAseo(int idPersonalAseo)
        {
            var personalAseoEncontrado = _appContext.PersonasAseo.FirstOrDefault(p => p.id == idPersonalAseo);
            if (personalAseoEncontrado == null)
                return;
            _appContext.PersonasAseo.Remove(personalAseoEncontrado);
            _appContext.SaveChanges();
        }

        PersonalAseo IRepositorioPersonalAseo.GetPersonalAseo(int idPersonalAseo)
        {
            var personalAseoEncontrado = _appContext.PersonasAseo.FirstOrDefault(p => p.id == idPersonalAseo);
            return personalAseoEncontrado;
        }

         IEnumerable<PersonalAseo> IRepositorioPersonalAseo.GetAllPersonasAseo()
        {
            return _appContext.PersonasAseo;
        }
    }
}