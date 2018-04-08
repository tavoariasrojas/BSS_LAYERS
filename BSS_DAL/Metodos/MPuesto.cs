using System.Collections.Generic;
using BSS_DATA;
using DAL.Interfaces;
using ServiceStack.OrmLite;
using System.Linq;

namespace DAL.Metodos
{
    public class MPuesto : MConnection, IPuesto
    {
        public void ActualizarPuesto(Puesto puesto)
        {
            _db.Update(puesto);
        }

        public Puesto BuscarPuesto(int pue_codigo)
        {
            return _db.Select<Puesto>(x => x.pue_codigo == pue_codigo).FirstOrDefault();
        }

        public void EliminarPuesto(int pue_codigo)
        {
            _db.Delete<Puesto>(x => x.pue_codigo == pue_codigo);
        }

        public void InsertarPuesto(Puesto puesto)
        {
            _db.Insert(puesto);
        }

        public List<Puesto> ListarProveedores()
        {
            return _db.Select<Puesto>();
        }
    }
}
