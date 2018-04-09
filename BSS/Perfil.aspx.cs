using BSS_DATA;
using DAL.Interfaces;
using DAL.Metodos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BSS
{
    public partial class Perfil : System.Web.UI.Page
    {
        public ISeg_usuario login;

        public Perfil()
        {
            login = new MSeg_usuario();
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            string nickname = Session["usuario"].ToString();
            Seg_usuario usuario = login.BuscarSegUsuario(nickname);
            lbNickname.Text = usuario.su_usuario.ToString();
            lbNombre.Text = usuario.su_nombre_completo.ToString();
        }

        protected void btnCambiar_Click(object sender, EventArgs e)
        {

        }

        protected void btnEditar_Click(object sender, EventArgs e)
        {

        }

        protected void btnAgregar_Click(object sender, EventArgs e)
        {

        }
    }
}