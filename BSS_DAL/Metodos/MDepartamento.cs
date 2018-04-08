using System.Collections.Generic;
using BSS_DATA;
using DAL.Interfaces;
using ServiceStack.OrmLite;
using System.Linq;

namespace DAL.Metodos
{
    public class MDepartamento : MConnection, IDepartamento
    {
        public void ActualizarDepartamento(Departamento departamento)
        {
            _db.Update(departamento);
        }

        public Departamento BuscarDepartamento(int dep_codigo)
        {
            return _db.Select<Departamento>(x => x.dep_codigo == dep_codigo).FirstOrDefault();
        }

        public void EliminarDepartamento(int dep_codigo)
        {
            _db.Delete<Departamento>(x => x.dep_codigo == dep_codigo);
        }

        public void InsertarDepartamento(Departamento departamento)
        {
            _db.Insert(departamento);
        }

        public List<Departamento> ListarDepartamentos()
        {
            return _db.Select<Departamento>();
        }
    }
}
