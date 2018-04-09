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
            try
            {
                if (!IsCrossPagePostBack)
                {
                    if (Session["nombre"] == null)
                    {
                        Session.Clear();
                    }
                    else
                    {
                        Response.Redirect("Accesso.asp");
                    }
                }
                Session.Clear();
            }
            catch (Exception)
            {

                throw;
            }
            //Session.Abandon();
            
            //Session["nombre"] = null;
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            try
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
            catch (Exception ex)
            {
                throw ex;
            }
            
        }
    }
}