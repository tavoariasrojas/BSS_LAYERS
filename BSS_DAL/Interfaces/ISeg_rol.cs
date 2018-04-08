using System.Collections.Generic;
using BSS_DATA;

namespace DAL.Interfaces
{
    public interface ISeg_rol
    {
        List<Seg_rol> ListarSegRoles();
        Seg_rol BuscarSegRol(string sr_rol);
        void InsertarSegRol(Seg_rol seg_rol);
        void ActualizarSegRol(Seg_rol seg_rol);
        void EliminarSegRol(string sr_rol);
    }
}
