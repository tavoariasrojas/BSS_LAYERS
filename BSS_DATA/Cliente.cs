using ServiceStack.DataAnnotations;
using System;

namespace BSS_DATA
{
    public class Cliente
    {
        [AutoIncrement]
        public int cli_codigo { get; set; }

        public string cli_ti_codigo { get; set; }

        public string cli_genero { get; set; }

        public string cli_identificacion { get; set; }

        public string cli_nombre { get; set; }

        public string cli_pri_apellido { get; set; }

        public string cli_seg_apellido { get; set; }

        public DateTime cli_fec_nacimiento { get; set; }

        public string cli_pa_codigo { get; set; }

        public string cli_email { get; set; }
    }
}