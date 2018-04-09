using System.Collections.Generic;
using BSS_DATA;
using DAL.Interfaces;
using ServiceStack.OrmLite;
using System.Linq;
using System.Collections;
using ServiceStack;
using ServiceStack.Text;

namespace DAL.Metodos
{

    public class MProducto : MConnection, IProducto
    {


        public void ActualizarProducto(Producto producto)
        {
            _db.Update(producto);
           
        }

        public void prueba(long prod_codigo)
        {
            var query = _db.Select<Producto>(x => x.prod_codigo == prod_codigo).FirstOrDefault();
        }

        public Producto BuscarProducto(long prod_codigo)
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

        public List<VerProducto> VerProductos()
        {
            return _db.SqlList<VerProducto>("EXEC sp_Producto");
        }
    }
}
