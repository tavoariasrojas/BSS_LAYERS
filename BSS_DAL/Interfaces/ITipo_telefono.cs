using System.Collections.Generic;
using BSS_DATA;

namespace DAL.Interfaces
{
    public interface ITipo_telefono
    {
        List<Tipo_telefono> ListarTipoTelefonos();
        Tipo_telefono BuscarTipoTelefono(int tt_codigo);
        void InsertarTipoTelefono(Tipo_telefono tipo_telefono);
        void ActualizarTipoTelefono(Tipo_telefono tipo_telefono);
        void EliminarTipoTelefono(int tt_codigo);
    }
}
