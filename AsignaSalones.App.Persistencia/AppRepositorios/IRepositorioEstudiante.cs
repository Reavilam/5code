using System.Collections.Generic;
using AsignaSalones.App.Dominio;

namespace AsignaSalones.App.Persistencia
{
    public interface IRepositorioEstudiante
    {
        //GetAllEstudiantes
        IEnumerable<Estudiante> GetAllEstudiantes();
        //AddEstudiante
        Estudiante AddEstudiante(Estudiante Estudiante);
        //UpdateEstudiante
        Estudiante UpdateEstudiante(Estudiante Estudiante);
        //DeleteEstudiante
        void DeleteEstudiante(int idEstudiante);
        //GetEstudiante
        Estudiante GetEstudiante(int idEstudiante);

    }
}