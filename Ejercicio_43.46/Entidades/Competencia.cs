using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehiculos
{
    public class Competencia
    {
        private short cantidadCompetidores;
        private short cantidadVueltas;
        private List<VehiculoDeCarrera> competidores;
        private TipoCompetencia tipo;


        private Competencia()
        {
            competidores = new List<VehiculoDeCarrera>();
        }

        public Competencia(short cantidadCompetidores, short cantidadVueltas, TipoCompetencia tipo) : this()
        {
            this.cantidadCompetidores = cantidadCompetidores;
            this.cantidadVueltas = cantidadVueltas;
            this.tipo = tipo;
        }

        public static bool operator ==(Competencia c, VehiculoDeCarrera v)
        {
                bool equals = false;
                foreach (VehiculoDeCarrera item in c.competidores)
                {
                    if (c.tipo == TipoCompetencia.F1 && v is AutoF1 && ((AutoF1)v) == ((AutoF1)item))
                    {
                        equals = true;
                        break;
                    }
                    else if (c.tipo == TipoCompetencia.MotoCross && v is MotoCross && ((MotoCross)v) == ((MotoCross)item))
                    {
                        equals = true;
                        break;
                    } else
                    {
                        throw new CompetenciaNoDisponibleException($"El vehículo: {item} no corresponde a la competencia del tipo {c.tipo}", "Competencia", "Competencia == VehiculoCarrera");
                    }
                }
                return equals;
        }

        public static bool operator !=(Competencia c, VehiculoDeCarrera v)
        {
            return !(c == v);
        }


        public static bool operator +(Competencia c, VehiculoDeCarrera v)
        {
            bool result = false;
            Random random = new Random();

            try
            {
                if (c.cantidadCompetidores > 0 && c.competidores.Count < c.cantidadCompetidores)
                {
                    if ((c != v) && ((c.tipo == TipoCompetencia.F1 && v is AutoF1) || (c.tipo == TipoCompetencia.MotoCross && v is MotoCross)))
                    {
                        v.EnCompetencia = true;
                        v.VueltasRestantes = c.cantidadVueltas;
                        v.CantidadCombustible = (short)random.Next(15, 100);
                        c.competidores.Add(v);
                        result = true;
                    }
                }
            }
            catch (CompetenciaNoDisponibleException exCom)
            {
                throw new CompetenciaNoDisponibleException ("Competencia incorrecta", exCom.NombreClase, exCom.NombreMetodo, exCom);
            }
            return result;
        }

        public static bool operator -(Competencia c, VehiculoDeCarrera v)
        {
            bool result = false;

            if (c == v)
            {
                c.competidores.Remove(v);
                result = true;
            }
            return result;
        }

        public string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"CANTIDAD COMPETIDORES: {this.cantidadCompetidores}, VUELTAS: {this.cantidadVueltas}, TIPO COMPETENCIA: {this.tipo}");
            sb.AppendLine("DATOS VEHICULO");
            foreach (VehiculoDeCarrera vehiculo in this.competidores)
            {
                sb.AppendLine(vehiculo.MostrarDatos());
            }
            return sb.ToString();
        }

        public enum TipoCompetencia
        {
            F1,
            MotoCross
        }
    }
}
