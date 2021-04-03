using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Billetes;

namespace Ejercicio_23
{
    public partial class ConversorForm : Form
    {
        private bool locked;

        public ConversorForm()
        {
            InitializeComponent();
            locked = false;
            txtCotizacionDolar.Text = (Dolar.GetCotizacion()).ToString();
            txtCotizacionDolar.Enabled = false;
        }

        private void btnCotizar_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtCotizacionEuro.Text) || String.IsNullOrWhiteSpace(txtCotizacionPeso.Text))
            {
                MessageBox.Show("Debe ingresar los valores", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (!locked)
                {
                    btnCotizar.ImageIndex = 1;
                    txtCotizacionEuro.Enabled = false;
                    txtCotizacionDolar.Enabled = false;
                    txtCotizacionPeso.Enabled = false;
                }
                else
                {
                    btnCotizar.ImageIndex = 0;
                    txtCotizacionEuro.Enabled = true;
                    txtCotizacionDolar.Enabled = true;
                    txtCotizacionPeso.Enabled = true;
                }
                locked = !locked;
            }
        }

        private void btnEuro_Click(object sender, EventArgs e)
        {
            if (!locked)
            {
                MessageBox.Show("Debe bloquearse el candado para asegurar las cotizaciones", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (Double.TryParse(txtEuro.Text, out double equivalenteEuro))
                {
                    Euros myEuro = new Euros(equivalenteEuro);
                    Euros.SetCotizacion(Double.Parse(txtCotizacionEuro.Text));
                    txtEuroEuro.Text = (myEuro.GetCantidad()).ToString();
                    txtEuroDolar.Text = (((Dolar)myEuro).GetCantidad()).ToString();                        
                    txtEuroPeso.Text = (((Pesos)myEuro).GetCantidad()).ToString();
                }
            }
        }

        private void txtCotizacionEuro_MouseLeave(object sender, EventArgs e)
        {
            if ((!(String.IsNullOrWhiteSpace(txtCotizacionEuro.Text))) && (Double.TryParse(txtCotizacionEuro.Text, out double cotizacionEuro)))
            {
                Euros.SetCotizacion(cotizacionEuro);
            }
            else
            {
                txtCotizacionEuro.Focus();
                MessageBox.Show("Debe ingresar un valor valido", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtCotizacionPeso_MouseLeave(object sender, EventArgs e)
        {
            if ((!(String.IsNullOrWhiteSpace(txtCotizacionPeso.Text))) && (Double.TryParse(txtCotizacionPeso.Text, out double cotizacionPesos)))
            {
                Pesos.SetCotizacion(cotizacionPesos);
            }
            else
            {
                txtCotizacionEuro.Focus();
                MessageBox.Show("Debe ingresar un valor valido", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDolar_Click(object sender, EventArgs e)
        {
            if (!locked)
            {
                MessageBox.Show("Debe bloquearse el candado para asegurar las cotizaciones", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (Double.TryParse(txtDolar.Text, out double equivalenteDolar))
                {
                    Dolar myDolar = new Dolar(equivalenteDolar);
                    Dolar.SetCotizacion(Double.Parse(txtCotizacionDolar.Text));
                    txtDolarEuro.Text = (((Euros)myDolar).GetCantidad()).ToString();
                    txtDolarDolar.Text = (myDolar.GetCantidad()).ToString();
                    txtDolarPeso.Text = (((Pesos)myDolar).GetCantidad()).ToString();
                }
            }
        }

        private void txtEuro_MouseLeave(object sender, EventArgs e)
        {
            if ((!(String.IsNullOrWhiteSpace(txtEuro.Text))) && (Double.TryParse(txtEuro.Text, out double cotizacionEuro)))
            {
                Euros.SetCotizacion(cotizacionEuro);
            }
            else
            {
                txtEuro.Focus();
                MessageBox.Show("Debe ingresar un valor valido", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtDolar_MouseLeave(object sender, EventArgs e)
        {
            if ((!(String.IsNullOrWhiteSpace(txtDolar.Text))) && (Double.TryParse(txtDolar.Text, out double cotizacionDolar)))
            {
                Dolar.SetCotizacion(cotizacionDolar);
            }
            else
            {
                txtDolar.Focus();
                MessageBox.Show("Debe ingresar un valor valido", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtPeso_MouseLeave(object sender, EventArgs e)
        {
            if ((!(String.IsNullOrWhiteSpace(txtPeso.Text))) && (Double.TryParse(txtPeso.Text, out double cotizacionPesos)))
            {
                Dolar.SetCotizacion(cotizacionPesos);
            }
            else
            {
                txtPeso.Focus();
                MessageBox.Show("Debe ingresar un valor valido", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnPeso_Click(object sender, EventArgs e)
        {
            if (!locked)
            {
                MessageBox.Show("Debe bloquearse el candado para asegurar las cotizaciones", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (Double.TryParse(txtPeso.Text, out double equivalentePesos))
                {
                    Pesos myPeso = new Pesos(equivalentePesos);
                    Pesos.SetCotizacion(Double.Parse(txtCotizacionPeso.Text));
                    txtPesoEuro.Text = (((Euros)myPeso).GetCantidad()).ToString();
                    txtPesoDolar.Text =(((Dolar)myPeso).GetCantidad()).ToString();
                    txtPesoPeso.Text = (myPeso.GetCantidad()).ToString();
                }
            }
        }
    }
}
