using Entidades;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace Formularios
{
    public partial class FrmAtencion : Form
    {
        Comercio comercio;
        Simulador simulador;
        List<string> listaUltimos;

        /// <summary>
        /// Constructor del formulario atencion. Insntacia sus atributos
        /// </summary>
        public FrmAtencion()
        {
            InitializeComponent();
            this.comercio = new Comercio();
            this.simulador = new Simulador(this.comercio);
            this.listaUltimos = new List<string>();
        }

        /// <summary>
        /// Evento click del importarToolStrip. Busca y selecciona cual lista de clientes se quiere leer.        
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void importarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog.ShowDialog();
            string fileName = openFileDialog.FileName;

            try
            {
                this.comercio.LoadBackup(fileName);

                if (this.listaUltimos.Count < 10)
                {
                    this.listaUltimos.Add(fileName);
                }
                else
                {
                    this.listaUltimos.RemoveAt(0);
                    this.listaUltimos.Add(fileName);
                }

                this.abrirRecienteToolStripMenuItem.DropDownItems.Clear();

                for (int i = 0; i < this.listaUltimos.Count; i++)
                {
                    ToolStripMenuItem aux = new ToolStripMenuItem();
                    aux.Text = this.listaUltimos[i];
                    abrirRecienteToolStripMenuItem.DropDownItems.Add(aux);
                }

                this.Guardar(this.listaUltimos);
            }
            catch (Exception)
            {
                MessageBox.Show($"No se puede Leer o Guardar: {fileName}", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Evento Click del exportarToolStrip. Busca el directorio donde guardar un backup de la lista actual de clientes del comercio en formato xml.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void exportarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog.ShowDialog();
            string fileName = saveFileDialog.FileName;

            try
            {
                this.comercio.SaveBackup(fileName);

            }
            catch (Exception)
            {
                MessageBox.Show($"No se puede serializar: {fileName}", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Instanciara y mostrará el formulario para cargar clientes. 
        /// En caso de que el DialogResult sea OK, agregará la informacion a la lista del comercio.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAgregarCliente_Click(object sender, EventArgs e)
        {
            FrmAgregarCliente frm = new FrmAgregarCliente(this.comercio);
            frm.ShowDialog();

            if(frm.DialogResult == DialogResult.OK)
            {
                Cliente aux = new Cliente(frm.NombreTxt);
                comercio += aux;
            }

        }

        /// <summary>
        /// Instanciará y mostrará el formulario de simulacion
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSimular_Click(object sender, EventArgs e)
        {
            FrmSimularAtencion frm = new FrmSimularAtencion(this.comercio);
            frm.ShowDialog();
        }

        /// <summary>
        /// Metodo que guardara en un archivo de texto laas ultimas 10 rutas válidas que se generó al importar un archivo.xml
        /// </summary>
        /// <param name="datos"></param>
        public void Guardar(List<string> datos)
        {
            string pathArchivo = $"{AppDomain.CurrentDomain.BaseDirectory}\\Recientes.txt";
            try
            {
                using (StreamWriter writer = new StreamWriter(pathArchivo, false))
                {
                    foreach (string item in datos)
                    {
                        writer.WriteLine(item);
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        /// <summary>
        /// Confirma si el usuario desea importar el mismo archivo (dentro de los recientes), y en caso afirmativo lo importará.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void abrirRecienteToolStripMenuItem_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Esta seguro?", "Confirmar", MessageBoxButtons.OKCancel);
            if (dialog == DialogResult.OK)
            {
                try
                {
                    this.comercio.LoadBackup(e.ClickedItem.Text);
                }
                catch (Exception)
                {
                    MessageBox.Show($"Ocurrió un error", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}

