using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace br.ucb.Biblioteca.DAO
{
    internal class AlunoDAO
    {
        internal DataSet listarAlunos()
        {
            using(SqlConnection conn = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["BDTalp"].ToString()))
            {
                try
                {
                    conn.Open();
                    var sql = "SELECT Id, Nome FROM Aluno ORDER BY Nome";
                    SqlCommand command = new SqlCommand(sql,conn);
                    command.CommandType = CommandType.Text;

                    DataSet dtSet = new DataSet();
                    SqlDataAdapter dtAdapter = new SqlDataAdapter(command);

                    dtAdapter.Fill(dtSet);
                    return dtSet;
                }catch(Exception e) {
                    throw e;
                }finally{
                    conn.Close();
                }
            }          
        }

    }
}
