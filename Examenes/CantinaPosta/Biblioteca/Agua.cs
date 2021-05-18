using System.Text;

namespace Entidades
{
    public class Agua : Botella
    {
        private const int MEDIDA = 400;

        public Agua(int capacidadML, int contenidoML, string marca) : base(capacidadML, contenidoML, marca)
        {
        }

        protected string GenerarInforme()
        {
            StringBuilder sb = new StringBuilder();
            return sb.Append($"{base.ToString()} MEDIDA: {MEDIDA}").ToString();
        }

        public override int ServirMedida()
        {
            return this.ServirMedida(MEDIDA);
        }

        public int ServirMedida(int medida)
        {
            if (medida <= this.Contenido)
                return this.Contenido -= medida;
            else
                return this.Contenido = 0;
        }
    }
}
