using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class Dispositivo
    {
        static List<Aplicacion> appInstaladas;
        static ESistemaOperativo sistemaOp;

        /// <summary>
        /// Constructor estatico del Dispositivo
        /// </summary>
        static Dispositivo()
        {
            appInstaladas = new List<Aplicacion>();
            sistemaOp = ESistemaOperativo.ANDROID;
        }

        /// <summary>
        /// Muestra toda la información del dispositivo, junto con el detalle de sus aplicaciones instaladas.
        /// </summary>
        /// <returns>Los datos del dispositivo y sus app</returns>
        public static string InformacionDispositivo()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"SO del Dispositivo: {sistemaOp}");
            sb.AppendLine($"Lista Aplicaciones:");
            foreach (Aplicacion item in Dispositivo.appInstaladas)
            {
                sb.AppendLine(item.InfoApp());
            }
            return sb.ToString();
        }

        /// <summary>
        /// Valida que la Aplicacion ingresada como parametro tenga el mismo SO que el Dispositivo para poder agregarlo a la lista estatica.        
        /// </summary>
        /// <param name="app">App a instalarse</param>
        /// <returns>True si lo agrega, false en caso contrario</returns>
        public static bool InstalarApp(Aplicacion app)
        {
            if (app.ESistemaOperativo == Dispositivo.sistemaOp)
            {
                if (Dispositivo.appInstaladas + app)
                    return true;
            }
            return false;
        }

        public enum ESistemaOperativo
        {
            ANDROID,
            IOS
        }
    }
}
