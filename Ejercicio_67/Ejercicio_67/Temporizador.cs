using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Ejercicio_67
{
    public delegate void EncargadoTiempo();
    public sealed class Temporizador
    {
        private Thread hilo;
        private int intervalo;
        public event EncargadoTiempo eventoTiempo;

        public bool Activo
        {
            get { return (!(this.hilo is null)) && this.hilo.IsAlive; }
            set
            {
                if (value)
                {
                    if (this.hilo is null)
                    {
                        this.hilo = new Thread(this.Corriendo);
                        this.hilo.Start();
                    }
                }
                else
                {
                    if (this.hilo != null && this.hilo.IsAlive)
                        this.hilo.Abort();
                }
            }
        }

        public int Intervalo { get => intervalo; set => intervalo = value; }

        public void Corriendo()
        {
            while (true)
            {
                Thread.Sleep(Intervalo);
                if (this.eventoTiempo != null)
                    this.eventoTiempo.Invoke();
            }

        }

    }

}
