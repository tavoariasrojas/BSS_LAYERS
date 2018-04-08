using System.Collections.Generic;
using BSS_DATA;
using DAL.Interfaces;
using ServiceStack.OrmLite;
using System.Linq;

namespace DAL.Metodos
{
    public class MEmpleado : MConnection, IEmpleado
    {
        public void ActualizarEmpleado(Empleado empleado)
        {
            _db.Update(empleado);
        }

        public Empleado BuscarEmpleado(int emp_codigo)
        {
            return _db.Select<Empleado>(x => x.emp_codigo == emp_codigo).FirstOrDefault();
        }

        public void EliminarEmpleado(int emp_codigo)
        {
            _db.Delete<Empleado>(x => x.emp_codigo == emp_codigo);
        }

        public void InsertarEmpleado(Empleado empleado)
        {
            _db.Insert(empleado);
        }

        public List<Empleado> ListarEmpleados()
        {
            return _db.Select<Empleado>();
        }
    }
}
