using br.ucb.Biblioteca.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace br.ucb.Biblioteca.Model
{
    public class EstadoModel
    {
        private EstadoDAO dao;

        public EstadoModel()
        {
            if (dao == null)
                dao = new EstadoDAO();
        }

        public DataSet buscarEstados()
        {
            return dao.buscarEstados();
        }
    }
}
