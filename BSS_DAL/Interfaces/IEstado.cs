using System.Collections.Generic;
using BSS_DATA;

namespace DAL.Interfaces
{
    public interface IEstado
    {
        List<Estado> ListarEstados();
        Estado BuscarEstado(string cod_estado);
        void InsertarEstado(Estado estado);
        void ActualizarEstado(Estado estado);
        void EliminarEstado(string cod_estado);
    }
}
