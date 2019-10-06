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
    public partial class AgregarBebidas : System.Web.UI.Page
    {
        private IClientesDAL clientesDAL = new ClientesDALObjetos();
        private IBebidasDAL bebidasDAL = new BebidasDALObjetos();
        protected void Page_Load(object sender, EventArgs e)
        {
            List<Bebida> bebidas = bebidasDAL.ObtenerBebidas();
        }

        protected void AgregarBebidaBtn_Click(object sender, EventArgs e)
        {
            string nombre = this.NomBebidaTxt.Text.Trim();
            string codigo = this.CodigoBebidaTxt.Text.Trim();

            Bebida bebida = new Bebida()
            {
                Nombre = nombre,
                Codigo = codigo,
            };

            bebidasDAL.agregarBebidas(bebida);
            this.mensajesLbl.Text = "Cliente Ingresado";
            Response.Redirect("VerBebidas.aspx");
        }
    }
}