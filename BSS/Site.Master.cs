using System;
using System.Web.UI;

namespace BSS
{
    public partial class SiteMaster : MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["nombre"] != null)
            {
                nombre.Text = " "+(string)Session["nombre"];
            }
            else
            {
                Response.Redirect("Acceso.aspx");
            }
        }
    }
}