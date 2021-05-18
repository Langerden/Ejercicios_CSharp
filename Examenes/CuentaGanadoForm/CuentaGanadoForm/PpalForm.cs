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

namespace CuentaGanadoForm
{
    public partial class FormContador : Form
    {
        Bar bar;
        Random random = new Random();
        decimal empleados = 0;
        decimal gente = 0;

        public FormContador()
        {
            InitializeComponent();
            bar = Bar.GetBar();
            this.numEmpleados.ReadOnly = true;
            this.numGente.ReadOnly = true;

        }

        private void btnInforme_Click(object sender, EventArgs e)
        {
            FormDatos datos = new FormDatos(this.bar.ToString());
            datos.ShowDialog();

            //datos.CargarDatos = "Wachin";

            //richTxt.Text = this.bar.ToString();
        }

        private void numEmpleados_ValueChanged(object sender, EventArgs e)
        {
            if (numEmpleados.Value > empleados)
            {
                bool agregar = this.bar + new Empleados((short) random.Next(18, 30), "Denu");
                if(agregar)
                {
                    this.empleados++;
                    MessageBox.Show($"Se agregó al empleado");
                }
            }  else 
            {
                if (empleados > 0)
                {
                    if (this.bar.Empleados.Count > 0)
                    {
                        this.bar.Empleados.RemoveAt(bar.Empleados.Count - 1);
                        MessageBox.Show("Se borró al empleado");
                        this.empleados--;
                    }
                }            
            }
        }

        private void numGente_ValueChanged(object sender, EventArgs e)
        {
            if (this.numGente.Value > gente)
            {
                bool agregar = this.bar + new Gente((short)random.Next(18, 30));
                if (agregar)
                {
                    this.gente++;
                    MessageBox.Show($"Se agregó gente");
                }
            }            
            else
            {
                if (bar.Gente.Count > 0)
                {
                    this.bar.Gente.RemoveAt(0);
                    this.gente--;
                }
                MessageBox.Show("Se borró gente");
            }
        }
    }
}
