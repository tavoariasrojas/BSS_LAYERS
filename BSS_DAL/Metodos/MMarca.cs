using System.Collections.Generic;
using BSS_DATA;
using DAL.Interfaces;
using ServiceStack.OrmLite;
using System.Linq;

namespace DAL.Metodos
{
    public class MMarca : MConnection, IMarca
    {
        public void ActualizarMarca(Marca marca)
        {
            _db.Update(marca);
        }

        public Marca BuscarMarca(int ma_codigo)
        {
            return _db.Select<Marca>(x => x.ma_codigo == ma_codigo).FirstOrDefault();
        }

        public void EliminarMarca(int ma_codigo)
        {
            _db.Delete<Marca>(x => x.ma_codigo == ma_codigo);
        }

        public void InsertarMarca(Marca marca)
        {
            _db.Insert(marca);
        }

        public List<Marca> ListarMarcas()
        {
            return _db.Select<Marca>();
        }
    }
}
