using System.Collections.Generic;
using BSS_DATA;

namespace DAL.Interfaces
{
    public interface ISeg_usuario
    {
        List<Seg_usuario> ListarSegUsuarios();
        Seg_usuario BuscarSegUsuario(string su_usuario);
        Seg_usuario BuscarSegUsuario(string su_usuario, string clave);
        void InsertarSegUsuario(Seg_usuario seg_usuario);
        void ActualizarSegUsuario(Seg_usuario seg_usuario);
        void EliminarSegUsuario(string su_usuario);
    }
}
