using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vehiculos;

namespace Ejercicio_49
{
    class Program
    {
        static void Main(string[] args)
        {
            AutoF1 auto1 = new AutoF1("Lannister", 10);
            AutoF1 auto2 = new AutoF1("Targaryan", 60, 180);

            MotoCross moto1 = new MotoCross("Stark", 80, 5);

            //VehiculoDeCarrera vehiculo = new VehiculoDeCarrera("Baratheon", 5);

            Competencia<AutoF1> carreraAutos = new Competencia<AutoF1>(4, 3, Competencia<AutoF1>.TipoCompetencia.F1);
            Competencia<MotoCross> carreraMotos = new Competencia<MotoCross>(6, 3, Competencia<MotoCross>.TipoCompetencia.MotoCross);

            //Competencia<AutoF1> carreraAutos = new Competencia<AutoF1>(2, 6, Competencia.TipoCompetencia.F1);
            //Competencia carreraMotos = new Competencia(5, 10, Competencia.TipoCompetencia.MotoCross);

            try
            {
                if (carreraMotos + auto1)
                    Console.WriteLine("Auto agregado con éxito");
                else
                    Console.WriteLine("No se pudo agregar");                

                //else
                //{
                //    Console.WriteLine("No se pueden AGREGAR Autos en competencias de Motos");
                //}

                if (carreraMotos + moto1)
                {
                    Console.WriteLine("Moto agregada con éxito");
                }
                else
                {
                    Console.WriteLine("No se pudo agregar");
                }

                Console.WriteLine(carreraMotos.MostrarDatos());

                if (carreraAutos + moto1)
                {
                    Console.WriteLine("Moto agregado con éxito");
                }
                else
                {
                    Console.WriteLine("No se pueden AGREGAR motos en competencias de AUTOS");
                }

                if (carreraAutos + auto1)
                {
                    Console.WriteLine("Auto agregado con éxito");
                }
                else
                {
                    Console.WriteLine("No se pudo agregar");
                }

                if (carreraAutos + auto2)
                {
                    Console.WriteLine("Auto agregado con éxito");
                }
                else
                {
                    Console.WriteLine("No se pudo agregar");
                }
            }
            catch (CompetenciaNoDisponibleException exCom)
            {
                Console.WriteLine(exCom.ToString());
            }


            Console.WriteLine(carreraAutos.MostrarDatos());

            Console.ReadKey();
        }
    }
}
