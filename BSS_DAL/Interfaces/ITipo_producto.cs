using System.Collections.Generic;
using BSS_DATA;


namespace DAL.Interfaces
{
    public interface ITipo_producto
    {
        List<Tipo_producto> ListarTipoProductos();
        Tipo_producto BuscarTipoProducto(int tp_codigo);
        void InsertarTipoProducto(Tipo_producto tipo_producto);
        void ActualizarTipoProducto(Tipo_producto tipo_producto);
        void EliminarTipoProducto(int tp_codigo);
    }
}
