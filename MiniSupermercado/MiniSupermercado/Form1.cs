using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniSupermercado
{
    public partial class Form1 : Form
    {
        static int cantidad = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnNuevoCliente_Click(object sender, EventArgs e)
        {
            AltaUsuario altaUsuario = new AltaUsuario();
            altaUsuario.Location = this.Location;
            if(altaUsuario.ShowDialog() == DialogResult.OK);
                MiniSuper.AgregarUsuario(altaUsuario.GetUsuario());

            //altaUsuario.Show();

            
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("¿Estas seguro que quiere cerrar el programa?", "Cerrando", MessageBoxButtons.YesNo)
                == DialogResult.No)
                e.Cancel = true;  
        }
    }
}
