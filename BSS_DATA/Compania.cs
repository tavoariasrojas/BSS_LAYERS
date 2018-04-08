using ServiceStack.DataAnnotations;

namespace BSS_DATA
{
    public class Compania
    {
        [AutoIncrement]
        public int co_compania { get; set; }

        public string co_nombre { get; set; }

        public string co_descripcion { get; set; }

        public string co_cedula_juridica { get; set; }

        public string co_pa_codigo { get; set; }

        public string co_mon_codigo_defecto { get; set; }

        public string co_ubicacion { get; set; }
    }
}