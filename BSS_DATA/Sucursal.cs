using ServiceStack.DataAnnotations;

namespace BSS_DATA
{
    public class Sucursal
    {
        [AutoIncrement]
        public int suc_codigo { get; set; }

        public int suc_co_compania { get; set; }

        public string suc_nombre { get; set; }

        public string suc_ubicacion { get; set; }

        public string suc_estado { get; set; }
    }
}