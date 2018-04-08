using ServiceStack.DataAnnotations;

namespace BSS_DATA
{
    public class Control_venta_credito
    {
        [AutoIncrement]
        public long cvc_secuencia { get; set; }

        public long cvc_fma_sec_factura { get; set; }

        public string cvc_tm_codigo { get; set; }

        public string cvc_moneda { get; set; }

        public decimal cvc_monto { get; set; }
    }

}