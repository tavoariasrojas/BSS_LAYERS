using System.Collections.Generic;
using BSS_DATA;
using DAL.Interfaces;
using ServiceStack.OrmLite;
using System.Linq;

namespace DAL.Metodos
{
    public class MContro_venta_credito : MConnection, IControl_venta_credito
    {
        public void ActualizarControlVentaCredito(Control_venta_credito control_venta_credito)
        {
            _db.Update(control_venta_credito);
        }

        public Control_venta_credito BuscarControlVentaCredito(long cvc_secuencia)
        {
            return _db.Select<Control_venta_credito>(x => x.cvc_secuencia == cvc_secuencia).FirstOrDefault();
        }

        public void EliminarControlVentaCredito(long cvc_secuencia)
        {
            _db.Delete<Control_venta_credito>(x => x.cvc_secuencia == cvc_secuencia);
        }

        public void InsertarControlVentaCredito(Control_venta_credito control_venta_credito)
        {
            _db.Insert(control_venta_credito);
        }

        public List<Control_venta_credito> ListarControlVentaCredito()
        {
            return _db.Select<Control_venta_credito>();
        }
    }
}
