using ControlCantina;
using Entidades;
using System;
using System.Windows.Forms;

namespace FormCantina
{
    public partial class Form1 : Form
    {
        Barra barra = new Barra();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {            
            barra.SetCantina = Cantina.GetCantina(10);
            cmb_TipoBotella.DataSource = Enum.GetValues(typeof(Botella.Tipo));
        }

        private void cmb_TipoBotella_SelectedIndexChanged(object sender, EventArgs e)
        {
            Botella.Tipo tipo;
            Enum.TryParse<Botella.Tipo>(cmb_TipoBotella.SelectedValue.ToString(), out tipo);
        }

        private void btn_Agregar_Click(object sender, EventArgs e)
        {
            if (rdn_Cerveza.Checked)
            {
                Botella botellaCerveza = new Cerveza((int)num_Capacidad.Value, (int)num_Contenido.Value, txt_Marca.Text);
                this.barra.AgregarBotella(botellaCerveza);
                MessageBox.Show($"{botellaCerveza.ToString()} \nSe agregó la cerveza", "Alcohol", MessageBoxButtons.OK);
            }
            else
            {
                Botella botellaAgua = new Agua((int)num_Capacidad.Value, (int)num_Contenido.Value, txt_Marca.Text);
                barra.AgregarBotella(botellaAgua);
                MessageBox.Show($"{botellaAgua.ToString()} \nSe agregó el agua", "Awita", MessageBoxButtons.OK);
            }
        }
    }
}
