using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Conversores;

namespace Ejercicio__25
{
    public partial class ConversorForm : Form
    {
        public ConversorForm()
        {
            InitializeComponent();
        }

        private void ConversorForm_Load(object sender, EventArgs e)
        {

        }

        private void txtBinario_Leave(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(txtBinario.Text))
            {
                NumeroBinario numeroBinario = new NumeroBinario(txtBinario.Text);
                txtBinario.Text = numeroBinario.GetNumeroBinario();
            } else
            {
                MessageBox.Show("Numero no valido", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtBinario.Focus();
            }
        }

        private void txtDecimal_Leave(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(txtDecimal.Text) && Double.TryParse(txtDecimal.Text, out double decimalValid))
            {
                NumeroDecimal numeroDecimal = new NumeroDecimal(decimalValid);
                txtDecimal.Text = numeroDecimal.GetNumeroDecimal().ToString();
            }
            else
            {
                MessageBox.Show("Numero no valido", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtBinario.Focus();
            }
        }

        private void btnBinToDec_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(txtBinario.Text) && (!String.IsNullOrEmpty(txtBinario.Text)))
            {
                NumeroBinario numeroBinario = new NumeroBinario(txtBinario.Text);
                if (((NumeroDecimal)numeroBinario).GetNumeroDecimal() == -1)
                {
                    txtResultadoDec.Text = "Error de convercion";
                }
                else
                {
                    txtResultadoDec.Text = ((NumeroDecimal)numeroBinario).GetNumeroDecimal().ToString();
                }
            }
        }

        private void btnDecToBin_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(txtDecimal.Text) && Double.TryParse(txtDecimal.Text, out double decimalValid))
            {
                NumeroDecimal numeroDecimal = new NumeroDecimal(decimalValid);
                txtResultadoBin.Text = ((NumeroBinario)numeroDecimal).GetNumeroBinario();
            }
        }
    }
}
