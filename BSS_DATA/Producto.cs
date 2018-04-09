using ServiceStack.DataAnnotations;

namespace BSS_DATA
{
    public class Producto
    {
        public long prod_codigo { get; set; }

        public int prod_tp_codigo { get; set; }

        public int prod_ma_codigo { get; set; }

        public string prod_detalle { get; set; }

        public string prod_mon_codigo { get; set; }

        public decimal prod_precio { get; set; }

        public decimal prod_desc { get; set; }

        public bool prod_es_gravado { get; set; }

        public int prod_um_codigo { get; set; }

        public decimal prod_medida { get; set; }
    }
}

