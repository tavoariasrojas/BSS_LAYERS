using System.Collections.Generic;
using BSS_DATA;

namespace DAL.Interfaces
{
    public interface IEmpleado
    {
        List<Empleado> ListarEmpleados();
        Empleado BuscarEmpleado(int emp_codigo);
        void InsertarEmpleado(Empleado empleado);
        void ActualizarEmpleado(Empleado empleado);
        void EliminarEmpleado(int emp_codigo);
    }
}
