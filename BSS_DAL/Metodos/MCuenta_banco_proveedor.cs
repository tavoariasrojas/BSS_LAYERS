using System.Collections.Generic;
using BSS_DATA;
using DAL.Interfaces;
using ServiceStack.OrmLite;
using System.Linq;

namespace DAL.Metodos
{
    public class MCuenta_banco_proveedor : MConnection, ICuenta_banco_proveedor
    {
        public void ActualizarCuentaBancoProveedor(Cuenta_banco_proveedor cuenta_banco_proveedor)
        {
            _db.Update(cuenta_banco_proveedor);
        }

        public Cuenta_banco_proveedor BuscarCuentaBancoProveedor(int cbp_codigo)
        {
            return _db.Select<Cuenta_banco_proveedor>(x => x.cbp_codigo == cbp_codigo).FirstOrDefault();
        }

        public void EliminarCuentaBancoProveedor(int cbp_codigo)
        {
            _db.Delete<Cuenta_banco_proveedor>(x => x.cbp_codigo == cbp_codigo);
        }

        public void InsertarCuentaBancoProveedor(Cuenta_banco_proveedor cuenta_banco_proveedor)
        {
            _db.Insert(cuenta_banco_proveedor);
        }

        public List<Cuenta_banco_proveedor> ListarCuentaBancoProveedor()
        {
            return _db.Select<Cuenta_banco_proveedor>();
        }
    }
}
