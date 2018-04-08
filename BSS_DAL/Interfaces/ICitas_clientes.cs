using System.Collections.Generic;
using BSS_DATA;

namespace DAL.Interfaces
{
    public interface ICitas_clientes
    {
        List<Citas_clientes> ListarCitas();
        Citas_clientes BuscarCitas(int cc_id);
        void InsertarCita(Citas_clientes citas_cliente);
        void ActualizarCita(Citas_clientes citas_cliente);
        void EliminarCita(int cc_id);
    }
}
