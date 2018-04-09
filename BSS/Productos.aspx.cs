using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BSS_DATA;
using DAL.Interfaces;
using DAL.Metodos;

namespace BSS
{
    public partial class Productos : System.Web.UI.Page
    { 

        public IProducto prod;
        public Productos()
        {
            prod = new MProducto();
        }
        protected void Page_Load(object sender, EventArgs e)
        {

            List<VerProducto> listaProductos = prod.VerProductos();
            gvProductos.DataSource = listaProductos;
            gvProductos.DataBind();


        }
    }
}