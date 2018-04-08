using System.Collections.Generic;
using BSS_DATA;
using DAL.Interfaces;
using ServiceStack.OrmLite;
using System.Linq;

namespace DAL.Metodos
{
    public class MSeg_usuario : MConnection, ISeg_usuario
    {
        public void ActualizarSegUsuario(Seg_usuario seg_usuario)
        {
            _db.Update(seg_usuario);
        }

        public Seg_usuario BuscarSegUsuario(string su_usuario)
        {
            return _db.Select<Seg_usuario>(x => x.su_usuario == su_usuario).FirstOrDefault();
        }

        public Seg_usuario BuscarSegUsuario(string su_usuario, string clave)
        {
            return _db.Select<Seg_usuario>(x => x.su_usuario == su_usuario && x.su_contrasena == clave).FirstOrDefault();
        }

        public void EliminarSegUsuario(string su_usuario)
        {
            _db.Delete<Seg_usuario>(x => x.su_usuario == su_usuario);
        }

        public void InsertarSegUsuario(Seg_usuario seg_usuario)
        {
            _db.Insert(seg_usuario);
        }

        public List<Seg_usuario> ListarSegUsuarios()
        {
            return _db.Select<Seg_usuario>();
        }
    }
}
