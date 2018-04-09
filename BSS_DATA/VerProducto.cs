using ServiceStack.DataAnnotations;

namespace BSS_DATA
{
    public class VerProducto
    {
        [Alias("prod_codigo")]
        public long Codigo { get; set; }

        [Alias("tp_descripcion")]
        public string Tipo { get; set; }

        [Alias("ma_nombre")]
        public string Marca { get; set; }

        [Alias("prod_detalle")]
        public string Detalle { get; set; }

        [Alias("mon_nombre")]
        public string Moneda { get; set; }

        [Alias("prod_precio")]
        public decimal Precio { get; set; }

        [Alias("prod_desc")]
        public decimal Descuento { get; set; }

        [Alias("prod_es_gravado")]
        public bool Es_Gravado { get; set; }

        [Alias("um_descripcion")]
        public string Unidad_Medida { get; set; }

        [Alias("prod_medida")]
        public decimal Medida { get; set; }
    }
}
