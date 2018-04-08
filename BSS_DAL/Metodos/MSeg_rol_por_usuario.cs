using System.Collections.Generic;
using BSS_DATA;
using DAL.Interfaces;
using ServiceStack.OrmLite;
using System.Linq;

namespace DAL.Metodos
{
    public class MSeg_rol_por_usuario : MConnection, ISeg_rol_por_usuario
    {
        public void ActualizarSegRolPorUsuario(Seg_rol_por_usuario seg_rol_por_usuario)
        {
            _db.Update(seg_rol_por_usuario);
        }

        public Seg_rol_por_usuario BuscarSegRol(int srpu_suc_codigo, string srpu_sr_rol)
        {
            return _db.Select<Seg_rol_por_usuario>(x => x.srpu_suc_codigo == srpu_suc_codigo && x.srpu_sr_rol == srpu_sr_rol).FirstOrDefault();
        }

        public void EliminarSegRolPorUsuario(int srpu_suc_codigo, string srpu_sr_rol)
        {
            _db.Delete<Seg_rol_por_usuario>(x => x.srpu_suc_codigo == srpu_suc_codigo && x.srpu_sr_rol == srpu_sr_rol);
        }

        public void InsertarSegRolPorUsuario(Seg_rol_por_usuario seg_rol_por_usuario)
        {
            _db.Insert(seg_rol_por_usuario);
        }

        public List<Seg_rol_por_usuario> ListarSegRolPorUsuario()
        {
            return _db.Select<Seg_rol_por_usuario>();
        }
    }
}
