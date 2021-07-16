using Entidades;
using System;
using System.Windows.Forms;

namespace Formularios
{
    public partial class FrmAgregarCliente : Form
    {
        Comercio comercio;

        /// <summary>
        /// Propiedad de Lectura y Escritura correspondiente al textBox1
        /// </summary>
        public string NombreTxt
        {
            get { return this.textBox1.Text; }
            set { this.textBox1.Text = value; }
        }

        /// <summary>
        /// Constructor por defecto
        /// </summary>
        public FrmAgregarCliente()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Constructor que obtiene la instancia del comercio
        /// </summary>
        /// <param name="c"></param>
        public FrmAgregarCliente(Comercio c) : this()
        {
            this.comercio = c;

        }

        /// <summary>
        /// Evento click del boton agregar. Validará que el text box no se encuentre vacio.
        /// En caso contrario, settea el DialogResult como OK y el dato del text box dentro de la propiedad.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.textBox1.Text))
                MessageBox.Show("El campo no puede quedar en blanco", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                this.DialogResult = DialogResult.OK;
                this.NombreTxt = this.textBox1.Text;
                this.Close();
                //DialogResult dialog = MessageBox.Show("Confirma agregar al cliente?", "Confirmar", MessageBoxButtons.OKCancel);
                //if (dialog == DialogResult.OK)
                //{
                    //Cliente aux = new Cliente(this.textBox1.Text);
                    //comercio += aux;
                //}
            }
        }
    }
}
