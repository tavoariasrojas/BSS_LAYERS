using System.Collections.Generic;
using BSS_DATA;

namespace DAL.Interfaces
{
    public interface IEstado_cita
    {
        List<Estado_cita> ListarEstadosCita();
        Estado_cita BuscarEstado(string cod_estado);
        void InsertarEstadoCita(Estado_cita estado);
        void ActualizarEstadoCita(Estado_cita estado);
        void EliminarEstadoCita(string cod_estado);
    }
}
