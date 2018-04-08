using System.Collections.Generic;
using BSS_DATA;


namespace DAL.Interfaces
{
    public interface IPuesto
    {
        List<Puesto> ListarProveedores();
        Puesto BuscarPuesto(int pue_codigo);
        void InsertarPuesto(Puesto puesto);
        void ActualizarPuesto(Puesto puesto);
        void EliminarPuesto(int pue_codigo);
    }
}
