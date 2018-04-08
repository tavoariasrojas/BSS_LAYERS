using System.Collections.Generic;
using BSS_DATA;

namespace DAL.Interfaces
{
    public interface ISeg_opcion
    {
        List<Seg_opcion> ListarSegOpcion();
        Seg_opcion BuscarSegOpcion(string so_codigo);
        void InsertarSegOpcion(Seg_opcion seg_opcion);
        void ActualizarSegOpcion(Seg_opcion seg_opcion);
        void EliminarSegOpcion(string so_codigo);
    }
}
