using System.Collections.Generic;
using BSS_DATA;

namespace DAL.Interfaces
{
    public interface ICompania
    {
        List<Compania> ListarCompanias();
        Compania BuscarCompania(int co_compania);
        void InsertarCompania(Compania compania);
        void ActualizarCompania(Compania compania);
        void EliminarCompania(int co_compania);
    }
}
