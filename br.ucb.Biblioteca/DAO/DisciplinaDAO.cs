using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using br.ucb.Biblioteca.DTO;
using System.Data.SqlClient;
using System.Data.Sql;
using System.Data;


namespace br.ucb.Biblioteca.DAO
{
    internal class DisciplinaDAO
    {
        internal Boolean inserirDisciplina(DisciplinaDTO dto) 
        {
            using(SqlConnection conn = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["Casa"].ToString()))
            {
                try
                {
                    conn.Open();

                    var sql = "INSERT INTO Disciplina (Nome) VALUES (@nome)";
                    SqlCommand command = new SqlCommand(sql,conn);
                    command.CommandType = CommandType.Text;

                    command.Parameters.AddWithValue("@nome",dto.nome);
                    command.ExecuteNonQuery();

                    return true;
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

        internal DataSet listarDisciplina()
        {
            using (SqlConnection conn = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["Casa"].ToString()))
            {
                try
                {
                    conn.Open();

                    var sql = "SELECT id, nome FROM Disciplina ORDER BY nome";
                    SqlCommand command = new SqlCommand(sql, conn);
                    command.CommandType = CommandType.Text;

                    DataSet dtSet = new DataSet();
                    SqlDataAdapter adapter = new SqlDataAdapter(command);

                    adapter.Fill(dtSet);

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
        internal Boolean excluirDisciplina(DisciplinaDTO dto)
        {
            using (SqlConnection conn = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["Casa"].ToString()))
            {
                try
                {
                    conn.Open();

                    var sql = "DELETE FROM Disciplina WHERE id = @id";
                    SqlCommand command = new SqlCommand(sql, conn);
                    command.CommandType = CommandType.Text;

                    command.Parameters.AddWithValue("@id", dto.id);
                    command.ExecuteNonQuery();

                    return true;
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
        internal Boolean alterarDisciplina(DisciplinaDTO dto)
        {
            using (SqlConnection conn = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["Casa"].ToString()))
            {
                try
                {
                    conn.Open();

                    var sql = "UPDATE Disciplina SET nome = @nome WHERE id = @id";
                    SqlCommand command = new SqlCommand(sql, conn);
                    command.CommandType = CommandType.Text;

                    command.Parameters.AddWithValue("@nome", dto.nome);
                    command.Parameters.AddWithValue("@id", dto.id);
                    command.ExecuteNonQuery();

                    return true;
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
