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
    public partial class FrmRegistrarAutobus : Form
    {
        RentaService service;
        FiltroResponse response;

        public FrmRegistrarAutobus()
        {
            InitializeComponent();
            service = new RentaService();
            llenartabla();
        }

        double kilometrorenta = 0;
        double kilometroDevolucion = 0;

        private void BtnrRegistrar_Click(object sender, EventArgs e)
        {
            if (ValidateChildren())
            {
                Camponumerico();
                enviarGuardar();
                llenartabla();

            }
            else
            {
                MessageBox.Show("Verifique Los Datos");
            }
        }

        private void llenartabla()
        {
            response = service.ConsultaFiltro("AUTOBUS");

            DGRegistrarAutobus.Rows.Clear();

            if (!response.Error)
            {
                //response.Filtro =

                ConfigurarGrid();

                DGRegistrarAutobus.Columns[0].Name = "Numero Liquidacion";
                DGRegistrarAutobus.Columns[1].Name = "Tipo Vehiculo";
                DGRegistrarAutobus.Columns[2].Name = "Placa";
                DGRegistrarAutobus.Columns[3].Name = "Total a Pagar";

                foreach (var i in response.Filtro)
                {
                    DGRegistrarAutobus.Rows.Add(i.NumeroLiquidacion, i.TipoVehiculo, i.Placa, i.ValorRenta);
                }

            }
        }

        private void ConfigurarGrid()
        {
            // Create an unbound DataGridView by declaring a column count.
            DGRegistrarAutobus.ColumnCount = 4;
            DGRegistrarAutobus.ColumnHeadersVisible = true;

            // Set the column header style.
            DataGridViewCellStyle columnHeaderStyle = new DataGridViewCellStyle();

            columnHeaderStyle.BackColor = Color.Beige;
            columnHeaderStyle.Font = new Font("Verdana", 9, FontStyle.Bold);
            DGRegistrarAutobus.ColumnHeadersDefaultCellStyle = columnHeaderStyle;
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

        private void TxtPlaca_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(TxtPlaca.Text))
            {
                errorProviderPlaca.SetError(TxtPlaca, "Llene el Campo");
                e.Cancel = true;
            }
        }

        private void TxtPlaca_Validated(object sender, EventArgs e)
        {
            errorProviderPlaca.SetError(TxtPlaca,"");
        }

        private void TxtKilometrosRenta_Validating(object sender, CancelEventArgs e)
        {
            if(!Camporenta(TxtKilometrosRenta,out string mensaje))
            {
                errorProviderRenta.SetError(TxtKilometrosRenta,mensaje);
                e.Cancel = true;
            }
            


        }

        private bool Camporenta(TextBox txtKilometros, out string mensaje)
        {
           
            if (string.IsNullOrEmpty(txtKilometros.Text))
            {
                mensaje = "Llene el campo";
                return false;

            }else if (!Int32.TryParse(txtKilometros.Text, out int result))
            {
                mensaje = "Solo Numeros";
                return false;
            }

            mensaje = "TODO BIEN";
            return true;


        }

        private void TxtKilometrosRenta_Validated(object sender, EventArgs e)
        {
            errorProviderRenta.SetError(TxtKilometrosRenta,"");
        }

        private void TxtKilometrosDevuelto_Validating(object sender, CancelEventArgs e)
        {
            if (!Camporenta(TxtKilometrosDevuelto, out string mensaje))
            {
                errorProviderDevolucion.SetError(TxtKilometrosDevuelto, mensaje);
                e.Cancel = true;

            }
        }
        private void TxtKilometrosDevuelto_Validated(object sender, EventArgs e)
        {
            errorProviderDevolucion.SetError(TxtKilometrosDevuelto, "");
        }
    }
}
