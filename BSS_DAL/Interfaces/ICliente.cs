using System.Collections.Generic;
using BSS_DATA;

namespace DAL.Interfaces
{
    public interface ICliente
    {
        List<Cliente> ListarClientes();
        Cliente BuscarCitas(int cli_codigo);
        void InsertarCliente(Cliente cliente);
        void ActualizarCliente(Cliente cliente);
        void EliminarCliente(int cli_codigo);
    }
}
