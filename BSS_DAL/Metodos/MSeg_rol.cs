using System.Collections.Generic;
using BSS_DATA;
using DAL.Interfaces;
using ServiceStack.OrmLite;
using System.Linq;

namespace DAL.Metodos
{
    public class MSeg_rol : MConnection, ISeg_rol
    {
        public void ActualizarSegRol(Seg_rol seg_rol)
        {
            _db.Update(seg_rol);
        }

        public Seg_rol BuscarSegRol(string sr_rol)
        {
            return _db.Select<Seg_rol>(x => x.sr_rol == sr_rol).FirstOrDefault();
        }

        public void EliminarSegRol(string sr_rol)
        {
            _db.Delete<Seg_rol>(x => x.sr_rol == sr_rol);
        }

        public void InsertarSegRol(Seg_rol seg_rol)
        {
            _db.Insert(seg_rol); ;
        }

        public List<Seg_rol> ListarSegRoles()
        {
            return _db.Select<Seg_rol>();
        }
    }
}
