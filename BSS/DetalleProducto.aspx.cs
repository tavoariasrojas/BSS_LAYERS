using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using BSS_DATA;
using DAL.Interfaces;
using DAL.Metodos;


namespace BSS
{
    
    public partial class DetalleProducto : System.Web.UI.Page
    {
        public IProducto prod;
        public ITipo_producto ti_prod;
        public IMoneda mo;
        public IMarca ma;
        public IUnidad_medida um;

        public DetalleProducto()
        {
            prod = new MProducto();
            ti_prod = new MTipo_producto();
            mo = new MMoneda();
            ma = new MMarca();
            um = new MUnidad_medida();
        }

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                Producto producto = prod.BuscarProducto(Convert.ToInt64(txtCodProducto.Text));
                Tipo_producto tipo_producto = ti_prod.BuscarTipo_Produc(Convert.ToInt32(producto.prod_tp_codigo));
                Moneda moneda = mo.BuscarMoneda(Convert.ToString(producto.prod_mon_codigo));
                Marca marca = ma.BuscarMarca(Convert.ToInt32(producto.prod_ma_codigo));
                Unidad_medida unidad_medida = um.BuscarUnidad(Convert.ToInt32(producto.prod_um_codigo));


                if (producto != null)
                {
                    divMantenimiento.Visible = true;
                    txtCodigo.Text = producto.prod_codigo.ToString();
                    txtDescuento.Text = producto.prod_desc.ToString();
                    txtDetalle.Text = producto.prod_detalle;
                    txtMarcaCodigo.Text = marca.ma_nombre;
                    txtMedida.Text = producto.prod_medida.ToString();
                    txtMonedaCodigo.Text = moneda.mon_nombre;
                    txtPrecio.Text = producto.prod_precio.ToString();
                    txtTipoCodigo.Text = tipo_producto.tp_descripcion;
                    txtUnidadMedida.Text = unidad_medida.um_descripcion;
                    if(producto.prod_es_gravado == true)
                    {
                        rbGravado.Checked = true;
                    }
                }

            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}