using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CentralitaHerencia;
using static CentralitaHerencia.Provincial;

namespace Ejercicio_40
{
    public partial class FrmLlamador : Form
    {
        private Centralita centralita;
        private Random rdn = new Random();        

        public Centralita CentralLlamador
        {
            get { return centralita; }
        }

        public FrmLlamador(Centralita c)
        {
            InitializeComponent();
            this.centralita = c;
        }

        private void FrmLlamador_Load(object sender, EventArgs e)
        {
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btn1_Click(object sender, EventArgs e)
        {
            txtPhone.Text +="1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txtPhone.Text += "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txtPhone.Text += "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txtPhone.Text += "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txtPhone.Text += "5";

        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txtPhone.Text += "6";

        }

        private void btn7_Click(object sender, EventArgs e)
        {
            txtPhone.Text += "7";

        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txtPhone.Text += "8";

        }

        private void btn9_Click(object sender, EventArgs e)
        {
            txtPhone.Text += "9";

        }

        private void btn0_Click(object sender, EventArgs e)
        {
            txtPhone.Text += "0";
        }

        private void btnHash_Click(object sender, EventArgs e)
        {
            txtPhone.Text += "#";
            cmbFranja.DataSource = Enum.GetValues(typeof(Franja));
            Franja franjas;
            Enum.TryParse<Franja>(cmbFranja.SelectedValue.ToString(), out franjas);

        }

        private void btnStar_Click(object sender, EventArgs e)
        {
            txtPhone.Text += "*";
        }

        private void btnLlamar_Click(object sender, EventArgs e)
        {
            float duracion = rdn.Next(1, 50);
            float costo = rdn.Next(0, 5);
            
            if (!txtPhone.Text.StartsWith("#"))
            {
                cmbFranja.Enabled = false;
                Local local = new Local(txtNroOrigen.Text, duracion, txtPhone.Text, costo);
                centralita += local;
            } else
            {
                Provincial provincial = new Provincial(txtNroOrigen.Text, (Franja)cmbFranja.SelectedIndex, duracion, txtPhone.Text);
                centralita += provincial;
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNroOrigen.Text = String.Empty;
            txtPhone.Text = String.Empty;
            cmbFranja.Enabled = true;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
           DialogResult result = MessageBox.Show("Seguro que desea salir?", "CONFIRMAR", MessageBoxButtons.YesNo);
           if (result == DialogResult.Yes)
                this.Close();
        }
    }
}
