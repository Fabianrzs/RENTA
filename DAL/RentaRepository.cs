using Entity;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class RentaRepository
    {

        static string ruta = "Renta de Vehiculo.txt";

        public void Guardar(RentaTractor tractor)
        {
            FileStream file = new FileStream(ruta, FileMode.Append);
            StreamWriter writer = new StreamWriter(file);
            writer.WriteLine(tractor.Escribir());
            writer.Close();
            file.Close();
        }

        public void Guardar(RentaAutobus autobus)
        {
            FileStream file = new FileStream(ruta, FileMode.Append);
            StreamWriter writer = new StreamWriter(file);
            writer.WriteLine(autobus.Escribir());
            writer.Close();
            file.Close();
        }

        private static RentaVehiculo MapearVehiculo(string linea)
        {
            string [] datosVehiculo = linea.Split(';');


            if (datosVehiculo[1].ToUpper().Equals("AUTOBUS"))
            {
                RentaVehiculo vehiculo = new RentaAutobus()
                {
                    NumeroLiquidacion = Convert.ToDouble(datosVehiculo[0]),
                    TipoVehiculo = datosVehiculo[1],
                    Placa = datosVehiculo[2],
                    KilometroRenta = Convert.ToDouble(datosVehiculo[3]),
                    KilometroDevolucion = Convert.ToDouble(datosVehiculo[4]),
                    KilometrosRentados = Convert.ToDouble(datosVehiculo[5]),
                    ValorRenta = Convert.ToDouble(datosVehiculo[6]),

                };
                return vehiculo;
            }
            else
            {
                RentaVehiculo vehiculo = new RentaTractor()
                {
                    NumeroLiquidacion = Convert.ToDouble(datosVehiculo[0]),
                    TipoVehiculo = datosVehiculo[1],
                    Placa = datosVehiculo[2],
                    FechaRenta = Convert.ToDateTime(datosVehiculo[3]),
                    FechaDevocion = Convert.ToDateTime(datosVehiculo[4]),
                    DiasRenta = Convert.ToInt32(datosVehiculo[5]),
                    ValorRenta = Convert.ToDouble(datosVehiculo[6]),
                };

                return vehiculo;
            }
        }



        public static List<RentaVehiculo> Consultar()
        {
            List<RentaVehiculo> vehiculos = new List<RentaVehiculo>();
            FileStream file = new FileStream(ruta, FileMode.OpenOrCreate);
            StreamReader lector = new StreamReader(file);
            string linea = "";
            while ((linea = lector.ReadLine()) != null)
            {
                RentaVehiculo vehiculo = MapearVehiculo(linea);
                vehiculos.Add(vehiculo);
            }
            lector.Close();
            file.Close();
            return vehiculos;
        }

        public RentaVehiculo BuscarPorLiquidacion(double Liquidacion)
        {
            foreach(var item in Consultar())
            {
                if (item.NumeroLiquidacion.Equals(Liquidacion))
                    return item;        
            }

            return null;

        }

        public void Eliminar(double liquidacion )
        {
            List<RentaVehiculo> Rentas = Consultar();
            FileStream file = new FileStream(ruta, FileMode.Create);
            file.Close();
            foreach(var item in Rentas)
            {
                if(!item.NumeroLiquidacion.Equals(liquidacion))
                {
                    if (item.TipoVehiculo.Equals("TRACTOR"))
                    {
                        Guardar((RentaTractor)item);
                    }else if (item.TipoVehiculo.Equals("AUTOBUS"))
                    {
                        Guardar((RentaAutobus)item);
                    }

                    
                }
            }


        }

        public void Modificar (RentaVehiculo renta, double Liquidacion)
        {



        }


    }
}
/*if (item.TipoVehiculo.Equals("TRACTOR"))

                    else if (item.TipoVehiculo.Equals("AUTOBUS"))*/