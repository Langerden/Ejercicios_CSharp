using System.Text;

namespace Entidades
{
    public abstract class Botella
    {
        protected int capacidadML;
        protected int contenidoML;
        protected string marca;

        protected Botella(int capacidadML, int contenidoML, string marca)
        {
            if (capacidadML < contenidoML)
                this.contenidoML = capacidadML;
            else
            {
                this.capacidadML = capacidadML;
            }
            this.contenidoML = contenidoML;
            this.marca = marca;
        }

        public int CapacidadLitros
        {
            get
            {
                return this.capacidadML / 1000;
            }
        }

        public int Contenido
        {
            get { return this.contenidoML; }
            set { this.contenidoML = value; }
        }

        public float PorcentajeContenido
        {
            get
            {
                return (this.contenidoML * 100 / this.capacidadML);

            }
        }

        //g. GenerarInforme utilizará StringBuilder para retornar todos los datos de la botella.
        protected string GenerarInforme()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"CONTENIDO :  {Contenido} CAPACIDAD : {CapacidadLitros} MARCA: {this.marca} PORCENTAJE: {PorcentajeContenido}");
            return sb.ToString();
        }

        public abstract int ServirMedida();

        public override string ToString()
        {
            return this.GenerarInforme();
        }

        public enum Tipo
        {
            Plastico,
            Vidrio
        }
    }
}




