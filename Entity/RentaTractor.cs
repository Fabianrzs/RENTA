using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    
    public class RentaTractor : RentaVehiculo
    {
        public DateTime FechaRenta { get; set; }
        public DateTime FechaDevocion { get; set; }
        public int DiasRenta { get; set; }
        public const double valorDia = 40000;

        public int CalcularDias()
        {
            TimeSpan difFechas = FechaDevocion - FechaRenta;
            return DiasRenta = difFechas.Days;
        }

        public override void CalcularvalorRenta()
        {
            ValorRenta = CalcularDias() * DiasRenta;
        }

        public override string Escribir()
        {
            return $"{NumeroLiquidacion};{TipoVehiculo};{Placa};" +
                $"{FechaRenta};{FechaDevocion};{valorDia};{ValorRenta}";
        }


    }

}
