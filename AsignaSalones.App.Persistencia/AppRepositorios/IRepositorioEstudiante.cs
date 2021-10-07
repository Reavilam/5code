using System.Collections.Generic;
using AsignaSalones.App.Dominio;

namespace AsignaSalones.App.Persistencia
{
    public interface IRepositorioEstudiante
    {
        //GetAllEstudiantes
        IEnumerable<Estudiante> GetAllEstudiantes();
        //AddEstudiante
        Estudiante AddEstudiante(Estudiante estudiante);
        //UpdateEstudiante
        Estudiante UpdateEstudiante(Estudiante estudiante);
        //DeleteEstudiante
        void DeleteEstudiante(int idEstudiante);
        //GetEstudiante
        Estudiante GetEstudiante(int idEstudiante);
    }
}