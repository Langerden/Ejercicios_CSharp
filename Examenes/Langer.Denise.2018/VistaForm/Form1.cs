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
    public partial class FormPpal : Form
    {
        Curso curso;
        Alumno alum;
        public FormPpal()
        {
            InitializeComponent();
        }

        private void btnCurso_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtApe.Text) || String.IsNullOrEmpty(txtNom.Text) || String.IsNullOrEmpty(txtDni.Text))
            {
                MessageBox.Show("Debe ingresar datos", "Error", MessageBoxButtons.OK);
            }
            else
            {

                Alumno.Division division;
                Enum.TryParse<Alumno.Division>(cmbDiv.SelectedValue.ToString(), out division);
                curso = new Curso((short)numAnio.Value, division, new Profesor(txtNom.Text, txtApe.Text, txtDni.Text));
                MessageBox.Show("Se creo el curso", "Ok", MessageBoxButtons.OK);
            }
        }

        private void FormPpal_Load(object sender, EventArgs e)
        {
            cmbDiv.DataSource = Enum.GetValues(typeof(Alumno.Division));
            cmbDivA.DataSource = Enum.GetValues(typeof(Alumno.Division));
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            if(curso != null)
            {
                rtbDatos.Text = (string)curso;
            } else
            {
                MessageBox.Show("No hay un curso creado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtApeA.Text) || String.IsNullOrEmpty(txtNomA.Text) || String.IsNullOrEmpty(txtLeg.Text) || curso is null)
            {
                MessageBox.Show("Debe ingresar datos", "Error", MessageBoxButtons.OK);
            }
            else
            {
                Alumno.Division division;
                Enum.TryParse<Alumno.Division>(cmbDiv.SelectedValue.ToString(), out division);
                alum = new Alumno(txtNomA.Text, txtApeA.Text, txtLeg.Text, (short)numAnioA.Value, division);
                curso += alum;
                MessageBox.Show("Se agregó el alumno", "Ok", MessageBoxButtons.OK);
            }
        }
    }
}
