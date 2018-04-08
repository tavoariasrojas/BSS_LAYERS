using System.Collections.Generic;
using BSS_DATA;

namespace DAL.Interfaces
{
    public interface ITipo_pago
    {
        List<Tipo_pago> ListarTipoPago();
        Tipo_pago BuscarTipoPago(int tpa_codigo);
        void InsertarTipoPago(Tipo_pago tipo_pago);
        void ActualizarTipoPago(Tipo_pago tipo_pago);
        void EliminarTipoPago(int tpa_codigo);
    }
}
