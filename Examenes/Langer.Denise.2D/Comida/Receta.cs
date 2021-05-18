using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comida
{
    public class Receta
    {
        public enum Tipo
        {
            Clasica,
            Especial
        }


        private int capacidad;
        private List<Ingredientes> ingredientes;
        static Tipo preparacion;


        public Tipo TipoPreparacion
        {
            set { preparacion = value; }
        }

        private Receta()
        {
            this.ingredientes = new List<Ingredientes>();
        }        
        
        static Receta()
        {
            preparacion = Tipo.Clasica;
        }

        public Receta(int capacidad)
        {
            this.capacidad = capacidad;
        }

        //CapacidadLibre retornará el espacio libre teniendo en cuenta los ingredientes de la Receta. Utilizar el concepto de Polimorfismo
        private int CapacidadLibre ()
        {
            foreach (Ingredientes item in ingredientes)
            {
                this.capacidad -= item.Cantidad;
            }
        }       
        
        private int CapacidadLibre (Ingredientes planta)
        {
            int result = 0;
            foreach (Ingredientes item in ingredientes)
            {
                if (planta is Pera)
                {
                    result = this.capacidad - item.Cantidad;
                } else if (planta is QuesoAzul)
                {
                    result = this.capacidad - item.Cantidad;
                } else if (planta is Rucula)
                {
                    result = this.capacidad - item.Cantidad;
                }
            }

        }

        public static bool operator + (Receta r, Ingredientes i)
        {

        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"RECETA: {preparacion}");
            sb.AppendLine($"Capacidad Libre: {this.CapacidadLibre()}");
            sb.AppendLine($"Capacidad Total: {this.capacidad}");
            foreach (Ingredientes item in ingredientes)
            {
                sb.AppendLine($"LISTA INGREDIENTES: {((Ingredientes)item).Informacion()}");
            }
            return base.ToString();
        }
    }
}
