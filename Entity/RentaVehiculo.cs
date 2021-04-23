using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public abstract class  RentaVehiculo
    {
        public double NumeroLiquidacion { get; set; }
        public string Placa { get; set; }
        public string TipoVehiculo { get; set; }
        public double ValorRenta { get; set; }



        public void GenerarLiquidacion()
        {
            var seed = Environment.TickCount;
            var random = new Random(seed);

            NumeroLiquidacion = random.Next(1000, 9999);

        }

        public abstract void CalcularvalorRenta();
        public abstract string Escribir();

    
    }
}
