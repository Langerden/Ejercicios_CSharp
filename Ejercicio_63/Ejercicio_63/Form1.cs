using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using Ejercicio_67;

namespace Ejercicio_63
{
    public delegate void Delegado(object objeto);
    public delegate void DelegadoVoid();
    public partial class Form1 : Form
    {
        Temporizador temp = new Temporizador();
        //Thread hiloPrincipal;

        public Form1()
        {
            InitializeComponent();
        }

        //public void AsignarHora(Object objeto)
        //{
        //    if (this.lblHora.InvokeRequired)
        //    {
        //        Delegado miDelegado = new Delegado(AsignarHora);
        //        Object[] arrayObject = new Object[] { objeto};
        //        this.Invoke(miDelegado, arrayObject);
        //    } else { this.lblHora.Text = objeto.ToString(); }
        //}

        public void AsignarHora2()
        {
            if (this.lblHora.InvokeRequired)
            {
                DelegadoVoid delegado2 = new DelegadoVoid(this.AsignarHora2);
                this.Invoke(delegado2);
            } else
            {
                this.lblHora.Text = DateTime.Now.ToString();
            }
        }

        //Realizar la actualización de la hora 1 vez por segundo utilizando alguna estructura de control dada en clase.
        //private void ActualizarHora()
        //{
        //    while (true)
        //    {
        //        this.AsignarHora(DateTime.Now);
        //    }
        //}

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            temp.Activo = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            temp.Activo = true;
            temp.Intervalo = 2000;
            temp.eventoTiempo += this.AsignarHora2;
        }
    }
}
