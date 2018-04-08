using System.Collections.Generic;
using BSS_DATA;
using DAL.Interfaces;
using ServiceStack.OrmLite;
using System.Linq;

namespace DAL.Metodos
{
    public class MFac_detalle : MConnection, IFac_detalle
    {
        public void ActualizarFacDetalle(Fac_detalle fac_detalle)
        {
            _db.Update(fac_detalle);
        }

        public Fac_detalle BuscarFacDetalle(long fdv_fma_sec_factura)
        {
            return _db.Select<Fac_detalle>(x => x.fdv_fma_sec_factura == fdv_fma_sec_factura).FirstOrDefault();
        }

        public void EliminarFacDetalle(long fdv_fma_sec_factura, long fdv_prod_codigo)
        {
            _db.Delete<Fac_detalle>(x => x.fdv_fma_sec_factura == fdv_fma_sec_factura && x.fdv_prod_codigo== fdv_prod_codigo);
        }

        public void InsertarFacDetalle(Fac_detalle fac_detalle)
        {
            _db.Insert(fac_detalle);
        }

        public List<Fac_detalle> ListarFacDetalle()
        {
            return _db.Select<Fac_detalle>();
        }
    }
}
