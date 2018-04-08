using ServiceStack.DataAnnotations;
using System;

namespace BSS_DATA
{
    public class Citas_clientes
    {
        [AutoIncrement]
        public int cc_id { get; set; }

        public string cc_titulo { get; set; }

        public int cc_codigo_cliente { get; set; }

        public DateTime cc_fecha_inicio { get; set; }

        public DateTime cc_fecha_fin { get; set; }

        public long cc_producto { get; set; }

        public int cc_empleado { get; set; }

        public string cc_estado { get; set; }
    }
}