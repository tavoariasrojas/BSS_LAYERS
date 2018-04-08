using System.Collections.Generic;
using BSS_DATA;

namespace DAL.Interfaces
{
    public interface ITipo_identificacion
    {
        List<Tipo_identificacion> ListarTipoIdentificaciones();
        Tipo_identificacion BuscarTipoIdentificacion(string ti_codigo);
        void InsertarTipoIdentificacion(Tipo_identificacion tipo_identificacion);
        void ActualizarTipoIdentificacion(Tipo_identificacion tipo_identificacion);
        void EliminarTipoIdentificacion(string ti_codigo);
    }
}
