using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Producto
{
    public class Estante
    {
        private Producto[] productos;
        private int ubicacionEstante;

        private Estante (int capacidad)
        {
            this.productos = new Producto[capacidad];
        }
        public Estante(int capacidad, int ubicacionEstante) : this (capacidad)
        {            
            this.ubicacionEstante = ubicacionEstante;
        }

        public Producto[] GetProductos()
        {
            return this.productos;
        }

        public static string MostrarEstante (Estante e)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Estante ubicacion: " + e.ubicacionEstante);
            foreach (Producto producto in e.GetProductos())
            {
                if (!(producto is null))
                {
                    sb.AppendLine(Producto.MostrarProducto(producto));
                }
            }
            return sb.ToString();
        }

        public static bool operator != (Estante e, Producto p)
        {
            return !(e == p);
        }

        public static Estante operator -(Estante e, Producto p)
        {       
                for (int i = 0; i < e.GetProductos().Length; i++)
                {
                    if (e.GetProductos()[i] == p)
                    {
                        e.productos[i] = null;
                        break;
                    }
                }            
            return e;
        }       
        
        public static bool operator + (Estante e, Producto p)
        {   
            if (e != p)
            {
                for (int i = 0; i < e.GetProductos().Length; i++)
                {
                    if (e.GetProductos()[i] is null)
                    {
                        e.productos[i] = p;
                        return true;
                    }
                }
            }
            return false;
        }

        public static bool operator ==(Estante e, Producto p)
        {
            bool result = false;

            if (!(e.productos.Contains(p)))
            {
                for (int i = 0; i < e.productos.Length; i++)
                {
                    if (e.productos[i] == p)
                    {
                        result = true;
                    }
                }
            }
            return result;
        }
    }
}
