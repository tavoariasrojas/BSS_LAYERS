using System.Collections.Generic;
using BSS_DATA;

namespace DAL.Interfaces
{
    public interface ITelefono_proveedor
    {
        List<Telefono_proveedor> ListarTelefonoProveedores();
        Telefono_proveedor BuscarTelefonoProveedor(int tel_prov_codigo);
        void InsertarTelefonoProveedor(Telefono_proveedor telefono_proveedor);
        void ActualizarTelefonoProveedor(Telefono_proveedor telefono_proveedor);
        void EliminarTelefonoProveedor(int tel_prov_codigo, int tel_prov_tt_codigo);
    }
}
