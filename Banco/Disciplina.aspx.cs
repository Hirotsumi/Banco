using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using br.ucb.Biblioteca.DTO;
using br.ucb.Biblioteca.Model;

namespace Banco
{
    public partial class Disciplina : System.Web.UI.Page
    {
        public DisciplinaModel _model;
        public string msg;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (this._model == null)
                this._model = new DisciplinaModel();
            if (!Page.IsPostBack)
                preencherGrid();
        }

        protected void btnInserir_Click(object sender, EventArgs e)
        {
            DisciplinaDTO dto = new DisciplinaDTO();
            dto.nome = txtNome.Text.ToString();
            
            if (_model.inserirDisciplina(dto))
                msg = "Dados inseridos com sucesso!";
            else
                msg = "Erro ao inserir dados.";
            Response.Redirect("Disciplina.aspx");
        }

        protected void preencherGrid()
        {
            gridDisciplina.DataSource = _model.listarDisciplinas();
            gridDisciplina.DataBind();
        }

        protected void gridDisciplina_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            gridDisciplina.PageIndex = e.NewPageIndex;
            preencherGrid();
        }

        protected void gridDisciplina_RowEditing(object sender, GridViewEditEventArgs e)
        {
            gridDisciplina.EditIndex = e.NewEditIndex;
            preencherGrid();
        }

        protected void gridDisciplina_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            DisciplinaDTO dto = new DisciplinaDTO();

            dto.id = Convert.ToInt32(gridDisciplina.DataKeys[e.RowIndex].Values[0]);
            _model.deletarDisciplina(dto);
            preencherGrid();
        }

        protected void gridDisciplina_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            gridDisciplina.EditIndex = -1;
            preencherGrid();
        }

        protected void gridDisciplina_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            GridViewRow row = gridDisciplina.Rows[e.RowIndex];
            DisciplinaDTO dto = new DisciplinaDTO();
            
            dto.id = Convert.ToInt32(gridDisciplina.DataKeys[e.RowIndex].Value);

            dto.nome = e.NewValues["nome"].ToString();

            _model.atualizarDisciplina(dto);
            gridDisciplina.EditIndex = -1;
            preencherGrid();
            
        }


    }
}