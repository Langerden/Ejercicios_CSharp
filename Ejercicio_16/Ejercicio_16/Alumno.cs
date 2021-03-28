using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_16
{
    public class Alumno
    {
        private byte nota1;
        private byte nota2;
        private float notaFinal;
        private string apellido;
        private int legajo;
        private string nombre;

        public Alumno(string apellido, int legajo, string nombre)
        {
            this.apellido = apellido;
            this.legajo = legajo;
            this.nombre = nombre;
        }

        public void Estudiar (byte notaIngresada1, byte notaIngresada2)
        {
            this.nota1 = notaIngresada1;
            this.nota2 = notaIngresada2;
        }

        public void CalcularFinal()
        {
            float notaFinal = -1;

            if (this.nota1 >= 4 && this.nota2 >= 4)
            {
                Random nota = new Random();
                notaFinal = nota.Next(5, 10);
            }
            this.notaFinal = notaFinal;       
        }
        public string Mostrar()
        {
            string datoAlumno = $"Nota 1: {this.nota1}, Nota 2: {this.nota2}, Apellido: {this.apellido}, Nombre:{this.nombre}, Legajo:{this.legajo}\t";
            if (this.notaFinal != -1)
                datoAlumno += $"Nota Final: {this.notaFinal}";
            else
                datoAlumno += "Alumno desaprobado";
            return datoAlumno;
        }
    }
}
