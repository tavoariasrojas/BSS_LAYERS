namespace BSS_BLL.Metodos
{
    public class MConnection
    {
        public DAL.Interfaces.ISeg_usuario login;

        public MConnection()
        {
           login = new DAL.Metodos.MSeg_usuario();
        }
    }
}
