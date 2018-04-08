using BSS_DATA;

namespace BSS_BLL.Interfaces
{
    public interface ILogin
    {
        Seg_usuario ValidarUsuario(string usuario, string clave);
    }
}
