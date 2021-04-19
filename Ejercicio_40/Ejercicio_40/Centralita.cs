using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
    public class Centralita
    {
        private List<Llamada> listaDeLlamadas;
        protected string razonSocial;

        public float GananciasPorLocal
        {
            get {
                return CalcularGanancia(Llamada.TipoLlamada.Local);
            }
        }       
        public float GananciasPorProvincial
        {
            get { return CalcularGanancia(Llamada.TipoLlamada.Provincial) ; }
        }        
        public float GananciasPorTotal
        {
            get { return CalcularGanancia(Llamada.TipoLlamada.Todas); }
        }
        public List<Llamada> Llamadas
        {
            get { return listaDeLlamadas; }
        }
        public Centralita()
        {
            this.listaDeLlamadas = new List<Llamada>();
        }
        public Centralita(string razonSocial) : this()
        {
            this.razonSocial = razonSocial;
        }

        private float CalcularGanancia(Llamada.TipoLlamada tipo)
        {
            float ganancia = 0;
            foreach (Llamada llamada in listaDeLlamadas)
            {

                switch (tipo)
                {
                    case Llamada.TipoLlamada.Local:
                        if (llamada is Local)
                            ganancia += ((Local)llamada).CostoLlamada;
                        break;
                    case Llamada.TipoLlamada.Provincial:
                        if (llamada is Provincial)
                            ganancia += ((Provincial)llamada).CostoLlamada;
                        break;
                    case Llamada.TipoLlamada.Todas:
                        if (llamada is Local)
                            ganancia += ((Local)llamada).CostoLlamada;
                        else
                            ganancia += ((Provincial)llamada).CostoLlamada;
                        break;
                }
            }
            return ganancia;
        }

        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"RAZON SOCIAL: {this.razonSocial}, GANANCIA TOTAL: {this.GananciasPorTotal}, GANANCIA LOCAL: {this.GananciasPorLocal}, GANANCIA PROVINCIAL: {this.GananciasPorProvincial}\n");
            foreach(Llamada llamada in listaDeLlamadas)
            {
                sb.AppendLine($"LLAMADA : {llamada.ToString()}");    
            }
            return sb.ToString();
        }

        private void AgregarLlamada (Llamada nuevaLlamada)
        {
            this.listaDeLlamadas.Add(nuevaLlamada);
        }

        public static Centralita operator + (Centralita c, Llamada nuevaLlamada)
        {
            if (c != nuevaLlamada)
            {
                c.AgregarLlamada(nuevaLlamada);
            }
            return c;
        }

        public static bool operator ==(Centralita c, Llamada llamada)
        {
            bool retorno = false;
            if(llamada != null)
            {
                foreach(Llamada llamadaList in c.listaDeLlamadas)
                {
                    if (llamada == llamadaList)
                    {
                        retorno = true;
                        break;
                    }
                }
            }
            return retorno;
        }

        public static bool operator !=(Centralita c, Llamada llamada)
        {
            return !(c == llamada);
        }


        public void OrdenarLlamadas()
        {
            listaDeLlamadas.Sort(Llamada.OrdenarPorDuracion);
        }

        public override string ToString()
        {
            return this.Mostrar();
        }
    }
}
