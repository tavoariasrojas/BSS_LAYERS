using ServiceStack.DataAnnotations;

namespace BSS_DATA
{
    public class Proveedor
    {
        [AutoIncrement]
        public int prov_codigo { get; set; }

        public string prov_nombre { get; set; }

        public int prov_dias_credito { get; set; }

        public string prov_email { get; set; }

        public string prov_persona_contacto { get; set; }

        public string prov_ubicacion { get; set; }

        public string prov_estado { get; set; }
    }
}