using System.Collections.Generic;
using BSS_DATA;


namespace DAL.Interfaces
{
    public interface ITipo_producto
    {
        List<Tipo_producto> ListarTipoProductos();
        Tipo_producto BuscarTipo_Produc(long prod_codigo);
    }
}
