using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Dao<T> : IArchivos<Votacion>
    {
        public bool Guardar(string tabla, Votacion objeto)
        {
            SqlConnection sqlConnection = new SqlConnection("Data Source=localhost; Initial Catalog=votacion-sp-2018; Integrated Security = True");
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandType = System.Data.CommandType.Text;
            sqlCommand.Connection = sqlConnection;
            bool seGuardo = false;

            try
            {
                string query = $"INSERT INTO {tabla} (nombreLey, afirmativos, negativos, abstenciones, nombreAlumno) " +
                        $"VALUES (@nombreLey,@afirmativos,@negativos,@abstenciones,@nombreAlumno)";
                sqlCommand.Parameters.Clear();
                sqlCommand.Parameters.AddWithValue("@nombreLey", objeto.NombreLey);
                sqlCommand.Parameters.AddWithValue("@afirmativos", objeto.ContadorAfirmativo);
                sqlCommand.Parameters.AddWithValue("@negativos", objeto.ContadorNegativo);
                sqlCommand.Parameters.AddWithValue("@abstenciones", objeto.ContadorAbstencion);
                sqlCommand.Parameters.AddWithValue("@nombreAlumno", "Denise");

                sqlCommand.CommandText = query;
                sqlConnection.Open();
                sqlCommand.ExecuteNonQuery();
                seGuardo = true;
                return seGuardo;
            }
            catch (Exception ex)
            {
                throw ex;
            } finally {
                sqlConnection.Close();
            }  
        }

        public Votacion Leer(string rutaArchivo)
        {
            throw new NotImplementedException();
        }
    }
}
