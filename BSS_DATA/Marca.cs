using ServiceStack.DataAnnotations;

namespace BSS_DATA
{
    public class Marca
    {
        [AutoIncrement]
        public int ma_codigo { get; set; }

        public string ma_nombre { get; set; }
    }
}