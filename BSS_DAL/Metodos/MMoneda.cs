using System.Collections.Generic;
using BSS_DATA;
using DAL.Interfaces;
using ServiceStack.OrmLite;
using System.Linq;

namespace DAL.Metodos
{
    public class MMoneda : MConnection, IMoneda
    {
        public void ActualizarMoneda(Moneda moneda)
        {
            _db.Update(moneda);
        }

        public Moneda BuscarMoneda(string mon_codigo)
        {
            return _db.Select<Moneda>(x => x.mon_codigo == mon_codigo).FirstOrDefault();
        }

        public void EliminarMoneda(string mon_codigo)
        {
            _db.Delete<Moneda>(x => x.mon_codigo == mon_codigo);
        }

        public void InsertarMoneda(Moneda moneda)
        {
            _db.Insert(moneda);
        }

        public List<Moneda> ListarMonedas()
        {
            return _db.Select<Moneda>();
        }
    }
}
