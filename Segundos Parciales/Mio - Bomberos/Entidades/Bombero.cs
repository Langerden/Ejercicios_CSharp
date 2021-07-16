using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace Entidades
{
    public delegate void FinDeSalida(int bomberoIndex);

    [Serializable]
    public class Bombero : IArchivos<string>, IArchivos<Bombero>
    {
        private string nombre;
        private List<Salidas> salidas;

        [field: NonSerialized]
        public event FinDeSalida MarcarFin;

        public Bombero()
        {

        }

        public Bombero(string nombre)
        {
            this.nombre = nombre;
            this.salidas = new List<Salidas>();
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public List<Salidas> Salidas { get => salidas; set => salidas = value; }

        public void AtenderSalida(object bomberoIndex)
        {
            Salidas salida = new Salidas();
            this.salidas.Add(salida);
            Thread.Sleep(3000);
            this.salidas[this.salidas.Count - 1].FinalizarSalida();
            this.MarcarFin((int)bomberoIndex);

            //salida.FinalizarSalida();
            ((IArchivos<string>)this).Guardar(nombre);            
        }

        public void Guardar(Bombero info)
        {
            string pathArchivo = $"{Environment.GetFolderPath(Environment.SpecialFolder.Desktop)}\\Binary.bin";
            try
            {
                using (FileStream fileStream = new FileStream(pathArchivo, FileMode.OpenOrCreate))
                {
                    BinaryFormatter formatter = new BinaryFormatter();
                    formatter.Serialize(fileStream, info);

                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public bool GuardarXml(Bombero datos)
        {
            bool retorno = false;
            string pathArchivo = $"{Environment.GetFolderPath(Environment.SpecialFolder.Desktop)}\\Serializer.xml";

            try
            {
                if (pathArchivo != null && (Directory.Exists(pathArchivo)))
                {
                    using (XmlTextWriter auxWriter = new XmlTextWriter(pathArchivo, Encoding.UTF8))
                    {
                        XmlSerializer nuevoXml = new XmlSerializer(typeof(Bombero));
                        nuevoXml.Serialize(auxWriter, datos);
                        retorno = true;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al querer Guardar el archivo: {pathArchivo}.", ex);
            }
            return retorno;
        }

        public Bombero Leer()
        {
            Bombero datos = new Bombero();
            string pathArchivo = $"{Environment.GetFolderPath(Environment.SpecialFolder.Desktop)}\\Binary.bin";

            if (pathArchivo != null)
            {
                using (FileStream fileStream = new FileStream(pathArchivo, FileMode.Open))
                {
                    BinaryFormatter formatter = new BinaryFormatter();
                    datos = (Bombero)formatter.Deserialize(fileStream);
                }
            }
            return datos;
        }

        void IArchivos<string>.Guardar(string info)
        {
            SqlConnection sqlConnection = new SqlConnection("Data Source=localhost; Initial Catalog=20201119-sp; Integrated Security = True");
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandType = System.Data.CommandType.Text;
            sqlCommand.Connection = sqlConnection;

            try
            {
                string query = $"INSERT INTO log (entrada, alumno) VALUES (@entrada, @alumno)";
                sqlCommand.Parameters.Clear();
                sqlCommand.Parameters.AddWithValue("@alumno", "Denise");
                sqlCommand.Parameters.AddWithValue("@entrada", info);
                sqlCommand.CommandText = query;
                sqlConnection.Open();
                sqlCommand.ExecuteNonQuery();                
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

        string IArchivos<string>.Leer()
        {
            SqlConnection sqlConnection = new SqlConnection("Data Source=localhost; Initial Catalog=20201119-sp; Integrated Security = True");
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandType = System.Data.CommandType.Text;
            sqlCommand.Connection = sqlConnection;
            StringBuilder sb = new StringBuilder();

            try
            {
                string query = $"SELECT * FROM log";
                sqlConnection.Open();
                sqlCommand.CommandText = query;
                SqlDataReader reader = sqlCommand.ExecuteReader();
                while (reader.Read())
                {
                    sb.Append(reader[1].ToString());
                    sb.Append(reader[2].ToString());
                    sb.Append(reader[3].ToString());
                    sb.AppendLine("-----------------------------");
                }
                reader.Close();
                sqlConnection.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                sqlConnection.Close();
            }
            return sb.ToString();
        }            
    }
}
