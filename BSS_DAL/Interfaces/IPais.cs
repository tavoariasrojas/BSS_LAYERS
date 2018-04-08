using System.Collections.Generic;
using BSS_DATA;

namespace DAL.Interfaces
{
    public interface IPais
    {
        List<Pais> ListarPaises();
        Pais BuscarPais(string pa_codigo);
        void InsertarPais(Pais pais);
        void ActualizarPais(Pais pais);
        void EliminarPais(string pa_codigo);
    }
}
