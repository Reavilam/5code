using AsignaSalones.App.Dominio;
using System.Collections.Generic;
using System.Linq;

namespace AsignaSalones.App.Persistencia
{
    public class RepositorioProfesor : IRepositorioProfesor
    {
        private readonly AppContext _appContext;
        public RepositorioProfesor(AppContext appContext)
        {
            _appContext = appContext;
        }

        Profesor IRepositorioProfesor.AddProfesor(Profesor profesor)
        {
            var profesorAdicionado = _appContext.profesores.Add(profesor) ;
            _appContext.SaveChanges();
            return profesorAdicionado.Entity ;
        }

        Profesor IRepositorioProfesor.UpdateProfesor(Profesor profesor)
        {
            var profesorEncontrado = _appContext.profesores.FirstOrDefault(p => p.id == profesor.id);
            if (profesorEncontrado != null)
            {
                profesorEncontrado.nombre = profesor.nombre;
                profesorEncontrado.apellidos = profesor.apellidos;
                profesorEncontrado.identificacion = profesor.identificacion;
                profesorEncontrado.telefono = profesor.telefono;
                profesorEncontrado.correo = profesor.correo;
                _appContext.SaveChanges();
            }
            return profesorEncontrado; 
        }

        void IRepositorioProfesor.DeleteProfesor(int idprofesor)
        {
            var profesorEncontrado = _appContext.profesores.FirstOrDefault(p => p.id == idprofesor);
            if (profesorEncontrado == null)
                return;
            _appContext.profesores.Remove(profesorEncontrado);
            _appContext.SaveChanges();
        }

        Profesor IRepositorioProfesor.GetProfesor(int idprofesor)
        {
            var profesorEncontrado = _appContext.profesores.FirstOrDefault(p => p.id == idprofesor);
            return profesorEncontrado;
        }

        IEnumerable<Profesor> IRepositorioProfesor.GetAllProfesores()
        {
            return _appContext.profesores;
        }
    }
}