using System.Collections.Generic;
using BSS_DATA;
using DAL.Interfaces;
using ServiceStack.OrmLite;
using System.Linq;
using System;

namespace DAL.Metodos
{
    public class MCompania : MConnection, ICompania
    {
        public void ActualizarCompania(Compania compania)
        {
            _db.Update(compania);
        }

        public Compania BuscarCompania(int co_compania)
        {
            return _db.Select<Compania>(x => x.co_compania == co_compania).FirstOrDefault();
        }

        public void EliminarCompania(int co_compania)
        {
            _db.Delete<Compania>(x => x.co_compania == co_compania);
        }

        public void InsertarCompania(Compania compania)
        {
            _db.Insert(compania);
        }

        public List<Compania> ListarCompanias()
        {
            return _db.Select<Compania>();
        }
    }
}
