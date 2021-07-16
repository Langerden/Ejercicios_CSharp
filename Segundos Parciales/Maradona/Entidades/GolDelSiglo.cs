using Audio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Entidades
{
    public class GolDelSiglo
    {
        Thread hiloRelato;

        public void CerrarApp()
        {
            if (this.hiloRelato != null && this.hiloRelato.IsAlive)
                this.hiloRelato.Abort();
        }

        public void IniciarJugada()
        {
            if(this.hiloRelato != null && this.hiloRelato.IsAlive)
            {
                throw new JugadaActivaException();
            } else
            {
                this.hiloRelato = new Thread(Relato.VictorHugoMorales);
                this.hiloRelato.Start();
            }
        }
    }
}
