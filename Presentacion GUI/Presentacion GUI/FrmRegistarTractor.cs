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
    public partial class FrmRegistarTractor : Form
    {

        RentaService service;
        FiltroResponse response;

        public FrmRegistarTractor()
        {
            InitializeComponent();
            service = new RentaService();
            llenartabla();

        }

        private void BtnrRegistrar_Click(object sender, EventArgs e)
        {
            if (ValidateChildren())
            {
                enviarGuardar();
                llenartabla();
            }
            else
            {
                MessageBox.Show("verifique los Datos");
            }

        }

        private void llenartabla()
        {
            response = service.ConsultaFiltro("TRACTOR");

            DGRegistrarTractor.Rows.Clear();

            if (!response.Error)
            {
                //response.Filtro =

                ConfigurarGrid();

                DGRegistrarTractor.Columns[0].Name = "Numero Liquidacion";
                DGRegistrarTractor.Columns[1].Name = "Tipo Vehiculo";
                DGRegistrarTractor.Columns[2].Name = "Placa";
                DGRegistrarTractor.Columns[3].Name = "Total a Pagar";

                foreach (var i in response.Filtro)
                {
                    DGRegistrarTractor.Rows.Add(i.NumeroLiquidacion, i.TipoVehiculo, i.Placa, i.ValorRenta);
                }

            }
        }

        private void ConfigurarGrid()
        {
            // Create an unbound DataGridView by declaring a column count.
            DGRegistrarTractor.ColumnCount = 4;
            DGRegistrarTractor.ColumnHeadersVisible = true;

            // Set the column header style.
            DataGridViewCellStyle columnHeaderStyle = new DataGridViewCellStyle();

            columnHeaderStyle.BackColor = Color.Beige;
            columnHeaderStyle.Font = new Font("Verdana", 9, FontStyle.Bold);
            DGRegistrarTractor.ColumnHeadersDefaultCellStyle = columnHeaderStyle;
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

        private void TxtPlaca_Validating(object sender, CancelEventArgs e)
        {
            if(!ValidateCampos(TxtPlaca.Text, out string mensaje))
            {
                errorProviderPlaca.SetError(TxtPlaca, mensaje);
                e.Cancel = true;
            }

        }

        private bool ValidateCampos(string text, out string mensaje)
        {
            if (string.IsNullOrEmpty(text))
            {
                mensaje = "llene el Campo";
                return false;
            }

            mensaje = "Todo bien";
            return true;
        }

        private void TxtPlaca_Validated(object sender, EventArgs e)
        {
            errorProviderPlaca.SetError(TxtPlaca,"");
        }
    }
}
