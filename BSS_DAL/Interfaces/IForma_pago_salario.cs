using System.Collections.Generic;
using BSS_DATA;

namespace DAL.Interfaces
{
    public interface IForma_pago_salario
    {
        List<Forma_pago_salario> ListarFormaPagoSalario();
        Forma_pago_salario BuscarFormaPagoSalario(int fps_salario);
        void InsertarFormaPagoSalario(Forma_pago_salario forma_pago_salario);
        void ActualizarFormaPagoSalario(Forma_pago_salario forma_pago_salario);
        void EliminarFormaPagoSalario(int fps_salario);
    }
}
