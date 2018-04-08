using System.Collections.Generic;
using BSS_DATA;

namespace DAL.Interfaces
{
    public interface ITipo_venta
    {
        List<Tipo_venta> ListarTipoVentas();
        Tipo_venta BuscarTipoVenta(int tv_codigo);
        void InsertarTipoVenta(Tipo_venta tipo_venta);
        void ActualizarTipoVenta(Tipo_venta tipo_venta);
        void EliminarTipoVenta(int tv_codigo);
    }
}
