using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Temperatura;

namespace Ejercicio_24
{
    public partial class FormTemperaturas : Form
    {
        public FormTemperaturas()
        {
            InitializeComponent();
        }

        private void FormTemperaturas_Load(object sender, EventArgs e)
        {

        }

        private void txtCelsius_MouseLeave(object sender, EventArgs e)
        {
            if (!(String.IsNullOrWhiteSpace(txtCelsius.Text)) && Double.TryParse(txtCelsius.Text, out double gradosCelsius))
            {
                Celsius celsius = new Celsius(gradosCelsius);
                txtCelsius.Text = celsius.GetTemperatura().ToString();

            }
            else
            {
                MessageBox.Show("Temperatura no valida, reingrese", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtFahrenheit_MouseLeave(object sender, EventArgs e)
        {
            if (!(String.IsNullOrWhiteSpace(txtFahrenheit.Text)) && Double.TryParse(txtFahrenheit.Text, out double gradosFahrenheit))
            {
                Fahrenheit fahrenheit = new Fahrenheit(gradosFahrenheit);
                txtFahrenheit.Text = fahrenheit.GetTemperatura().ToString();
            }
            else
            {
                MessageBox.Show("Temperatura no valida, reingrese", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtKelvin_MouseLeave(object sender, EventArgs e)
        {
            if (!(String.IsNullOrWhiteSpace(txtKelvin.Text)) && Double.TryParse(txtKelvin.Text, out double gradosKelvin))
            {
                Kelvin kelvin = new Kelvin(gradosKelvin);
                txtKelvin.Text = kelvin.GetTemperatura().ToString();
            }
            else
            {
                MessageBox.Show("Temperatura no valida, reingrese", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnCelisus_Click(object sender, EventArgs e)
        {
            if (Double.TryParse(txtCelsius.Text, out double gradosCelsius))
            {
                Celsius celsius = new Celsius(gradosCelsius);                
                txtCelsiusToFahrenheit.Text = ((Fahrenheit)celsius).GetTemperatura().ToString();
                txtCelsiusToCelsius.Text = celsius.GetTemperatura().ToString();
                txtCelsiusToKelvin.Text = ((Kelvin)celsius).GetTemperatura().ToString();
            }
        }

        private void btnFahrenheit_Click(object sender, EventArgs e)
        {
            if (Double.TryParse(txtFahrenheit.Text, out double gradosFahrenheit))
            {
                Fahrenheit fahrenheit = new Fahrenheit(gradosFahrenheit);
                txtFahrenheitToFahrenheit.Text = fahrenheit.GetTemperatura().ToString();
                txtFahrenheitToCelsius.Text = ((Celsius)fahrenheit).GetTemperatura().ToString();
                txtFahrenheitToKelvin.Text = ((Kelvin)fahrenheit).GetTemperatura().ToString();
            }
        }

        private void btnKelvin_Click(object sender, EventArgs e)
        {
            if (Double.TryParse(txtKelvin.Text, out double gradosKelvin))
            {
                Kelvin kelvin = new Kelvin(gradosKelvin);
                txtKelvinToFahrenheit.Text = ((Fahrenheit)kelvin).GetTemperatura().ToString();
                txtKelvinToCelsius.Text = ((Celsius)kelvin).GetTemperatura().ToString();
                txtKelvinToKelvin.Text = kelvin.GetTemperatura().ToString();
            }
        }
    }
}
