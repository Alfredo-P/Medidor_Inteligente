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
    public partial class MostrarMedidor : System.Web.UI.Page
    {
        private IMedidorDAL medidorDAL = new MedidorDALDB();
        private void cargarGrilla()
        {
            List<medidor> medidor;
            medidor = this.medidorDAL.ObtenerMedidor();
            this.CargarGrilla(medidor);
        }
        private void CargarGrilla(List<medidor> medidor)
        {
            this.grillaMedidor.DataSource = medidor;
            this.grillaMedidor.DataBind();


        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                this.CargarGrilla(this.medidorDAL.ObtenerMedidor());
            }
        }
        protected void grillaMedidor_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "eliminar")
            {
                int id = Convert.ToInt32(e.CommandArgument);
                this.medidorDAL.eliminarMedidor(id);
                this.cargarGrilla();
            }
        }
    }
}