using System.Collections.Generic;
using BSS_DATA;

namespace DAL.Interfaces
{
    public interface ITipoMovimiento
    {
        List<Tipo_movimiento> ListarTipoMovimiento();
        Tipo_movimiento BuscarTipoMovimiento(string tm_codigo);
        void InsertarTipoMovimiento(Tipo_movimiento tipo_movimiento);
        void ActualizarTipoMovimiento(Tipo_movimiento tipo_movimiento);
        void EliminarTipoMovimiento(string tm_codigo);
    }
}
