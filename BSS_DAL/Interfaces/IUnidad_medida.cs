using System.Collections.Generic;
using BSS_DATA;

namespace DAL.Interfaces
{
    public interface IUnidad_medida
    {
        List<Unidad_medida> ListarUnidadMedidas();
        Unidad_medida BuscarUnidad(long prod_codigo);
    }
}
