using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using br.ucb.Biblioteca.DTO;
using br.ucb.Biblioteca.DAO;
using System.Data.Sql;
using System.Data;


namespace br.ucb.Biblioteca.Model
{
    public class DisciplinaModel
    {
        private DisciplinaDAO _disciplinaDAO;

        public DisciplinaModel()
        {
            if (_disciplinaDAO == null)
                _disciplinaDAO = new DisciplinaDAO();
        }

        public Boolean inserirDisciplina(DisciplinaDTO dto) 
        {
            return _disciplinaDAO.inserirDisciplina(dto);
        }

        public DataSet listarDisciplinas()
        {
            return _disciplinaDAO.listarDisciplina();
        }

        public Boolean atualizarDisciplina(DisciplinaDTO dto)
        {
            return _disciplinaDAO.alterarDisciplina(dto);
        }

        public Boolean deletarDisciplina(DisciplinaDTO dto)
        {
            return _disciplinaDAO.excluirDisciplina(dto);
        }
    }
}
