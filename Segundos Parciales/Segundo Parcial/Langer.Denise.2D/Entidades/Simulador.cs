using System;
using System.Threading;

namespace Entidades
{
    public delegate void Atender(Cliente cliente);
    public class Simulador
    {
        private Comercio comercio;
        public event Atender MostrarInfo;
        private Thread hiloSimulador;
        private Random random;
        private int atendido;
        private int noAtendidos;

        /// <summary>
        /// Propiedad de Lectura y Escritura para el atributo atendido
        /// </summary>
        public int Atendido { get => atendido; set => atendido = value; }

        /// <summary>
        /// Propiedad de Lectura y Escritura para el atributo noAtendidos
        /// </summary>
        public int NoAtendidos { get => noAtendidos; set => noAtendidos = value; }

        /// <summary>
        /// Constructor del Simulador que recibe una instancia de Comerio.
        /// Instancia e inicializa los atributos comericio, atentido, noAtendidos y random.
        /// </summary>
        /// <param name="comercio"></param>
        public Simulador(Comercio comercio)
        {
            this.comercio = comercio;
            this.Atendido = 0;
            this.NoAtendidos = 0;
            this.random = new Random();
        }

        /// <summary>
        /// Metodo que se utilizará para instanciar el thread secundario y lo inicia.
        /// </summary>
        public void IniciarHilo()
        {
            this.hiloSimulador = new Thread(MostrarDatos);
            this.hiloSimulador.Start();
        }

        /// <summary>
        /// Metodo que correrá en un hilo secundario. Utilizará el metodo LlamarCliente para obtener el primer cliente de la lista de comercio
        /// e invocará el evento, el cual mostrará los datos (numero - nombre), haciendo un Thread.Sleep cada 2 segundos.
        /// Genera el numero random de 0 a 10 y setteará el valor en la propiedad para luego insertar informacion en la base de datos.
        /// </summary>
        public void MostrarDatos()
        {
            try
            {
                if (this.comercio.Clientes.Count > 0)
                {
                    for (int i = this.comercio.Clientes.Count; i > 0; i--)
                    {

                        Cliente aux = this.comercio.LlamarCliente();
                        this.MostrarInfo.Invoke(aux);
                        int valor = random.Next(0, 10);

                        if (valor < 5)
                            NoAtendidos++;
                        else
                            Atendido++;

                        Thread.Sleep(2000);
                    }
                }
            }
            catch (SinClientesExcepcion)
            {
                throw new SinClientesExcepcion("Ya no hay mas clientes");
            }
        }
    }
}
