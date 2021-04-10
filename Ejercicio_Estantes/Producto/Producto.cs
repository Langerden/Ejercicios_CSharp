using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Producto
{
    public class Producto
    {
        private string codigoDeBarra;
        private string marca;
        private float precio;

        public Producto(string marca, string codigoDeBarra, float precio)
        {
            this.codigoDeBarra = codigoDeBarra;
            this.marca = marca;
            this.precio = precio;
        }

        public static explicit operator string (Producto p)
        {
            if( p is null)
            {
                return "";
            }
            return p.codigoDeBarra;
        }

        public string GetMarca()
        {
            return this.marca;
        }

        public float GetPrecio()
        {
            return this.precio;
        }

        public static string MostrarProducto(Producto producto)
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine($"Codigo de Barras: {((string)producto)}");
            stringBuilder.AppendLine($"Marca: {producto.GetMarca()}");
            stringBuilder.AppendLine($"Precio: {producto.GetPrecio()}");
            return stringBuilder.ToString();         
        }

        public static bool operator == (Producto p1, string marca)
        {
            return (p1.GetMarca() == marca);
        }

        public static bool operator ==(Producto p1, Producto p2)
        {
            return (((string)p1 == (string)p2) && p1.GetMarca() == p2.GetMarca());
        }

        public static bool operator !=(Producto p1, string marca)
        {
            return !(p1 == marca);
        }

        public static bool operator !=(Producto p1, Producto p2)
        {
            return !(p1 == p2);
        }
    }
}
