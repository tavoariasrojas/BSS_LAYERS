using System.Collections.Generic;
using BSS_DATA;

namespace DAL.Interfaces
{
    public interface IDepartamento
    {
        List<Departamento> ListarDepartamentos();
        Departamento BuscarDepartamento(int dep_codigo);
        void InsertarDepartamento(Departamento departamento);
        void ActualizarDepartamento(Departamento departamento);
        void EliminarDepartamento(int dep_codigo);
    }
}
