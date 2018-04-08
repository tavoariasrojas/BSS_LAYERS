using System.Collections.Generic;
using BSS_DATA;
using DAL.Interfaces;
using ServiceStack.OrmLite;
using System.Linq;

namespace DAL.Metodos
{
    public class MSeg_opcion : MConnection, ISeg_opcion
    {
        public void ActualizarSegOpcion(Seg_opcion seg_opcion)
        {
            _db.Update(seg_opcion);
        }

        public Seg_opcion BuscarSegOpcion(string so_codigo)
        {
            return _db.Select<Seg_opcion>(x => x.so_codigo == so_codigo).FirstOrDefault();
        }

        public void EliminarSegOpcion(string so_codigo)
        {
            _db.Delete<Seg_opcion>(x => x.so_codigo == so_codigo);
        }

        public void InsertarSegOpcion(Seg_opcion seg_opcion)
        {
            _db.Insert(seg_opcion);
        }

        public List<Seg_opcion> ListarSegOpcion()
        {
            return _db.Select<Seg_opcion>();
        }
    }
}
