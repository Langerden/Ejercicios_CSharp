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

namespace MostrarDatos
{
    public partial class FormDatos : Form
    {
        public FormDatos(Bar bar)
        {
            InitializeComponent();
            richTextBoxSalidaDeTest.Text = bar.ToString();
        }
    }
}
