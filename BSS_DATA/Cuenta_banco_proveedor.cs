using ServiceStack.DataAnnotations;

namespace BSS_DATA
{
    public class Cuenta_banco_proveedor
    {
        [AutoIncrement]
        public int cbp_codigo { get; set; }

        public int cbp_banco { get; set; }

        public string cbp_moneda { get; set; }

        public string cbp_num_cuenta { get; set; }

        public string cbp_estado { get; set; }
    }
}