using System.Collections.Generic;
using BSS_DATA;

namespace DAL.Interfaces
{
    public interface ITipo_prod_serv
    {
        List<Tipo_prod_serv> ListarTipoProdServ();
        Tipo_prod_serv BuscarTipoProdServ(int tps_codigo);
        void InsertarTipoProdServ(Tipo_prod_serv tipo_prod_serv);
        void ActualizarTipoProdServ(Tipo_prod_serv tipo_prod_serv);
        void EliminarTipoProdServ(int tps_codigo);
    }
}
