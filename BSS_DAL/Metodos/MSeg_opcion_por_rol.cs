using System.Collections.Generic;
using BSS_DATA;
using DAL.Interfaces;
using ServiceStack.OrmLite;
using System.Linq;

namespace DAL.Metodos
{
    public class MSeg_opcion_por_rol : MConnection, ISeg_opcion_por_rol
    {
        public void ActualizarSegOpcionPorRol(Seg_opcion_por_rol seg_opcion_por_rol)
        {
            _db.Update(seg_opcion_por_rol);
        }

        public Seg_opcion_por_rol BuscarSegOpcionPorRol(string sopr_sr_rol)
        {
            return _db.Select<Seg_opcion_por_rol>(x => x.sopr_sr_rol == sopr_sr_rol).FirstOrDefault();
        }

        public void EliminarSegOpcionPorRol(string sopr_sr_rol)
        {
            _db.Delete<Seg_opcion_por_rol>(x => x.sopr_sr_rol == sopr_sr_rol);
        }

        public void InsertarSegOpcionPorRol(Seg_opcion_por_rol seg_opcion_por_rol)
        {
            _db.Insert(seg_opcion_por_rol);
        }

        public List<Seg_opcion_por_rol> ListarSegOpcionPorRol()
        {
            return _db.Select<Seg_opcion_por_rol>();
        }
    }
}
