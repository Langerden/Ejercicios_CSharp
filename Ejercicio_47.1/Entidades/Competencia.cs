using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehiculos
{
    public class Competencia<T> where T : VehiculoDeCarrera
    {
        private short cantidadCompetidores;
        private short cantidadVueltas;
        private List<T> competidores;
        private TipoCompetencia tipo;


        private Competencia()
        {
            competidores = new List<T>();
        }

        public Competencia(short cantidadCompetidores, short cantidadVueltas, TipoCompetencia tipo) : this()
        {
            this.cantidadCompetidores = cantidadCompetidores;
            this.cantidadVueltas = cantidadVueltas;
            this.tipo = tipo;
        }

        public static bool operator ==(Competencia<T> c, VehiculoDeCarrera v)
        {
            bool equals = false;

            try
            {
                if (c.tipo is TipoCompetencia.MotoCross && v is MotoCross && c.competidores.Contains(v))
                    equals = true;
                else if (c.tipo is TipoCompetencia.F1 && v is AutoF1 && c.competidores.Contains(v))
                    equals = true;
            }
            catch (CompetenciaNoDisponibleException exComp)
            {
                throw new CompetenciaNoDisponibleException($"El vehículo no corresponde a la competencia del tipo {c.tipo}", "Competencia", "Competencia == VehiculoCarrera");
            }
            return equals;
        }

        public static bool operator !=(Competencia<T> c, VehiculoDeCarrera v)
        {
            return !(c == v);
        }


        public static bool operator +(Competencia<T> c, VehiculoDeCarrera v)
        {
            bool result = false;
            Random random = new Random();

            try
            {
                if (c.competidores.Count < c.cantidadCompetidores)
                {
                    if (c != v)
                    {
                        if ((c.tipo is TipoCompetencia.F1 && v is AutoF1) || (c.tipo is TipoCompetencia.MotoCross && v is MotoCross))
                        {
                            v.EnCompetencia = true;
                            v.VueltasRestantes = c.cantidadVueltas;
                            v.CantidadCombustible = (short)random.Next(15, 100);
                            c.competidores.Add((T)v);
                            result = true;
                        }
                    }
                }
            }
            catch (CompetenciaNoDisponibleException exCom)
            {
                throw new CompetenciaNoDisponibleException("Competencia incorrecta", exCom.NombreClase, exCom.NombreMetodo, exCom);
            }
            return result;
        }

        public static bool operator -(Competencia<T> c, VehiculoDeCarrera v)
        {
            bool result = false;

            if (c == v)
            {
                c.competidores.Remove((T)v);
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
