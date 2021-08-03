using MedidorModel;
using MedidorModel.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Medidor_Inteligente
{
    public partial class AgregarMedidor : System.Web.UI.Page
    {
        private IMedidorDAL medidorDAL = new MedidorDALDB();
        private IUsuarioDAL usuarioDAL = new UsuarioDALDB();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
            }

        }
       

        protected void ingresarBtn_Click1(object sender, EventArgs e)
        {
            medidor m = new medidor();
            m.ingreso = this.nombreTxt.Text.Trim();
            m.fecha_medidor = Convert.ToDateTime(this.fechaTxt.Text.Trim());
            m.valor_consumo = this.consumoTxt.Text.Trim();
            this.medidorDAL.agregarMedidor(m);
            Response.Redirect("MostrarMedidor.aspx");
        }
    }
}