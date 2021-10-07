using System.Collections.Generic;
using AsignaSalones.App.Dominio;

namespace AsignaSalones.App.Persistencia
{
    public interface IRepositorioMatricula
    {
        //GetAllMatriculas
        IEnumerable<Matricula> GetAllMatriculas();
        //AddMatricula
        Matricula AddMatricula(Matricula matricula);
        //UpdateMatricula
        Matricula UpdateMatricula(Matricula matricula);
        //DeleteMatricula
        void DeleteMatricula(int idMatricula);
        //GetMatricula
        Matricula GetMatricula(int idMatricula);
    }
}