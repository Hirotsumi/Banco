using br.ucb.Biblioteca.DAO;
using br.ucb.Biblioteca.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace br.ucb.Biblioteca.Model
{
    public class CidadeModel
    {
        private CidadeDAO dao;

        public CidadeModel()
        {
            if (dao == null)
                dao = new CidadeDAO();
        }

        public DataSet buscarCidadesPorEstado(EstadoDTO dto)
        {
            return dao.buscarCidadesPorEstado(dto);
        }
    }
}
