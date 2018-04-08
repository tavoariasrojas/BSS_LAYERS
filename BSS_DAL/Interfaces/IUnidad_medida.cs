using System.Collections.Generic;
using BSS_DATA;

namespace DAL.Interfaces
{
    public interface IUnidad_medida
    {
        List<Unidad_medida> ListarUnidadMedidas();
        Unidad_medida BuscarUnidadMedida(int um_codigo);
        void InsertarUnidadMedida(Unidad_medida unidad_medida);
        void ActualizarUnidadMedida(Unidad_medida unidad_medida);
        void EliminarTUnidadMedida(int um_codigo);
    }
}
