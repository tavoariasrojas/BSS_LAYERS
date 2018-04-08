using System.Collections.Generic;
using BSS_DATA;

namespace DAL.Interfaces
{
    public interface IControl_venta_credito
    {
        List<Control_venta_credito> ListarControlVentaCredito();
        Control_venta_credito BuscarControlVentaCredito(long cvc_secuencia);
        void InsertarControlVentaCredito(Control_venta_credito control_venta_credito);
        void ActualizarControlVentaCredito(Control_venta_credito control_venta_credito);
        void EliminarControlVentaCredito(long cvc_secuencia);
    }
}
