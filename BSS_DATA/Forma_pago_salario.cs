using ServiceStack.DataAnnotations;

namespace BSS_DATA
{
    public class Forma_pago_salario
    {
        [AutoIncrement]
        public int fps_salario { get; set; }

        public string fps_descripcion { get; set; }

        public string fps_estado { get; set; }
    }
}