using System.Collections.Generic;
using BSS_DATA;

namespace DAL.Interfaces
{
    interface ITelefono_cliente
    {
        List<Telefono_cliente> ListarTelefonoClientes();
        Telefono_cliente BuscarTelefonoCliente(int tc_cli_codigo);
        void InsertarTelefonoCliente(Telefono_cliente telefono_cliente);
        void ActualizarTelefonoCliente(Telefono_cliente telefono_cliente);
        void EliminarTelefonoCliente(int tc_cli_codigo, int tc_tt_codigo);
    }
}
