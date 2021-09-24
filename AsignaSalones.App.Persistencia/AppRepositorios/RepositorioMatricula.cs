using AsignaSalones.App.Dominio;
using System.Collections.Generic;
using System.Linq;

namespace AsignaSalones.App.Persistencia.AppRepositorios
{
    public class RepositorioMatricula : IRepositorioMatricula
    {
        private readonly AppContext _appContext;
        public RepositorioMatricula(AppContext appContext)
        {
            _appContext = appContext;
        }

        Matricula IRepositorioMatricula.AddMatricula(Matricula matricula)
        {
            var matriculaAdicionada = _appContext.Matriculas.Add(matricula);
            _appContext.SaveChanges();
            return matriculaAdicionada.Entity ; 
        }

        Matricula IRepositorioMatricula.UpdateMatricula(Matricula matricula)
        {
            var matriculaEncontrada = _appContext.Matriculas.FirstOrDefault(m => m.id == matricula.id);
            if (matriculaEncontrada != null)
            {
                matriculaEncontrada.estudiante = matricula.estudiante;
                matriculaEncontrada.clase_1 = matricula.clase_1;
                matriculaEncontrada.clase_2 = matricula.clase_2;
                matriculaEncontrada.clase_3 = matricula.clase_3;
                matriculaEncontrada.clase_4 = matricula.clase_4;
                _appContext.SaveChanges();
            }
            return matriculaEncontrada;            
        }

        void IRepositorioMatricula.DeleteMatricula(int idMatricula)
        {
            var matriculaEncontrada = _appContext.Matriculas.FirstOrDefault(m => m.id == idMatricula);
            if (matriculaEncontrada == null)
                return;
            _appContext.Matriculas.Remove(matriculaEncontrada);
            _appContext.SaveChanges();
        }

        Matricula IRepositorioMatricula.GetMatricula(int idMatricula)
        {
            return _appContext.Matriculas.FirstOrDefault(m => m.id == idMatricula);
        }

        IEnumerable<Matricula> IRepositorioMatricula.GetAllMatriculas()
        {
            return _appContext.Matriculas;
        }
    }
}