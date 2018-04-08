using ServiceStack.DataAnnotations;
using System;

namespace BSS_DATA
{
    public class Fac_maestro
    {
        [AutoIncrement]
        public long fma_sec_factura { get; set; }

        public int fma_suc_codigo { get; set; }

        public int fma_cli_codigo { get; set; }

        public int fma_tv_venta { get; set; }

        public string fma_mon_codigo { get; set; }

        public decimal fma_sub_total { get; set; }

        public decimal fma_impuesto { get; set; }

        public decimal fma_total { get; set; }

        public string fma_usu_genera { get; set; }

        public DateTime fma_fecha_impresion { get; set; }

        public bool fma_es_nula { get; set; }
    }
}