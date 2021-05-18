using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehiculos
{
    public class VehiculoDeCarrera
    {
        private short cantidadCombustible;
        private bool enCompetencia;
        private string escuderia;
        private short numero;
        private short vueltasRestantes;


        public VehiculoDeCarrera(string escuderia, short numero)
        {
            this.escuderia = escuderia;
            this.numero = numero;
        }


        public short CantidadCombustible
        {
            get { return this.cantidadCombustible; }
            set { this.cantidadCombustible = value; }
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

        public virtual string MostrarDatos()
        {
            return ($"COMBUSTIBLE: {CantidadCombustible}, EN COMPETENCIA: {EnCompetencia}, ESCUDERIA: {this.Escuderia}, NUMERO: {this.numero}, VUELTAS RESTANTES: {VueltasRestantes}");
        }

        public static bool operator ==(VehiculoDeCarrera v1, VehiculoDeCarrera v2)
        {
            return ((v1.numero == v2.numero) && (v1.Escuderia == v2.Escuderia));
        }

        public static bool operator !=(VehiculoDeCarrera v1, VehiculoDeCarrera v2)
        {
            return !(v1 == v2);
        }
    }
}
