using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
   public static class PersonaDAO
   {
        #region Atributos

        private static SqlCommand command;
        private static SqlConnection connection;
        private static string cadenaConexion = @"Data Source=.\SQLEXPRESS; Initial Catalog=EjerciciosUTN;Integrated Security=True";

        #endregion

        #region Constructores
        static PersonaDAO()
        {
            command = new SqlCommand();
            connection = new SqlConnection();
        }

        #endregion

        #region Métodos
        public static bool Insertar(Persona persona)
        {
            bool retorno = false;

            try
            {
                command.Parameters.Clear();
                connection.Open();
                command.Connection = connection;
                command.CommandType = CommandType.Text;
                command.CommandText = "INSERT INTO Clientes_Facturacion ([codigoCliente]," + "[facturacionTotal])" + " VALUES (@codCliente, @facturacion))";

                command.Parameters.AddWithValue("codCliente", persona.CodigoPersona);
                command.Parameters.AddWithValue("@facturacion", persona.CodigoPersona);
                command.ExecuteNonQuery();
                retorno = true;
            }
            catch (Exception e)
            {

                throw e;
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                {
                
                    connection.Close();

                }
            }
            return retorno;
        }

        #endregion


   }
}
