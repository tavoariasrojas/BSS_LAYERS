using System.Collections.Generic;
using BSS_DATA;
using DAL.Interfaces;
using ServiceStack.OrmLite;
using System.Linq;

namespace DAL.Metodos
{
    public class MProveedor : MConnection, IProveedor
    {
        public void ActualizarProveedor(Proveedor proveedor)
        {
            _db.Update(proveedor);
        }

        public Proveedor BuscarMoneda(int prov_codigo)
        {
            return _db.Select<Proveedor>(x => x.prov_codigo == prov_codigo).FirstOrDefault();
        }

        public void EliminarProveedor(int prov_codigo)
        {
            _db.Delete<Proveedor>(x => x.prov_codigo == prov_codigo);
        }

        public void InsertarProveedor(Proveedor proveedor)
        {
            _db.Insert(proveedor);
        }

        public List<Proveedor> ListarProveedores()
        {
            return _db.Select<Proveedor>();
        }
    }
}
