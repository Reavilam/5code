using System.Collections.Generic;
using AsignaSalones.App.Dominio;

namespaceAsignaSalones.App.Persistencia
{
    public interface IRepositorioProfesor
    {
        //GetAllProfesores
        IEnumerable<Profesor> GetAllProfesores();
        //AddProfesor
        Profesor AddProfesor(Profesor profesor);
        //UpdateProfesor
        Profesor UpdateProfesor(Profesor profesor);
        //DeleteProfesor
        void DeleteProfesor(int idprofesor);
        //GetProfesor
        Profesor GetProfesor(int idprofesor);

    }
}