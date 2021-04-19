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
    public partial class AltaUsuario : Form
    {
        private Usuario usuario;

        public AltaUsuario()
        {
            InitializeComponent();
        }

        private void AltaUsuario_Load(object sender, EventArgs e)
        {

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            //Checkbox
            string[] formasDePago = new string[0];
            foreach (Control miControl in this.panelFormasPago.Controls)
            {
                if (miControl is CheckBox && ((CheckBox)miControl).Checked)
                {
                    Array.Resize<string>(ref formasDePago, formasDePago.Length + 1);
                    formasDePago[formasDePago.Length - 1] = ((CheckBox)miControl).Text;
                }
            }

            //Radio Button
            string formaPago = "";
            foreach (Control item in goupBoxMediosDePago.Controls)
            {
                if (item is RadioButton && ((RadioButton)item).Checked)
                    formaPago = item.Text;
            }

            //Combo Box

            //this.cmbProvincia.DataSource = coleccion propia de objetos
            string provincia = "";
            if (this.cmbProvincia.SelectedIndex == -1) //No seleccione nada (No elegi nada del desplegable)
            {
                if (this.cmbProvincia.Text != String.Empty)
                    provincia = this.cmbProvincia.Text;
            }
            else
            {
                provincia = this.cmbProvincia.SelectedItem.ToString(); //
            }

            //Textbox y NumericUpDown
            this.usuario = new Usuario(this.txtApellido.Text, this.txtName.Text, (long)this.numDni.Value,
                formasDePago,formaPago, provincia);

            this.DialogResult = DialogResult.OK;
        }

        private void numDni_ValueChanged(object sender, EventArgs e)
        {

        }

        private void lblFormaPago_Click(object sender, EventArgs e)
        {

        }

        private void panelFormasPago_Paint(object sender, PaintEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void optTarjeta_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cmbProvincia_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void chkTarjeta_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chkEfectivo_CheckedChanged(object sender, EventArgs e)
        {

        }

        public Usuario GetUsuario()
        {
            return this.usuario;
        }
    }
}
