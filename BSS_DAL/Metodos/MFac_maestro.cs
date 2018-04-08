using System.Collections.Generic;
using BSS_DATA;
using DAL.Interfaces;
using ServiceStack.OrmLite;
using System.Linq;
using System;

namespace DAL.Metodos
{
    public class MFac_maestro : MConnection, IFac_maestro
    {
        public void ActualizarFacMaestro(Fac_maestro fac_maestro)
        {
            _db.Update(fac_maestro);
        }

        public Fac_maestro BuscarFacMaestro(long fma_sec_factura)
        {
            return _db.Select<Fac_maestro>(x => x.fma_sec_factura == fma_sec_factura).FirstOrDefault();
        }

        public void EliminarFacMaestro(long fma_sec_factura)
        {
            _db.Delete<Fac_maestro>(x => x.fma_sec_factura == fma_sec_factura);
        }

        public void InsertarFacMaestro(Fac_maestro fac_maestro)
        {
            _db.Insert(fac_maestro);
        }

        public List<Fac_maestro> ListarFacMaestro()
        {
            return _db.Select<Fac_maestro>();
        }
    }
}
