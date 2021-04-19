using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CentralitaHerencia;

namespace Ejercicio_40
{
    public partial class FrmMostrar : Form
    {
        private Centralita centralitaMostrar;
        private Llamada.TipoLlamada tipo;
        public FrmMostrar(Centralita menuCentralita)
        {
            InitializeComponent();
            centralitaMostrar = menuCentralita;
        }

        public Llamada.TipoLlamada TipoLlamada
        {
            set
            {
                this.tipo = value;
            }
        }

        private void FrmMostrar_Load(object sender, EventArgs e)
        {
            switch(this.tipo)
            {
                case Llamada.TipoLlamada.Local:
                    rtxt.Text = "Local: " + (Math.Round(centralitaMostrar.GananciasPorLocal, 2)).ToString();
                    break;
                case Llamada.TipoLlamada.Provincial:
                    rtxt.Text = "¨Provincial: " + (Math.Round(centralitaMostrar.GananciasPorProvincial, 2)).ToString();
                    break;
                case Llamada.TipoLlamada.Todas:
                    rtxt.Text = "Todas: " + (Math.Round(centralitaMostrar.GananciasPorTotal, 2)).ToString();
                    break;
            }
        }
    }
}
