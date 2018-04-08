using System.Collections.Generic;
using BSS_DATA;
using DAL.Interfaces;
using ServiceStack.OrmLite;
using System.Linq;

namespace DAL.Metodos
{
    public class MForma_pago_salario : MConnection, IForma_pago_salario
    {
        public void ActualizarFormaPagoSalario(Forma_pago_salario forma_pago_salario)
        {
            _db.Update(forma_pago_salario);
        }

        public Forma_pago_salario BuscarFormaPagoSalario(int fps_salario)
        {
            return _db.Select<Forma_pago_salario>(x => x.fps_salario == fps_salario).FirstOrDefault();
        }

        public void EliminarFormaPagoSalario(int fps_salario)
        {
            _db.Delete<Forma_pago_salario>(x => x.fps_salario == fps_salario);
        }

        public void InsertarFormaPagoSalario(Forma_pago_salario forma_pago_salario)
        {
            _db.Insert(forma_pago_salario);
        }

        public List<Forma_pago_salario> ListarFormaPagoSalario()
        {
            return _db.Select<Forma_pago_salario>();
        }
    }
}
