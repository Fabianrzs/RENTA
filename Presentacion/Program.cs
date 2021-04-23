﻿using BLL;
using Entity;
using System;
using static BLL.RentaService;

namespace Presentacion
{
    class Program
    {

        public static RentaService service;

        static void Main(string[] args)
        {
            Menue();
        }

        private static void Menue()
        {
            int opc = 0;

            do
            {

                Console.WriteLine("\t\t\tmenu de Opciones\n");
                Console.WriteLine("\t1) Ingresar Datos");
                Console.WriteLine("\t2) Consultar Datos");
                opc = Convert.ToInt32(Console.ReadLine());

                switch (opc)
                {
                    case 1:
                        capturarDatos();
                        break;
                    case 2:
                        Consultar();
                        break;

                }

            } while (opc != 3);
        }

        private static void capturarDatos()
        {
            int tipoVehiculo = 0;

            do
            {
                Console.WriteLine("\tVehiculo a Rentar\n \t1: Tractor\n \t2: AutoBus ");
                tipoVehiculo = Convert.ToInt32(Console.ReadLine());

            } while (tipoVehiculo != 1 && tipoVehiculo != 2);

            if (tipoVehiculo == 1)
                rentarTractor();
            else if (tipoVehiculo == 2)
                rentarAutobus();

        }

        private static void rentarAutobus()
        {
            service = new RentaService();

            RentaAutobus autobus;
            string placa;
            
            Console.WriteLine("Vehiculo Autobus");

            Console.WriteLine("Placa del Vehiculo");
            placa = Console.ReadLine();

            double kilometrorenta, kilometrodevolucion;
            Console.WriteLine("Kilometraje al Rentar");

            kilometrorenta = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Kilometreje al Devolver");

            kilometrodevolucion = Convert.ToDouble(Console.ReadLine());
            autobus = new RentaAutobus()
            {
                Placa = placa,
                TipoVehiculo = "Autobus",
                KilometroRenta = kilometrorenta,
                KilometroDevolucion = kilometrodevolucion,
            };
            autobus.GenerarLiquidacion();
            autobus.CalcularvalorRenta();
            Console.WriteLine($"Numero de Liquidadcion {autobus.NumeroLiquidacion}");
            service.Guardar(autobus);
        }

        private static void rentarTractor()
        {
            service = new RentaService();

            RentaTractor tractor;

            string placa;
            DateTime fecharenta, fechadevocion;

            Console.WriteLine("Vehiculo Tractor");
            
            Console.WriteLine("Placa del Vehiculo");
            placa = Console.ReadLine();

            Console.Write("Ejemplo Fecha (2012-12-12 ) \n");
            Console.WriteLine("Fecha inicio de Renta");
            fecharenta = Convert.ToDateTime(Console.ReadLine());

            Console.WriteLine("Fecha de Devolucion");
            fechadevocion = Convert.ToDateTime(Console.ReadLine());

            tractor = new RentaTractor()
            {
                Placa = placa,
                TipoVehiculo = "Tractor",
                FechaRenta = fecharenta,
                FechaDevocion = fechadevocion,
            };
            tractor.GenerarLiquidacion();
            tractor.CalcularvalorRenta();
            Console.WriteLine($"Numero de Liquidadcion {tractor.NumeroLiquidacion}");
            service.Guardar(tractor);
        }

        private static void Consultar()
        {
            RentaService vehiculoService = new RentaService();

            ConsultaResponse response = vehiculoService.Consultar();

            if (!response.Error)
            {

                foreach (var item in response.Rentas)
                {

                    Console.WriteLine(item.Escribir());

                }
            }
            else
            {
                Console.WriteLine(response.Mensaje);
            }
            Console.ReadKey();
        }
    }
}