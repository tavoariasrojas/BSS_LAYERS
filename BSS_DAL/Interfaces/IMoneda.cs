using System.Collections.Generic;
using BSS_DATA;

namespace DAL.Interfaces
{
    public interface IMoneda
    {
        List<Moneda> ListarMonedas();
        Moneda BuscarMoneda(string mon_codigo);
        void InsertarMoneda(Moneda moneda);
        void ActualizarMoneda(Moneda moneda);
        void EliminarMoneda(string mon_codigo);
    }
}
