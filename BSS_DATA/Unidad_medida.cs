using ServiceStack.DataAnnotations;

namespace BSS_DATA
{
    public class Unidad_medida
    {
        [AutoIncrement]
        public int um_codigo { get; set; }

        public string um_unidad { get; set; }

        public string um_descripcion { get; set; }
    }

}