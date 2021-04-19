using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FormCentralita;
using CentralitaHerencia;
using Ejercicio_40;

namespace FormCentralita
{
    public partial class FormMenu : Form
    {
        private Centralita centralitaMenu;

        public FormMenu()
        {
            InitializeComponent();
            centralitaMenu = new Centralita("KCY SAS");
        }

        private void FormMenu_Load(object sender, EventArgs e)
        {

        }

        private void btnLlamada_Click(object sender, EventArgs e)
        {
            FrmLlamador llamador = new FrmLlamador(centralitaMenu);
            llamador.ShowDialog();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Seguro que desea salir?", "CONFIRMAR", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
                this.Close();
        }

        private void btnFacturacionTotal_Click(object sender, EventArgs e)
        {
            FrmMostrar mostrar = new FrmMostrar(centralitaMenu);
            mostrar.TipoLlamada = Llamada.TipoLlamada.Todas;
            mostrar.ShowDialog();
        }

        private void btn_FacturaLocal_Click(object sender, EventArgs e)
        {
            FrmMostrar mostrar = new FrmMostrar(centralitaMenu);
            mostrar.TipoLlamada = Llamada.TipoLlamada.Local;
            mostrar.ShowDialog();
        }

        private void btnFacturacionProvincial_Click(object sender, EventArgs e)
        {
            FrmMostrar mostrar = new FrmMostrar(centralitaMenu);
            mostrar.TipoLlamada = Llamada.TipoLlamada.Provincial;
            mostrar.ShowDialog();
        }
    }
}
