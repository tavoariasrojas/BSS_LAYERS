using System;
using BSS_BLL.Interfaces;
using BSS_DATA;

namespace BSS_BLL.Metodos
{
    public class MLogin : MConnection, ILogin
    {
        public Seg_usuario ValidarUsuario(string usuario, string clave)
        {
            return login.BuscarSegUsuario(usuario, clave);
        }

        public Seg_usuario BuscarSegUsuario(string su_usuario)
        {
            return login.BuscarSegUsuario(su_usuario);
        }
    }
}
