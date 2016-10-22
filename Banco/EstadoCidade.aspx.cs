using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using br.ucb.Biblioteca.Model;
using br.ucb.Biblioteca.DTO;

namespace Banco
{
    public partial class EstadoCidade : System.Web.UI.Page
    {
        EstadoModel estadoModel;
        CidadeModel cidadeModel;
        protected void Page_Load(object sender, EventArgs e)
        {
            estadoModel = new EstadoModel();
            cidadeModel = new CidadeModel();
            if (!Page.IsPostBack)
            {
                buscarEstados();
            }
        }

        private void buscarEstados()
        {
            
                drpEstado.DataSource = this.estadoModel.buscarEstados();

                drpEstado.DataTextField = "Nome";
                drpEstado.DataValueField = "Id";

                drpEstado.DataBind();

                drpEstado.Items.Insert(0,new ListItem("Selecione",""));
            
            
        }

        protected void drpEstado_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (drpEstado.SelectedItem.Value.ToString().Equals("")) {
                lblCidade.Visible = false;
                drpCidade.Visible = false;
            }else{
                EstadoDTO dto = new EstadoDTO();
                dto.Id = int.Parse(drpEstado.SelectedValue.ToString());
                buscarCidades(dto);
            }
                
        }

        private void buscarCidades(EstadoDTO dto)
        {
            drpCidade.DataSource = this.cidadeModel.buscarCidadesPorEstado(dto);

            drpCidade.DataTextField = "Nome";
            drpCidade.DataValueField = "Id";

            drpCidade.DataBind();

            drpCidade.Visible = true;
            lblCidade.Visible = true;
        }
    }
}