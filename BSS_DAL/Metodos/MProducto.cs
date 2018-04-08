using System.Collections.Generic;
using BSS_DATA;
using DAL.Interfaces;
using ServiceStack.OrmLite;
using System.Linq;

namespace DAL.Metodos
{
    public class MProducto : MConnection, IProducto
    {
        public void ActualizarProducto(Producto producto)
        {
            _db.Update(producto);
        }

        public Producto BuscarMoneda(long prod_codigo)
        {
            return _db.Select<Producto>(x => x.prod_codigo == prod_codigo).FirstOrDefault();
        }

        public void EliminarProducto(long prod_codigo)
        {
            _db.Delete<Producto>(x => x.prod_codigo == prod_codigo);
        }

        public void InsertarProducto(Producto producto)
        {
            _db.Insert(producto);
        }

        public List<Producto> ListarProductos()
        {
            return _db.Select<Producto>();
        }
    }
}
