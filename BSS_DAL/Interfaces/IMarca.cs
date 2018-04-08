using System.Collections.Generic;
using BSS_DATA;

namespace DAL.Interfaces
{
    public interface IMarca
    {
        List<Marca> ListarMarcas();
        Marca BuscarMarca(int ma_codigo);
        void InsertarMarca(Marca marca);
        void ActualizarMarca(Marca marca);
        void EliminarMarca(int ma_codigo);
    }
}
