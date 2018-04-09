using System.Collections.Generic;
using BSS_DATA;

namespace DAL.Interfaces
{
    public interface IProducto
    {
        List<Producto> ListarProductos();
        List<VerProducto> VerProductos();
        Producto BuscarProducto(long prod_codigo);
        void InsertarProducto(Producto producto);
        void ActualizarProducto(Producto producto);
        void EliminarProducto(long prod_codigo);
    }
}
