using AsignaSalones.App.Dominio;
using System.Collections.Generic;
using System.Linq;
using System;

namespace AsignaSalones.App.Persistencia
{
    public class RepositorioEstudiante : IRepositorioEstudiante
    {
        private static AppContext _appContext;
        public RepositorioEstudiante(AppContext appContext)
        {
            _appContext = appContext;
        }

        Estudiante IRepositorioEstudiante.AddEstudiante(Estudiante estudiante)
        {
            var estudianteAdicionado = _appContext.Estudiantes.Add(estudiante) ;
            _appContext.SaveChanges();
            return estudianteAdicionado.Entity ;
        }

        Estudiante IRepositorioEstudiante.UpdateEstudiante(Estudiante estudiante)
        {
            var estudianteEncontrado = _appContext.Estudiantes.FirstOrDefault(e => e.id == estudiante.id);
            if (estudianteEncontrado != null)
            {
                estudianteEncontrado.nombre = estudiante.nombre;
                estudianteEncontrado.apellidos = estudiante.apellidos;
                estudianteEncontrado.identificacion = estudiante.identificacion;
                estudianteEncontrado.edad = estudiante.edad;
                estudianteEncontrado.estadoCovid = estudiante.estadoCovid;
                estudianteEncontrado.carrera = estudiante.carrera;
                estudianteEncontrado.semestre = estudiante.semestre;
                _appContext.SaveChanges();
            }
            return estudianteEncontrado;
        }

        void IRepositorioEstudiante.DeleteEstudiante(int idEstudiante)
        {
            var estudianteEncontrado = _appContext.Estudiantes.FirstOrDefault(e => e.id == idEstudiante);
            if (estudianteEncontrado == null)
                return;
            _appContext.Estudiantes.Remove(estudianteEncontrado);
            _appContext.SaveChanges();
        }

        Estudiante IRepositorioEstudiante.GetEstudiante(int idEstudiante)
        {
            var estudianteEncontrado = _appContext.Estudiantes.FirstOrDefault(e => e.id == idEstudiante);
            return estudianteEncontrado;
        }

        IEnumerable<Estudiante> IRepositorioEstudiante.GetAllEstudiantes()
        {
            return _appContext.Estudiantes;
        }

        IEnumerable<Estudiante> IRepositorioEstudiante.GetEstudiantesPorFiltroNombre(string filtro=null)
        {
            var estudiantes = new List<Estudiante>();
            //if (estudiantes != null)
            //{
                if (!String.IsNullOrEmpty(filtro))
                {
                    estudiantes = _appContext.Estudiantes.Where(e => e.nombre.Contains(filtro)).ToList();
                }
            //}
            return estudiantes;
        }
    }
}