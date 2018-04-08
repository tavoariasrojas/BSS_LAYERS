using System.Collections.Generic;
using BSS_DATA;
using DAL.Interfaces;
using ServiceStack.OrmLite;
using System.Linq;

namespace DAL.Metodos
{
    public class MCategoria : MConnection , ICategoria
    {
        public void ActualizarProducto(Categoria categoria)
        {
            _db.Update(categoria);
        }

        public Categoria BuscarProducto(int cat_codigo)
        {
            return _db.Select<Categoria>(x => x.cat_codigo == cat_codigo).FirstOrDefault();
        }

        public void EliminarCategoria(int cat_codigo)
        {
            _db.Delete<Categoria>(x => x.cat_codigo == cat_codigo);
        }

        public void InsertarProducto(Categoria categoria)
        {
            _db.Insert(categoria);
        }

        public List<Categoria> ListarCategorias()
        {
            return _db.Select<Categoria>();
        }
    }
}
