using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class SQLConnector : IArchivos
    {
        public bool Guardar()
        {
            SqlConnection sqlConnection = new SqlConnection("Data Source=localhost; Initial Catalog=20201203-sp; Integrated Security = True");
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandType = System.Data.CommandType.Text;
            sqlCommand.Connection = sqlConnection;

            try
            {
                string query = $"INSERT INTO log (entrada, alumno) VALUES (@entrada, @alumno)";
                sqlCommand.Parameters.Clear();
                sqlCommand.Parameters.AddWithValue("@alumno", "Denise");
                sqlCommand.Parameters.AddWithValue("@entrada", $"Se disfrutó el gol del siglo a las {DateTime.Now} hs");
                sqlCommand.CommandText = query;
                sqlConnection.Open();
                sqlCommand.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                sqlConnection.Close();
            }

        }

        public string Leer()
        {
            throw new NotImplementedException();
        }
    }
}
