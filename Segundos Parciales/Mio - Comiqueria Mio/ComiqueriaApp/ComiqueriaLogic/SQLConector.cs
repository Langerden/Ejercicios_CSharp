using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComiqueriaLogic
{
    public delegate void MiDelegado(AccionesDB accionesDB);
    public static class SQLConector
    {
        static SqlConnection sqlConnection;
        static SqlCommand sqlCommand;
        public static event MiDelegado MiEvento;

        static SQLConector()
        {
            sqlConnection = new SqlConnection("Data Source=localhost; Initial Catalog=Comiqueria; Integrated Security = True");
            sqlCommand = new SqlCommand();
            sqlCommand.CommandType = System.Data.CommandType.Text;
            sqlCommand.Connection = sqlConnection;            

        }

        public static bool Insert(string desc, double precio, int stock)
        {
            try
            {
                
                string query = $"INSERT INTO Productos (Descripcion, Precio, Stock) " +
                     $"VALUES (@descripcion,@precio,@stock)";
                sqlCommand.CommandText = query;
                sqlCommand.Parameters.Clear();
                sqlCommand.Parameters.AddWithValue("@descripcion", desc);
                sqlCommand.Parameters.AddWithValue("@precio",precio);
                sqlCommand.Parameters.AddWithValue("@stock", stock);
                sqlConnection.Open();
                sqlCommand.ExecuteNonQuery();
                MiEvento.Invoke(AccionesDB.Insert);
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            } finally
            {
                sqlConnection.Close();
            }
        }

        public static bool Modificar(Producto producto)
        {
            try
            {
                string query = $"UPDATE Productos SET Descripcion=@descripcion, Precio=@precio, Stock=@stock WHERE Codigo=@codigo; ";
                sqlCommand.CommandText = query;
                sqlCommand.Parameters.Clear();
                sqlCommand.Parameters.AddWithValue("@descripcion", producto.Descripcion);
                sqlCommand.Parameters.AddWithValue("@precio", producto.Precio);
                sqlCommand.Parameters.AddWithValue("@stock", producto.Stock);
                sqlCommand.Parameters.AddWithValue("@codigo", producto.Codigo);
                sqlConnection.Open();
                sqlCommand.ExecuteNonQuery();
                MiEvento.Invoke(AccionesDB.Update);
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

        public static bool Eliminar(int codigo)
        {
            try
            {
                string query = $"DELETE FROM Productos WHERE Codigo=@codigo; ";
                sqlCommand.CommandText = query;
                sqlCommand.Parameters.Clear();
                sqlCommand.Parameters.AddWithValue("@codigo", codigo);
                sqlConnection.Open();
                sqlCommand.ExecuteNonQuery();
                MiEvento.Invoke(AccionesDB.Delete);
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

        public static List<Producto> Leer() 
        {
            List<Producto> auxList = new List<Producto>();

            try
            {
                string sql = $"SELECT * FROM Productos";
                sqlCommand.CommandText = sql;
                sqlConnection.Open();

                SqlDataReader reader = sqlCommand.ExecuteReader();

                while (reader.Read())
                {
                    int codigo = Convert.ToInt32(reader["Codigo"]);
                    string descripcion = reader["Descripcion"].ToString();
                    double precio = Convert.ToDouble(reader["precio"]);
                    int stock = Convert.ToInt32(reader["Stock"]);
                    Producto producto = new Producto(codigo, descripcion, stock, precio);
                    auxList.Add(producto);                      
                }
            }
            catch (Exception ex)
            {
                throw new ComiqueriaException("Error al tratar de obtener los productos de la base de datos", ex);
            }
            finally
            {
                sqlConnection.Close();
            }
            return auxList;
        }
    }
}
