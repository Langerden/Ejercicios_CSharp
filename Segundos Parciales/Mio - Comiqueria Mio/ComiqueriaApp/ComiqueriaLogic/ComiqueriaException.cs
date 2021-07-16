using ComiqueriaLogic.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComiqueriaLogic
{
    public class ComiqueriaException : Exception, IArchivoTexto
    {
        public ComiqueriaException(string message) : base(message)
        {
        }

        public ComiqueriaException(string message, Exception innerException) : base(message, innerException)
        {
            ArchivoTexto.Escribir(this, true);
        }


        public string Ruta
        {
            get { return $"{Environment.GetFolderPath(Environment.SpecialFolder.Desktop)}\\log.txt";}
        }


        public string Texto
        {
            get {
                StringBuilder sb = new StringBuilder();
                sb.AppendLine(DateTime.Now.ToString() + ":");
                sb.AppendLine(this.Message);
                Exception innerException = this.InnerException;
                while (innerException != null)
                {
                    sb.AppendLine(innerException.Message);
                    innerException = innerException.InnerException;
                }

                return sb.ToString();
            }
        }
    }
}
