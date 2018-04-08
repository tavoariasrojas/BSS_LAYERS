using System.Collections.Generic;
using BSS_DATA;
using DAL.Interfaces;
using ServiceStack.OrmLite;
using System.Linq;

namespace DAL.Metodos
{
    public class MCliente : MConnection, ICliente
    {
        public void ActualizarCliente(Cliente cliente)
        {
            _db.Update(cliente);
        }

        public Cliente BuscarCitas(int cli_codigo)
        {
            return _db.Select<Cliente>(x => x.cli_codigo == cli_codigo).FirstOrDefault();
        }

        public void EliminarCliente(int cli_codigo)
        {
            _db.Delete<Cliente>(x => x.cli_codigo == cli_codigo);
        }

        public void InsertarCliente(Cliente cliente)
        {
            _db.Insert(cliente);
        }

        public List<Cliente> ListarClientes()
        {
            return _db.Select<Cliente>();
        }
    }
}
