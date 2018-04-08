using ServiceStack.DataAnnotations;

namespace BSS_DATA
{
    public class Puesto
    {
        [AutoIncrement]
        public int pue_codigo { get; set; }

        public int pue_dep_codigo { get; set; }

        public string pue_descripcion { get; set; }

        public string pue_estado { get; set; }
    }
}