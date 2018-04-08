using System.Collections.Generic;
using BSS_DATA;

namespace DAL.Interfaces
{
    public interface ISeg_opcion_por_rol
    {
        List<Seg_opcion_por_rol> ListarSegOpcionPorRol();
        Seg_opcion_por_rol BuscarSegOpcionPorRol(string sopr_sr_rol);
        void InsertarSegOpcionPorRol(Seg_opcion_por_rol seg_opcion_por_rol);
        void ActualizarSegOpcionPorRol(Seg_opcion_por_rol seg_opcion_por_rol);
        void EliminarSegOpcionPorRol(string sopr_sr_rol);
    }
}
