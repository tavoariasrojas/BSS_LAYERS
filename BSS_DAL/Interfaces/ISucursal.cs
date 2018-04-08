using System.Collections.Generic;
using BSS_DATA;

namespace DAL.Interfaces
{
    public interface ISucursal
    {
        List<Sucursal> ListarSucursales();
        Sucursal BuscarSucursal(int suc_codigo);
        void InsertarSucursal(Sucursal sucursal);
        void ActualizarSucursal(Sucursal sucursal);
        void EliminarSucursal(int suc_codigo);
    }
}
