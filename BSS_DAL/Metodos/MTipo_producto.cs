using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BSS_DATA;
using DAL.Interfaces;
using DAL.Metodos;
using ServiceStack.OrmLite;

namespace DAL.Metodos
{
    public class MTipo_producto : MConnection, ITipo_producto
    {
        public Tipo_producto BuscarTipo_Produc(long codigo)
        {
            return _db.Select<Tipo_producto>(x => x.tp_codigo == codigo).FirstOrDefault();
        }

        public List<Tipo_producto> ListarTipoProductos()
        {
            return _db.Select<Tipo_producto>();
        }
    }
}
