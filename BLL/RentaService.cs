using DAL;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class RentaService
    {

        RentaRepository repository = new RentaRepository();

        public RentaService()
        {
            repository = new RentaRepository();
        }

        public String Guardar (RentaTractor tractor)
        {
            try
            {
                repository.Guardar(tractor);
                return $"Registro Exitoso";
            }
                
            catch(Exception e)
            {
                return $"Se preseto el siguente error {e.Message}";
            }   
        }


        public String Guardar(RentaAutobus autobus)
        {
            try
            {
                repository.Guardar(autobus);
                return $"Registro Exitoso";
            }

            catch (Exception e)
            {
                return $"Se preseto el siguente error {e.Message}";
            }
        }


        //Consultar-----------------------------------------------------------------------------------------------------------------

        public ConsultaResponse Consultar()
        {
            try
            {
                return new ConsultaResponse(RentaRepository.Consultar());
            }
            catch (Exception exception)
            {
                return new ConsultaResponse("Se presentó el siguiente error:" + exception.Message);
            }
        }

        public class ConsultaResponse
        {
            public List<RentaVehiculo> Rentas { get; set; }
            public string Mensaje { get; set; }
            public bool Error { get; set; }

            public ConsultaResponse(List<RentaVehiculo> vehiculosRentados)
            {
                Rentas = vehiculosRentados;
                Error = false;
            }

            public ConsultaResponse(string mensaje)
            {
                Mensaje = mensaje;
                Error = true;
            }

        }
        //----------------------------------------------------------------------------------------------------------------------------

    }
}
