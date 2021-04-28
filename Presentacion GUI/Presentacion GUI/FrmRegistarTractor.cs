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

namespace Presentacion_GUI
{
    public partial class FrmRegistarTractor : Form
    {
        public FrmRegistarTractor()
        {
            InitializeComponent();
        }
        
        Controller control = new Controller();
        
        private void BtnrRegistrar_Click(object sender, EventArgs e)
        {
            if(control.campoIngresadosTractor(TxtPlaca.Text, dateTimeRenta.Value, dateTimeDevolucion.Value))
            {
                enviarGuardar();
            }
            else
            {
                MessageBox.Show("LLENE TODOS LOS CAMPOS\nCONFIRME LA FECHA");
            }

        }

        private void enviarGuardar()
        {    
            RentaTractor tractor;
            RentaService service = new RentaService();

            tractor = new RentaTractor()
            {
                Placa = TxtPlaca.Text,
                TipoVehiculo = "TRACTOR",
                FechaRenta = dateTimeRenta.Value,
                FechaDevocion = dateTimeDevolucion.Value,
            };
            tractor.GenerarLiquidacion();
            tractor.CalcularvalorRenta();   
            MessageBox.Show(service.Guardar(tractor));
          
        }
    }
}
