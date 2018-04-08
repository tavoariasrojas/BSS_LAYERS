using System.Collections.Generic;
using BSS_DATA;
using DAL.Interfaces;
using ServiceStack.OrmLite;
using System.Linq;

namespace DAL.Metodos
{
    public class MPais : MConnection, IPais
    {
        public void ActualizarPais(Pais pais)
        {
            _db.Update(pais);
        }

        public Pais BuscarPais(string pa_codigo)
        {
            return _db.Select<Pais>(x => x.pa_codigo == pa_codigo).FirstOrDefault();
        }

        public void EliminarPais(string pa_codigo)
        {
            _db.Delete<Pais>(x => x.pa_codigo == pa_codigo);
        }

        public void InsertarPais(Pais pais)
        {
            _db.Insert(pais);
        }

        public List<Pais> ListarPaises()
        {
            return _db.Select<Pais>();
        }
    }
}
