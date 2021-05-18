using Biblioteca;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlesUsuario
{
    public partial class FormBarra : Form
    {
        public FormBarra()
        {
            InitializeComponent();
        }

        private void FormBarra_Load(object sender, EventArgs e)
        {
            this.barra1.SetCantina = Cantina.GetCantina(10);
        }
    }
}
