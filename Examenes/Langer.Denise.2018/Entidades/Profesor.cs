using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{//Antigüedad devolverá la cantidad de tiempo, en días, desde la fecha de ingreso del profesor hasta la actualidad.
 //b.ValidarDocumentacion dará como válido cuando el documento tenga exactamente 8 caracteres.
    public class Profesor : Persona
    {
        private DateTime fechaIngreso;

        public Profesor(string nombre, string apellido, string documento) : base(nombre, apellido, documento)
        {
        }

        public Profesor(string nombre, string apellido, string documento, DateTime fechaIngreso) : this (nombre, apellido, documento)
        {
            this.fechaIngreso = fechaIngreso;
        }

        public int Antiguedad
        {
            get {
                TimeSpan timeSpan = DateTime.Now - this.fechaIngreso;
                return timeSpan.Days; }
        }

        public string ExponerDato()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"DATOS PERSONA: {base.ExponerDatos()} FECHA INGRESO: {this.Antiguedad}");
            return sb.ToString();
        }

        
        protected override bool ValidarDocumento(string doc)
        {
            if (doc.Length == 8)
                return true;
            else
                return false;
        }
    }
}
