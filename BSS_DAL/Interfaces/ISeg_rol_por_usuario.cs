using System.Collections.Generic;
using BSS_DATA;

namespace DAL.Interfaces
{
    public interface ISeg_rol_por_usuario
    {
        List<Seg_rol_por_usuario> ListarSegRolPorUsuario();
        Seg_rol_por_usuario BuscarSegRol(int srpu_suc_codigo, string srpu_sr_rol);
        void InsertarSegRolPorUsuario(Seg_rol_por_usuario seg_rol_por_usuario);
        void ActualizarSegRolPorUsuario(Seg_rol_por_usuario seg_rol_por_usuario);
        void EliminarSegRolPorUsuario(int srpu_suc_codigo, string srpu_sr_rol);
    }
}
