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

namespace Ejercicio_68
{
    public partial class FormPersona : Form
    {
        private Persona persona;

        public FormPersona()
        {
            InitializeComponent();
        }

        public static void NotificarCambio (string message)
        {
            MessageBox.Show(message);
        }

        private void btn_Crear_Click(object sender, EventArgs e)
        {
            if(this.persona is null)
            {
                persona = new Persona();
                persona.EventoString += NotificarCambio;
                persona.Nombre = txt_Nombre.Text;
                persona.Apellido = text_Apellido.Text;
                this.btn_Crear.Text = "Actualizar";                
            } else {
                if (!(this.txt_Nombre.Text.Equals(persona.Nombre)))
                {
                    this.persona.Nombre = this.txt_Nombre.Text;
                }

                if (!(this.text_Apellido.Text.Equals(persona.Apellido)))
                {
                    this.persona.Apellido = this.text_Apellido.Text;
                }

                MessageBox.Show(this.persona.Mostrar());
            }
        }
    }
}
