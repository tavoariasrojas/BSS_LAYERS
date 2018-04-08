using ServiceStack.DataAnnotations;

namespace BSS_DATA
{
    public class Telefono_cliente
    {
        [AutoIncrement]
        public int tc_cli_codigo { get; set; }

        public int tc_tt_codigo { get; set; }

        public string tc_numero { get; set; }
    }
}