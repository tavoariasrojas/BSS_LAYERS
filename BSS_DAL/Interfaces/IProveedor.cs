using System.Collections.Generic;
using BSS_DATA;

namespace DAL.Interfaces
{
    public interface IProveedor
    {
        List<Proveedor> ListarProveedores();
        Proveedor BuscarMoneda(int prov_codigo);
        void InsertarProveedor(Proveedor proveedor);
        void ActualizarProveedor(Proveedor proveedor);
        void EliminarProveedor(int prov_codigo);
    }
}
