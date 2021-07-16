namespace Entidades
{
    public class Cliente
    {
        private string nombre;
        private int numero;

        /// <summary>
        /// Constructor por defecto del cliente
        /// </summary>
        public Cliente()
        {

        }

        /// <summary>
        /// Constructor que recibe como parametro el nombre del cliente
        /// </summary>
        /// <param name="nombre"></param>
        public Cliente(string nombre)
        {
            this.nombre = nombre;
        }

        /// <summary>
        /// Propiedad de Lectura y Escritura para el atributo nombre
        /// </summary>
        public string Nombre { get => nombre; set => nombre = value; }

        /// <summary>
        /// Propiedad de Lectura y Escritura para el atributo numero
        /// </summary>
        public int Numero { get => numero; set => numero = value; }
    }
}
