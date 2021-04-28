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
    public partial class FrmRegistrarAutobus : Form
    {
        public FrmRegistrarAutobus()
        {
            InitializeComponent();
        }

        Controller control = new Controller();
        double kilometrorenta = 0;
        double kilometroDevolucion = 0;

        private void BtnrRegistrar_Click(object sender, EventArgs e)
        {
            if (!TxtPlaca.Text.Equals(""))
            {
                if (Camponumerico())
                {
                    enviarGuardar();
                }
                else
                {
                    MessageBox.Show("EL CAMPO KILOMETRO SOLO PERMITE CARACTERES NUMERICOS");
                }
            }
            else
            {
                MessageBox.Show("INGRESE LA PLACA");
            }
        }

        private bool Camponumerico()
        {
            try
            {
                kilometrorenta = Convert.ToDouble(TxtKilometrosRenta.Text);
                kilometroDevolucion = Convert.ToDouble(TxtKilometrosDevuelto.Text);
                return true;

            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message.ToString());
                return false;
                
            }
        }

        private void enviarGuardar()
        {
            RentaAutobus autobus;
            RentaService service = new RentaService();

            autobus = new RentaAutobus()
            {
                Placa = TxtPlaca.Text,
                TipoVehiculo = "AUTOBUS",
                KilometroRenta = kilometrorenta,
                KilometroDevolucion = kilometroDevolucion,
            };
            autobus.GenerarLiquidacion();
            autobus.CalcularvalorRenta();
            MessageBox.Show(service.Guardar(autobus));

        }

    }
}
