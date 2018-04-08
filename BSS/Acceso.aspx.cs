using BSS_BLL.Interfaces;
using BSS_BLL.Metodos;
using System;
using System.Collections;
using System.Collections.Generic;

namespace BSS
{
    public partial class Acceso : System.Web.UI.Page
    {
        public ILogin login;

        public Acceso() {
            login = new MLogin();
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            //Session.Abandon();
            Session.Clear();
            //Session["nombre"] = null;
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            var acceso = login.ValidarUsuario(txtUsuario.Text, txtClave.Text);
            if (acceso != null)
            {
                Session["usuario"] = acceso.su_usuario;
                Session["nombre"] = acceso.su_nombre_completo;
                Response.Redirect("Principal.aspx");
            }
            else
            {
                aviso.Visible = true;
            }
        }
    }
}