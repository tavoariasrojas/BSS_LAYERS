using System.Collections.Generic;
using BSS_DATA;

namespace DAL.Interfaces
{
    public interface ICategoria
    {
        List<Categoria> ListarCategorias();
        Categoria BuscarProducto(int cat_codigo);
        void InsertarProducto(Categoria categoria);
        void ActualizarProducto(Categoria categoria);
        void EliminarCategoria(int cat_codigo);
    }
}
