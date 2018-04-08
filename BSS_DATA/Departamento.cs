using ServiceStack.DataAnnotations;

namespace BSS_DATA
{
    public class Departamento
    {
        [AutoIncrement]
        public int dep_codigo { get; set; }

        public int dep_co_compania { get; set; }

        public int dep_suc_codigo { get; set; }

        public string dep_descripcion { get; set; }

        public string dep_estado { get; set; }
    }
}