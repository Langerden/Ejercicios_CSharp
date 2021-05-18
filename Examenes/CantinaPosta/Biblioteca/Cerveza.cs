using System.Text;

namespace Entidades
{
    public class Cerveza : Botella
    {
        private const int MEDIDA = 330;
        private Tipo tipo;

        public Cerveza(int capacidadML, int contenidoML, string marca) : base(capacidadML, contenidoML, marca)
        {
            this.tipo = Tipo.Vidrio;
        }

        public Cerveza(int capacidadML, int contenidoML, string marca, Tipo tipo) : this(capacidadML, contenidoML, marca)
        {
            this.tipo = tipo;
        }
        protected string GenerarInforme()
        {
            StringBuilder sb = new StringBuilder();
            return sb.Append($"{base.ToString()} MEDIDA: {MEDIDA}").ToString();
        }

        public override int ServirMedida()
        {
            if (MEDIDA <= Contenido)
                return Contenido -= (int)(MEDIDA * 0.8);
            else
                return Contenido = 0;
        }

        public static implicit operator Tipo(Cerveza c)
        {
            return c.tipo;
        }

    }
}
