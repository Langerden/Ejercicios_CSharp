using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class PersonaDAO
    {
        static SqlConnection sqlConnection;
        static SqlCommand sqlCommand;

        static PersonaDAO()
        {
            sqlConnection = new SqlConnection("Data Source=localhost; Initial Catalog=Ejercicio61; Integrated Security = True");
            sqlCommand = new SqlCommand();
            sqlCommand.CommandType = System.Data.CommandType.Text;
            sqlCommand.Connection = sqlConnection;
        }

        public static bool Guardar(Persona persona)
        {
            string query = $"INSERT INTO dbo.Ejercicio60 (Nombre, Apellido, Booleano) " +
                 $"VALUES (@nombre,@apellido,@bool)";
            sqlCommand.Parameters.Clear();
            sqlCommand.Parameters.AddWithValue("@nombre", persona.Nombre);
            sqlCommand.Parameters.AddWithValue("@apellido", persona.Apellido);
            sqlCommand.Parameters.AddWithValue("@bool", persona.EsAdmin);
            return EjecutarQuery(query);
        }        
        
        public static bool Borrar(Persona persona)
        {
            string query = $"DELETE FROM Ejercicio60 WHERE ID=@id;";
            sqlCommand.Parameters.Clear();
            sqlCommand.Parameters.AddWithValue("@id", persona.Id);
            return EjecutarQuery(query);
        }

        public static List<Persona> Leer()
        {
            List<Persona> auxList = new List<Persona>();
            string sql = "SELECT * FROM Ejercicio60";

            try
            {
                sqlCommand.CommandText = sql;
                sqlConnection.Open();

                SqlDataReader reader = sqlCommand.ExecuteReader();

                while (reader.Read())
                {
                    auxList.Add(new Persona(
                        int.Parse(reader["ID"].ToString()),
                        reader["Nombre"].ToString(),
                        reader["Apellido"].ToString(),
                        bool.Parse(reader["Booleano"].ToString())));
                }
            }
            catch (Exception ex)
            {
                throw ex;
            } finally {
                sqlConnection.Close();
            }
            return auxList;
        }    
        
        public static bool LeerPorID(Persona persona)
        {
            string sql = $"SELECT * FROM Ejercicio60 WHERE id= @id";
            sqlCommand.Parameters.Clear();
            sqlCommand.Parameters.AddWithValue("@id", persona.Id);
            return EjecutarQuery(sql);
        }        
        
        public static bool Modificar(Persona persona)
        {
            try
            {
                string sql = $"UPDATE dbo.Ejercicio60 SET Nombre=@nombre, Apellido=@apellido,Booleano=@booleano WHERE ID = @id; ";
                sqlCommand.Parameters.Clear();
                sqlCommand.Parameters.AddWithValue("@nombre", persona.Nombre);
                sqlCommand.Parameters.AddWithValue("@apellido", persona.Apellido);
                sqlCommand.Parameters.AddWithValue("@booleano", persona.EsAdmin);
                sqlCommand.Parameters.AddWithValue("@id", persona.Id);                
                return EjecutarQuery(sql);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }        
        
        public static bool Limpiar(Persona persona)
        {
            string sql = "TRUNCATE TABLE Ejercicio60;";
            return EjecutarQuery(sql);
        }


        private static bool EjecutarQuery(string query)
        {
            bool todoOk = false;
            try
            {
                sqlCommand.CommandText = query;
                sqlConnection.Open();
                sqlCommand.ExecuteNonQuery();
                todoOk = true;
            }
            catch (Exception ex)
            {
                throw ex;
            } finally {
                sqlConnection.Close();
            }
            return todoOk;
        }
    }
}
