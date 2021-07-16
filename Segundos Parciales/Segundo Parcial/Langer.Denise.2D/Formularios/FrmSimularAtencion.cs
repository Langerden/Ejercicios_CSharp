using Entidades;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Formularios
{
    public partial class FrmSimularAtencion : Form
    {
        Comercio comercio;
        Simulador simulador;

        /// <summary>
        /// Constructor por defecto
        /// </summary>
        public FrmSimularAtencion()//Comercio comercio)
        {
            InitializeComponent();
        }

        /// <summary>
        /// Constructor que obtiene una instancia de comercio e inicializa el simulador.
        /// Asocia el manejador MostrarDatos al evento del simulador.
        /// </summary>
        /// <param name="comercio"></param>
        public FrmSimularAtencion(Comercio comercio) : this()
        {
            this.comercio = comercio;
            this.simulador = new Simulador(comercio);
            this.simulador.MostrarInfo += MostrarDatos;
        }

        /// <summary>
        /// Evento para cerrar el formulario presionando la tecla ESC
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmSimularAtencion_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                this.Close();
        }

        /// <summary>
        /// Evento Load del form. Llama al metodo IniciarHilo del simulador para arrancar el hilo secundario del programa
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmSimularAtencion_Load(object sender, EventArgs e)
        {
            this.simulador.IniciarHilo();
        }

        /// <summary>
        /// Metodo manejador del evento. Obtendrá la instancia del cliente y mostrará los datos dentro del label
        /// </summary>
        /// <param name="c"></param>
        private void MostrarDatos(Cliente c)
        {
            if (this.lblCliente.InvokeRequired)
            {
                try
                {
                    this.lblCliente.BeginInvoke((MethodInvoker)delegate ()
                    {
                        this.lblCliente.Text = $"{c.Numero} - {c.Nombre}";
                    });
                }
                catch (Exception ex)
                {
                    this.lblCliente.Text = ex.Message;
                }
            }
        }

        /// <summary>
        /// Evento Closing del form. Guarda en base de datos la cantidad de clientes atendidos y no atendidos (segun el valor del random)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmSimularAtencion_FormClosing(object sender, FormClosingEventArgs e)
        {

            SqlConnection sqlConnection = new SqlConnection("Data Source=localhost; Initial Catalog=20210706-SP; Integrated Security = True");
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandType = System.Data.CommandType.Text;
            sqlCommand.Connection = sqlConnection;

            try
            {
                string query = $"INSERT INTO atenciones (atendidos, noAtendidos, alumno)" +
                    "VALUES (@atendidos,@noAtendidos,@alumno)";
                sqlCommand.Parameters.Clear();
                sqlCommand.Parameters.AddWithValue("@atendidos", simulador.Atendido);
                sqlCommand.Parameters.AddWithValue("@noAtendidos", simulador.NoAtendidos);
                sqlCommand.Parameters.AddWithValue("@alumno", "Denise");
                sqlCommand.CommandText = query;
                if (sqlConnection.State != ConnectionState.Open)
                    sqlConnection.Open();

                sqlCommand.ExecuteNonQuery();
            }
            catch (Exception)
            {
                MessageBox.Show("Ocurrió un error al guardar los datos en la BDD");
            }
            finally
            {
                sqlConnection.Close();
            }
        }
    }
}
