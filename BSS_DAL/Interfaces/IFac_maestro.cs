using System.Collections.Generic;
using BSS_DATA;

namespace DAL.Interfaces
{
    public interface IFac_maestro
    {
        List<Fac_maestro> ListarFacMaestro();
        Fac_maestro BuscarFacMaestro(long fma_sec_factura);
        void InsertarFacMaestro(Fac_maestro fac_maestro);
        void ActualizarFacMaestro(Fac_maestro fac_maestro);
        void EliminarFacMaestro(long fma_sec_factura);
    }
}
