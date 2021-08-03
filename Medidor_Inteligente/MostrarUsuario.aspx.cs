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
    public partial class MostrarUsuario : System.Web.UI.Page
    {
        private IUsuarioDAL usuarioDAL = new UsuarioDALDB();
        private void cargarGrilla()
        {
            List<usuario> usuario;
            usuario = this.usuarioDAL.ObtenerUsuario();
            this.CargarGrilla(usuario);
        }
        private void CargarGrilla(List<usuario> usuario)
        {
            this.grillaUsuario.DataSource = usuario;
            this.grillaUsuario.DataBind();
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                this.CargarGrilla(this.usuarioDAL.ObtenerUsuario());

            }
        }
        protected void grillaUsuario_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "eliminar")
            {
                int id = Convert.ToInt32(e.CommandArgument);
                this.usuarioDAL.eliminarUsuario(id);
                this.cargarGrilla();
            }
        }

    }
}