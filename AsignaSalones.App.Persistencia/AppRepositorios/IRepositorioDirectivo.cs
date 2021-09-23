using System.Collections.Generic;
using AsignaSalones.App.Dominio;

namespaceAsignaSalones.App.Persistencia
{
    public interface IRepositorioDirectivo 
    {
        //GetAllDirectivos
        IEnumerable<Directivo> GetAllDirectivos();
        //AddDirectivo
        Directivo AddDirectivo(Directivo directivo);
        //UpdateDirectivo
        Directivo UpdateDirectivo(Directivo directivo);
        //DeleteDirectivo
        void DeleteDirectivo(int iddirectivo);
        //GetDirectivo
        Directivo GetDirectivo(int iddirectivo);

    }
}