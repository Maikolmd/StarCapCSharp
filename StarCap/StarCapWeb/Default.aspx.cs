using StarCapModel;
using StarCapModel.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

//back end de la pag
namespace StarCapWeb
{
    public partial class Default : System.Web.UI.Page
    {
        private IClientesDAL clientesDAL = new ClientesDALObjetos();
        private IBebidasDAL bebidasDAL = new BebidasDALObjetos();
        protected void Page_Load(object sender, EventArgs e)
        {
            //se carga lista de dropdownmenu pq es carga inicial
            if (!IsPostBack)
            {
                List<Bebida> bebidas = bebidasDAL.ObtenerBebidas();
                this.bebidaDdl.DataSource = bebidas;
                // datatextfield corresponde al nombre de la property de la clase, no el nombre del atributo
                this.bebidaDdl.DataTextField = "Nombre";
                this.bebidaDdl.DataValueField = "Codigo";
                this.bebidaDdl.DataBind();
            }
        }
        // metodos son protected debido a que esta clase hereda de system.page
        protected void agregarBtn_Click(object sender, EventArgs e)
        {
            //TODO: validar formulario (componentes de validacion)
            //1. Obtener los datos del formulario
            string nombre = this.nombreTxt.Text.Trim();
            string rut = this.rutTxt.Text.Trim();
            //esto obtiene el valor del DropDown
            string bebidaValor = this.bebidaDdl.SelectedValue;
            //esto obtiene el texto
            string bebidaTexto = this.bebidaDdl.SelectedItem.Text;
            int nivel = Convert.ToInt32(this.nivelRbl.SelectedItem.Value);

            //TODO: Mejorar esta solución flaite, cuando veamos el admin de bebidas
            List<Bebida> bebidas = bebidasDAL.ObtenerBebidas();
            Bebida bebida = bebidas.Find(b => b.Codigo == this.bebidaDdl.SelectedItem.Value);
            //2. Construir el objeto de tipo Cliente
            Cliente cliente = new Cliente()
            {
                Nombre = nombre,
                Rut= rut,
                Nivel=nivel,
                BebidaFavorita = bebida
            };
            //3. Llamar al DAL
            clientesDAL.Agregar(cliente);
            //4. Mostrar mensaje de éxito
            this.mensajesLbl.Text = "Cliente Ingresado";
            Response.Redirect("VerClientes.aspx");
        }
    }
}