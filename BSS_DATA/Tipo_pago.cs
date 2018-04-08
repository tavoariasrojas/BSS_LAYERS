using ServiceStack.DataAnnotations;

namespace BSS_DATA
{
    public class Tipo_pago
    {
        [AutoIncrement]
        public int tpa_codigo { get; set; }

        public string tpa_descripcion { get; set; }

    }
}