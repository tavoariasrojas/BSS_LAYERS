using System.Collections.Generic;
using BSS_DATA;

namespace DAL.Interfaces
{
    public interface IFac_detalle
    {
        List<Fac_detalle> ListarFacDetalle();
        Fac_detalle BuscarFacDetalle(long fdv_fma_sec_factura);
        void InsertarFacDetalle(Fac_detalle fac_detalle);
        void ActualizarFacDetalle(Fac_detalle fac_detalle);
        void EliminarFacDetalle(long fdv_fma_sec_factura, long fdv_prod_codigo);
    }
}
