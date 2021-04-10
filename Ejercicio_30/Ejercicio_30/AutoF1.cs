using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_30
{
    public class AutoF1
    {
        private short cantidadCombustible;
        private bool enCompetencia;
        private string escuderia;
        private short numero;
        private short vueltasRestantes;

        public AutoF1()
        {
            this.enCompetencia = false;
            this.cantidadCombustible = 0;
        }

        public AutoF1(string escuderia, short numero) : this ()
        {
            this.escuderia = escuderia;
            this.numero = numero;
        }


        public short CantidadCombustible
        {
            get { return this.cantidadCombustible; }
            set { this. cantidadCombustible = value; }
        }

        public bool EnCompetencia
        {
            get { return this.enCompetencia; }
            set { this.enCompetencia = value; }
        }
        public short VueltasRestantes
        {
            get { return this.vueltasRestantes; }
            set { this.vueltasRestantes = value; }
        }

        public short Numero
        {
            get { return this.numero; }
            set { this.numero = value; }
        }

        public string Escuderia { get => escuderia; set => escuderia = value; }

        public string MostrarDatos ()
        {
             return ($"COMBUSTIBLE: {CantidadCombustible}, EN COMPETENCIA: {EnCompetencia}, ESCUDERIA: {this.Escuderia}, NUMERO: {this.numero}, VUELTAS RESTANTES: {VueltasRestantes}");
        }

        public static bool operator == (AutoF1 f1, AutoF1 f2)
        {
            return f1.numero == f2.numero;
        }

        public static bool operator !=(AutoF1 f1, AutoF1 f2)
        {
            return !(f1 == f2);
        }

    }
}
