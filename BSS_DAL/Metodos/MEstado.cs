using System.Collections.Generic;
using BSS_DATA;
using DAL.Interfaces;
using ServiceStack.OrmLite;
using System.Linq;

namespace DAL.Metodos
{
    public class MEstado : MConnection, IEstado
    {
        public void ActualizarEstado(Estado estado)
        {
            _db.Update(estado);
        }

        public Estado BuscarEstado(string cod_estado)
        {
            return _db.Select<Estado>(x => x.cod_estado == cod_estado).FirstOrDefault();
        }

        public void EliminarEstado(string cod_estado)
        {
            _db.Delete<Estado>(x => x.cod_estado == cod_estado);
        }

        public void InsertarEstado(Estado estado)
        {
            _db.Insert(estado);
        }

        public List<Estado> ListarEstados()
        {
            return _db.Select<Estado>();
        }
    }
}
