using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public delegate void InformacionDeAvance(object sender, PlanetaEventArgs e);

    public class Planeta
    {
        private short velocidadTraslacion;
        private short posicionActual;
        private short radioRespectoSol;
        private object objetoAsociado;
        public event InformacionDeAvance InformarAvance;

        public Planeta()
        {

        }

        public Planeta(short velocidad, short posicion, short radioRespectoSol, object objetoVisual)
        {
            this.velocidadTraslacion = velocidad;
            this.posicionActual = posicion;
            this.objetoAsociado = objetoVisual;
            this.radioRespectoSol = radioRespectoSol;
        }

        /// <summary>
        /// PictureBox u objeto gráfico asociado al planeta.
        /// </summary>
        [System.Xml.Serialization.XmlIgnore]
        public object ObjetoAsociado
        {
            get
            {
                return this.objetoAsociado;
            }
            set
            {
                this.objetoAsociado = value;
            }
        }

        public short VelocidadTraslacion { get => velocidadTraslacion; set => velocidadTraslacion = value; }
        public short PosicionActual { get => posicionActual; set => posicionActual = value; }
        public short RadioRespectoSol { get => radioRespectoSol; set => radioRespectoSol = value; }
        public object ObjetoAsociado1 { get => objetoAsociado; set => objetoAsociado = value; }

        /// <summary>
        /// Avance del planeta según su velocidad
        /// </summary>
        public short Avanzar()
        {
            this.posicionActual += velocidadTraslacion;
            return this.posicionActual;
        }

        /// <summary>
        /// Simulación del movimiento del planeta
        /// </summary>
        public void AnimarSistemaSolar()
        {
            do
            {
                System.Threading.Thread.Sleep(60 + this.velocidadTraslacion);
                //Dispara el evento y manejador que esta asociado
                InformarAvance.Invoke(this, new PlanetaEventArgs(this.Avanzar(), radioRespectoSol));
            } while (true);
        }
    }
}
