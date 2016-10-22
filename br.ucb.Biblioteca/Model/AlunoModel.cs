using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using br.ucb.Biblioteca.DTO;
using br.ucb.Biblioteca.DAO;
using System.Data;

namespace br.ucb.Biblioteca.Model
{
    public class AlunoModel
    {
        private AlunoDAO _alunoDAO;

        public AlunoModel()
        {
            if (_alunoDAO == null)
                _alunoDAO = new AlunoDAO();
        }

        public DataSet getAlunos()
        {
            return _alunoDAO.listarAlunos();
        }
    }
}
