using StarCapModel;
using StarCapModel.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace StarCapWeb
{
    public partial class VerBebidas : System.Web.UI.Page
    {
        private IBebidasDAL bebidasDAL =  new BebidasDALObjetos();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                cargarGrilla();
            }
        }

        private void cargarGrilla()
        {
            List<Bebida> bebidas = bebidasDAL.ObtenerBebidas();
            this.grillasBebidas.DataSource = bebidas;
            this.grillasBebidas.DataBind();
        }


        protected void grillaBebidas_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "eliminar")
            {

                string codigo = Convert.ToString(e.CommandArgument);
                bebidasDAL.eliminar(codigo);
                cargarGrilla();
            }
        }
    }
}