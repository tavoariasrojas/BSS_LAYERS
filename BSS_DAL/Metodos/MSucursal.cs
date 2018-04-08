using System.Collections.Generic;
using BSS_DATA;
using DAL.Interfaces;
using ServiceStack.OrmLite;
using System.Linq;

namespace DAL.Metodos
{
    public class MSucursal : MConnection, ISucursal
    {
        public void ActualizarSucursal(Sucursal sucursal)
        {
            _db.Update(sucursal);
        }

        public Sucursal BuscarSucursal(int suc_codigo)
        {
            return _db.Select<Sucursal>(x => x.suc_codigo == suc_codigo).FirstOrDefault();
        }

        public void EliminarSucursal(int suc_codigo)
        {
            _db.Delete<Sucursal>(x => x.suc_codigo == suc_codigo);
        }

        public void InsertarSucursal(Sucursal sucursal)
        {
            _db.Insert(sucursal);
        }

        public List<Sucursal> ListarSucursales()
        {
            return _db.Select<Sucursal>();
        }
    }
}
