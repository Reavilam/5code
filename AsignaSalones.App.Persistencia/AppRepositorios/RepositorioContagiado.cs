using AsignaSalones.App.Dominio;
using System.Collections.Generic;
using System.Linq;

namespace AsignaSalones.App.Persistencia 
{
    public class RepositorioContagiado : IRepositorioContagiado
    {
        private static AppContext _appContext;
        
        public RepositorioContagiado(AppContext appContext)
        {
            _appContext = appContext;
        }

        Contagiado IRepositorioContagiado.AddContagiado(Contagiado contagiado)
        {
            var contagiadoAdicionado = _appContext.Contagiados.Add(contagiado) ;
            _appContext.SaveChanges();
            return contagiadoAdicionado.Entity;
        }

        Contagiado IRepositorioContagiado.UpdateContagiado(Contagiado contagiado)
        {
            var contagiadoEncontrado = _appContext.Contagiados.FirstOrDefault(c => c.id == contagiado.id);
            if (contagiadoEncontrado != null)
            {

                contagiadoEncontrado.fechaContagio = contagiado.fechaContagio;
                contagiadoEncontrado.sintomas= contagiado.sintomas;
                contagiadoEncontrado.periodoAislamiento = contagiado.periodoAislamiento;

                _appContext.SaveChanges();
            }
            return contagiadoEncontrado;
         }

        void IRepositorioContagiado.DeleteContagiado(int idContagiado)
        {
            var contagiadoEncontrado = _appContext.Contagiados.FirstOrDefault(c => c.id == idContagiado);
            if (contagiadoEncontrado == null)
                return;
            _appContext.Contagiados.Remove(contagiadoEncontrado);
            _appContext.SaveChanges();
        }

        Contagiado IRepositorioContagiado.GetContagiado(int idContagiado)
        {
            var contagiadoEncontrado = _appContext.Contagiados.FirstOrDefault(c => c.id == idContagiado);
            return contagiadoEncontrado;
        }

        IEnumerable<Contagiado> IRepositorioContagiado.GetAllContagiados()
        {
            return _appContext.Contagiados;
        }
    }
}