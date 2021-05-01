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
                do 
                { 
                    if (repository.BuscarPorLiquidacion(tractor.NumeroLiquidacion) == null)
                    {
                        repository.Guardar(tractor);
                    }

                    tractor.GenerarLiquidacion();

                }while (repository.BuscarPorLiquidacion(tractor.NumeroLiquidacion) != null) ;

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
                do
                {
                    if (repository.BuscarPorLiquidacion(autobus.NumeroLiquidacion) == null)
                    {
                        repository.Guardar(autobus);
                    }

                    autobus.GenerarLiquidacion();

                } while (repository.BuscarPorLiquidacion(autobus.NumeroLiquidacion) != null);

                return $"Registro Exitoso";
            }
            catch (Exception e)
            {
                return $"Se preseto el siguente error {e.Message}";
            }
        }

        public string Eliminar(double liquidacion)
        {  
            try
            {
                if (repository.BuscarPorLiquidacion(liquidacion) != null) {
                    repository.Eliminar(liquidacion);
                    return $"Eliminacion Exitosa";
                }else
                    return $"No se encuentra Registro para Eliminar";

            }
            catch (Exception exception)
            {
                return $"Se preseto el siguente error {exception.Message}";
            }
        }


        public string Modificar(RentaVehiculo renta, double liquidacion)
        {
            try
            {
                if(repository.BuscarPorLiquidacion(liquidacion) != null)
                {
                    repository.Modificar(renta, liquidacion);

                    return $"Modificacion Exitosa";
                }
                return $"No se encuentra Registro para Modificar";

            }
            catch (Exception exception)
            {
                return $"Se preseto el siguente error {exception.Message}";
            }
        }

        //Buscar---------------------------------------------------------------------------------------------------------------------

        public BusquedaResponse Buscar(double liquidacion)
        {

            try
            {
                if (repository.BuscarPorLiquidacion(liquidacion) != null)
                {
                    return new BusquedaResponse(repository.BuscarPorLiquidacion(liquidacion));
                }
                else
                    return new BusquedaResponse("No se encontro el numero de liquidacion");
            }
            catch (Exception exception)
            {
                return new BusquedaResponse("Se presento el siguiente error: " + exception.Message);
            }
        }

        public class BusquedaResponse
        {
            public RentaVehiculo Renta { get; set; }
            public string Mensaje { get; set; }
            public bool Error { get; set; }

            public BusquedaResponse(RentaVehiculo nuevaRenta)
            {
                Renta = nuevaRenta;
                Error = false;
            }

            public BusquedaResponse(string mensaje)
            {
                Mensaje = mensaje;
                Error = true;
            }
        }

        //--------------------------------------------------------------------------------------------------------------------------------


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

        //Filtro----------------------------------------------------------------------------------------------------------------------

        public FiltroResponse ConsultaFiltro(string Tipo)
        {
            try
            {
                if (Tipo.Equals("TRACTOR"))
                {
                    return new FiltroResponse(repository.filtroTractor());
                }
                else
                {
                    return new FiltroResponse(repository.filtroAutobus());
                }

                    
            }
            catch (Exception exception)
            {
                return new FiltroResponse("Se presentó el siguiente error:" + exception.Message);
            }
        }


        public class FiltroResponse
        {

            public IEnumerable<RentaVehiculo> Filtro { get; set; }
            public string Mensaje { get; set; }
            public bool Error { get; set; }

            public FiltroResponse(IEnumerable<RentaVehiculo> filtroVehiculos)
            {
                Filtro = filtroVehiculos;
                Error = false;
            }

            public FiltroResponse(string mensaje)
            {
                Mensaje = mensaje;
                Error = true;
            }


        }


        //----------------------------------------------------------------------------------------------------------------------------


    }
}
