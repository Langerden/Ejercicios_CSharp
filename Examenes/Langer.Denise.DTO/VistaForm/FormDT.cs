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
    public partial class FormDT : Form
    {
        private DirectorTecnico director;
        public FormDT()
        {
            InitializeComponent();
        }

        private void FormDT_Load(object sender, EventArgs e)
        {

        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtApellido.Text) ||
                string.IsNullOrEmpty(txtNombe.Text))
            {
                director = null;
                MessageBox.Show("Debe completar todos los campos", "Incompleto", MessageBoxButtons.OK);
            }
            else
            {
                director = new DirectorTecnico(txtApellido.Text, txtNombe.Text, (int)numEdad.Value, (int)numDni.Value, (int)numExp.Value);
                MessageBox.Show("Se ha creado el DT!", "Confirmar", MessageBoxButtons.OK);
            }
        }

        private void btnValidar_Click(object sender, EventArgs e)
        {
            if (director == null )
                MessageBox.Show("Aún no se ha creado el DT del formulario", "ERROR", MessageBoxButtons.OK);
            else if (director.ValidarAptitud())
                MessageBox.Show("El DT es apto", "OKEY", MessageBoxButtons.OK);
            else if(!director.ValidarAptitud())
                MessageBox.Show("El DT no es apto.", "WARNING", MessageBoxButtons.OK);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(button1.ImageIndex < 2)
            {
                button1.ImageIndex++;
            } else
            {
                button1.ImageIndex = 0;
            }
        }
    }
}
