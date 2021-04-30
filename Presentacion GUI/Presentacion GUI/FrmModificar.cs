using BLL;
using Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static BLL.RentaService;

namespace Presentacion_GUI
{
    public partial class FrmModificar : Form
    {
        RentaService service;

        public FrmModificar()
        {
            InitializeComponent();
            service = new RentaService();
        }

        private void CbxTipoVehiculo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CbxTipoVehiculo.Text.Equals("TRACTOR"))
            {
                PnlTractor.Visible = true;
                PnlAutobus.Visible = false;
            }
            else if (CbxTipoVehiculo.Text.Equals("AUTOBUS"))
            {
                PnlAutobus.Visible = true;
                PnlTractor.Visible = false;
            }
        }

        private void TxtNumeroLiquidacion_Validating(object sender, CancelEventArgs e)
        {
            if(!CampoLiquidacion(TxtNumeroLiquidacion.Text, out string mensaje))
            {
                errorProviderLiquidacion.SetError(TxtNumeroLiquidacion, mensaje);
                e.Cancel = true;
            }
        }

        private bool CampoLiquidacion(string text, out string mensaje)
        {
            if (string.IsNullOrEmpty(text))
            {
                mensaje = "llene el campo";
                return false;
            }else if (!Int32 .TryParse(text, out int result))
            {
                mensaje = "Solo numeros";
                return false;
            }
            mensaje = "TODO BIEN";
            return true;
        }

        private void TxtNumeroLiquidacion_Validated(object sender, EventArgs e)
        {
            errorProviderLiquidacion.SetError(TxtNumeroLiquidacion, "");
        }

        private void CbxTipoVehiculo_Validating(object sender, CancelEventArgs e)
        {
            if (CbxTipoVehiculo.Text.Equals("Seleccionar"))
            {
                errorProviderLiquidacion.SetError(CbxTipoVehiculo,"Seleccione un Item");
                e.Cancel = true;
            }
        }

        private void CbxTipoVehiculo_Validated(object sender, EventArgs e)
        {
            errorProviderLiquidacion.SetError(CbxTipoVehiculo, "");
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            
            BusquedaResponse busqueda;

            busqueda = service.Buscar(Convert.ToInt32(TxtNumeroLiquidacion.Text));

            if (!busqueda.Error)
            {
                MessageBox.Show("Modifique los siguientes datos");
            }
            else
            {
                MessageBox.Show("No se Encontro Registro");
            }


        }

        private void modificarDatos()
        {
            RentaVehiculo renta;

            if (CbxTipoVehiculo.Text.Equals("TRACTOR"))
            {
                renta = new RentaTractor()
                {
                    NumeroLiquidacion = Convert.ToInt32(TxtNumeroLiquidacion.Text),
                    TipoVehiculo = "TRACTOR",
                    Placa = TxtPlaca.Text,
                    FechaRenta = dateTimeRenta.Value,
                    FechaDevocion = dateTimeDevolucion.Value,
                };
                renta.CalcularvalorRenta();
                service.Modificar(renta, Convert.ToInt32(TxtNumeroLiquidacion.Text));

            }
            else
            {
                renta = new RentaAutobus()
                {
                    NumeroLiquidacion = Convert.ToInt32(TxtNumeroLiquidacion.Text),
                    TipoVehiculo = "AUTOBUS",
                    Placa = TxtPlaca.Text,
                    KilometroRenta = Convert.ToInt32(TxtNumeroLiquidacion.Text),
                    KilometroDevolucion = Convert.ToInt32(TxtNumeroLiquidacion.Text),


                };

                service.Modificar(renta, Convert.ToInt32(TxtNumeroLiquidacion.Text));
            }

        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            if (ValidateChildren()) 
            {
                modificarDatos();
            }
            else
            {
                MessageBox.Show("Verifique Los Campos");
            }
        }
    }
}
