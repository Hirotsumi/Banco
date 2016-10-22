using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using br.ucb.Biblioteca.Model;

namespace Banco
{
    public partial class Alunos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            preencherGrid();
        }

        private void preencherGrid()
        {
            AlunoModel model = new AlunoModel();
            gridAluno.DataSource = model.getAlunos();
            gridAluno.DataBind();
        }
    }
}