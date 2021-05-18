using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace VistaForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtModelo.Text) || String.IsNullOrEmpty(txtPatente2.Text))
            {
                MessageBox.Show($"Debe ingresar datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                PickUp pickUp = new PickUp(txtPatente2.Text, txtModelo.Text);
                MessageBox.Show($"Pickup creado con patente {pickUp.Patente} y modelo {txtModelo.Text}", "Ok", MessageBoxButtons.OK);
            }
        }
    }
}
