using System.Collections.Generic;
using AsignaSalones.App.Dominio;

namespaceAsignaSalones.App.Persistencia
{
    public interface IRepositorioContagiado 
    {
        //GetAllContagiado
        IEnumerable<Contagiado> GetAllContagiados();
        //AddContagiado
        Contagiado AddContagiado(Contagiado Contagiado);
        //UpdateContagiado
        Contagiado UpdateContagiado(Contagiado Contagiado);
        //DeleteContagiado
        void DeleteContagiado(int idContagiado);
        //GetContagiado
        Contagiado GetContagiado(int idContagiado);

    }
}