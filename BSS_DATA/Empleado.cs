using ServiceStack.DataAnnotations;
using System;

namespace BSS_DATA
{
    public class Empleado
    {
        [AutoIncrement]
        public int emp_codigo { get; set; }

        public string emp_ti_codigo { get; set; }

        public string emp_identificacion { get; set; }

        public string emp_nombre { get; set; }

        public string emp_pri_apellido { get; set; }

        public string emp_seg_apellido { get; set; }

        public DateTime emp_fec_nacimiento { get; set; }

        public int emp_fps_salario { get; set; }

        public decimal emp_salario_monto { get; set; }

        public string emp_mon_codigo { get; set; }

        public string emp_estado { get; set; }

        public string emp_usu_insercion { get; set; }

        public DateTime emp_fec_insercion { get; set; }

        public string emp_usu_modificacion { get; set; }

        public DateTime emp_fec_modificacion { get; set; }
    }
}