using System;

namespace BSS_DATA
{
    public class Seg_usuario
    {
        public string su_usuario { get; set; }

        public string su_nombre_completo { get; set; }

        public DateTime su_fecha_ingreso { get; set; }

        public string su_estado { get; set; }

        public string su_contrasena { get; set; }

        public int su_dias_vigencia_contrasena { get; set; }

        public DateTime su_ultimo_cambio { get; set; }

        public string su_usu_insercion { get; set; }
    }
}