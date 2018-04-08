using System.Collections.Generic;
using BSS_DATA;

namespace DAL.Interfaces
{
    public interface ICuenta_banco_proveedor
    {
        List<Cuenta_banco_proveedor> ListarCuentaBancoProveedor();
        Cuenta_banco_proveedor BuscarCuentaBancoProveedor(int cbp_codigo);
        void InsertarCuentaBancoProveedor(Cuenta_banco_proveedor cuenta_banco_proveedor);
        void ActualizarCuentaBancoProveedor(Cuenta_banco_proveedor cuenta_banco_proveedor);
        void EliminarCuentaBancoProveedor(int cbp_codigo);
    }
}
