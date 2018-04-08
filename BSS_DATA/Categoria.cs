using ServiceStack.DataAnnotations;

namespace BSS_DATA
{
    public class Categoria
    {
        [AutoIncrement]
        public int cat_codigo { get; set; }

        public int cat_tps_codigo { get; set; }

        public string cat_nombre { get; set; }
    }
}