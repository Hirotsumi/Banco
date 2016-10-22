using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using br.ucb.Biblioteca.DTO;

namespace br.ucb.Biblioteca.DAO
{
    internal class CidadeDAO
    {
        internal DataSet buscarCidadesPorEstado(EstadoDTO dto) {
            using (SqlConnection conn = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["BDTalp"].ToString()))
            {
                try
                {
                    conn.Open();
                    var sql = "SELECT Id, idEstado, Nome FROM Cidade WHERE idEstado = @idEstado ORDER BY Nome";
                    SqlCommand command = new SqlCommand(sql, conn);
                    command.CommandType = CommandType.Text;

                    command.Parameters.AddWithValue("@idEstado",dto.Id);

                    DataSet dtSet = new DataSet();
                    SqlDataAdapter dtAdapter = new SqlDataAdapter(command);

                    dtAdapter.Fill(dtSet);
                    return dtSet;
                }
                catch (Exception e)
                {
                    throw e;
                }
                finally
                {
                    conn.Close();
                }
            }       
        }
    }
}
