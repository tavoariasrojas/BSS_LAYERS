using ServiceStack.DataAnnotations;

namespace BSS_DATA
{
    public class Tipo_producto
    {
        [AutoIncrement]
        public int tp_codigo { get; set; }

        public int tp_cat_codigo { get; set; }

        public string tp_descripcion { get; set; }
    }

}