using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class RentaAutobus : RentaVehiculo
    {
        public double KilometroRenta { get; set; }
        public double KilometroDevolucion { get; set; }
        public double KilometrosRentados { get; set; }
        private const double valorKilometro = 40000;

        public double CalcularKilometros()
        {
            return KilometrosRentados = KilometroDevolucion - KilometroRenta;
        }

        public override void CalcularvalorRenta()
        {
            ValorRenta = CalcularKilometros() * valorKilometro;
        }

        public override string Escribir()
        {
            return $"{NumeroLiquidacion};{TipoVehiculo};{Placa};" +
                $"{KilometroRenta};{KilometroDevolucion};{valorKilometro};{ValorRenta}";
        }

    }
}
