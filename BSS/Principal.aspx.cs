﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BSS
{
    public partial class Principal : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if (!IsPostBack)
                {
                    if (Session["nombre"] == null)
                    {
                        Response.Redirect("Acceso.aspx");
                    }
                }
                else
                {
                    Response.Redirect("Acceso.aspx");
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            
            
        }
    }
}