using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_61
{
    public partial class Form1 : Form
    {
        private List<Persona> personas;

        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            this.personas = new List<Persona>();
        }

        private void btn_Leer_Click(object sender, EventArgs e)
        {
            ActualizarDataGrid();
        }

        private void btn_Guardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txt_Name.Text) || string.IsNullOrEmpty(txt_LastName.Text))
                {
                    throw new Exception("El o los campos de Nombre y Apellido no pueden quedar vacios.");
                }
                else
                {
                    Persona persona = new Persona(txt_Name.Text, txt_LastName.Text, checkBox.Checked);
                    if (PersonaDAO.Guardar(persona))
                    {
                        MessageBox.Show("Se creo la persona con éxito", "Exito", MessageBoxButtons.OK);
                        ActualizarDataGrid();
                    }
                }
                LimpiarTxtBox();
            }  catch (Exception ex) {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK);
            }
        }

        private void LimpiarTxtBox()
        {
            txt_Name.Text = string.Empty;
            txt_LastName.Text = string.Empty;
        }

        private void ActualizarDataGrid()
        {
            datagrid_Personas.DataSource = null;
            datagrid_Personas.DataSource = PersonaDAO.Leer();
        }

        private void btn_Modificar_Click(object sender, EventArgs e)
        {
            try
            {
                Persona auxP = (Persona)datagrid_Personas.CurrentRow.DataBoundItem;
                if (PersonaDAO.Modificar(auxP))
                    MessageBox.Show("Se Modificaron los datos correctamente", "Modificacion Exitosa", MessageBoxButtons.OK);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_Eliminar_Click(object sender, EventArgs e)
        {
            Persona auxP = (Persona)datagrid_Personas.CurrentRow.DataBoundItem;
            if (PersonaDAO.Borrar(auxP))
                MessageBox.Show("Se eliminó los datos correctamente", "Eliminacion Exitosa", MessageBoxButtons.OK);

        }
    }
}
