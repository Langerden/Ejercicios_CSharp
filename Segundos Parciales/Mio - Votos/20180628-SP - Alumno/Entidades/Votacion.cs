using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace Entidades
{

    public class Votacion
    {
        [field: NonSerialized]
        public delegate void Voto(string senador, Votacion.EVoto voto);
        
        [field: NonSerialized]
        public event Voto EventoVotoEfectuado;

        public enum EVoto { Afirmativo, Negativo, Abstencion, Esperando }

        private string nombreLey;
        private Dictionary<string, EVoto> senadores;

        private short contadorAfirmativo;
        private short contadorNegativo;
        private short contadorAbstencion;

        public string NombreLey { get => nombreLey; set => nombreLey = value; }
        public Dictionary<string, EVoto> Senadores { get => senadores; set => senadores = value; }
        public short ContadorAfirmativo { get => contadorAfirmativo; set => contadorAfirmativo = value; }
        public short ContadorNegativo { get => contadorNegativo; set => contadorNegativo = value; }
        public short ContadorAbstencion { get => contadorAbstencion; set => contadorAbstencion = value; }

        public Votacion()
        {
        }

        public Votacion(string nombreLey, Dictionary<string, EVoto> senadores)
        {
            this.nombreLey = nombreLey;
            this.senadores = senadores;
        }

        public void Simular()
        {
            // Reseteo contadores
            this.contadorAbstencion = 0;
            this.contadorAfirmativo = 0;
            this.contadorNegativo = 0;
            // Itero todos los Senadores
            for (int index = 0; index < this.senadores.Count; index++)
            {
                // Duermo el hilo
                System.Threading.Thread.Sleep(2134);

                // Leo el senador actual
                KeyValuePair<string, EVoto> k = this.senadores.ElementAt(index);
                // Generador de número aleatorio
                Random r = new Random(k.Key.ToString().Length + DateTime.Now.Millisecond);
                // Modifico el voto de forma aleatoria
                this.senadores[k.Key] = (EVoto)r.Next(0, 3);

                // Invocar Evento
                this.EventoVotoEfectuado.Invoke(this.senadores.ElementAt(index).Key, this.senadores.ElementAt(index).Value);
                // Incrementar contadores
                switch (this.senadores.ElementAt(index).Value)
                {
                    case EVoto.Afirmativo:
                        this.ContadorAfirmativo++;
                        break;
                    case EVoto.Negativo:
                        this.ContadorNegativo++;
                        break;
                    case EVoto.Abstencion:
                        this.ContadorAbstencion++;
                        break;                   
                    default:
                        break;
                }
            }
        }

    }
}
