using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_27
{
    class Program
    {
        //Pilas, Colas y Listas.
        static void Main(string[] args)
        {
            Random random = new Random();
            List<int> lista = new List<int>();
            Queue<int> cola = new Queue<int>();
            Stack<int> pila = new Stack<int>();

            for (int i = 0; i < 10; i++)
            {
                lista.Add(random.Next(-50, 50));
                cola.Enqueue(random.Next(-50, 50));
                pila.Push(random.Next(-50, 50));
            }

            lista.Sort();

            Console.WriteLine("***** LISTAS *****");
            foreach (int item in lista)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("***** COLAS *****");
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(cola.Dequeue());
            }            

            Console.WriteLine("***** PILAS *****");
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(pila.Pop());
            }
            Console.ReadKey();
        }
    }
}
