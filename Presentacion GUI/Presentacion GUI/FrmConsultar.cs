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
    public partial class FrmConsultar : Form
    {

        RentaService service;
        FiltroResponse response;

        public FrmConsultar()
        {
            InitializeComponent();
            service = new RentaService();

        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            if (ValidateChildren())
            {
                llenartabla();
            }

        }

        private void llenartabla()
        {
            response = service.ConsultaFiltro(CbxTipoVehiculo.Text);

            DGConsultar.Rows.Clear();

            int result = 0; 

            if (!response.Error)
            {
                if(CbxTipoVehiculo.Text.Equals("TRACTOR"))
                {
                    agregarColumnas();
                    foreach (RentaTractor item in response.Filtro)
                    {
                        DGConsultar.Rows.Add(item.NumeroLiquidacion, item.TipoVehiculo, item.Placa,
                            item.FechaRenta, item.FechaDevocion, item.DiasRenta, item.ValorRenta);
                    }
                }else if (CbxTipoVehiculo.Text.Equals("AUTOBUS"))
                {
                    agregarColumnas();
                    foreach (RentaAutobus item in response.Filtro)
                    {
                        DGConsultar.Rows.Add(item.NumeroLiquidacion,item.TipoVehiculo, item.Placa,
                            item.KilometroRenta, item.KilometroDevolucion,item.KilometrosRentados,item.ValorRenta);
                    }
                }

            }
        }


        private void agregarColumnas()
        { 
            ConfigurarGrid();

            DGConsultar.Columns[0].Name = "Numero Liquidacion";
            DGConsultar.Columns[1].Name = "Tipo Vehiculo";
            DGConsultar.Columns[2].Name = "Placa";
            DGConsultar.Columns[3].Name = "Renta";
            DGConsultar.Columns[4].Name = "Devolucion";
            DGConsultar.Columns[5].Name = "valor Renta";
            DGConsultar.Columns[6].Name = "Total a Pagar";
        }

        private void ConfigurarGrid()
        {
            // Create an unbound DataGridView by declaring a column count.
            DGConsultar.ColumnCount = 7;
            DGConsultar.ColumnHeadersVisible = true;

            // Set the column header style.
            DataGridViewCellStyle columnHeaderStyle = new DataGridViewCellStyle();

            columnHeaderStyle.BackColor = Color.Beige;
            columnHeaderStyle.Font = new Font("Verdana", 9, FontStyle.Bold);
            DGConsultar.ColumnHeadersDefaultCellStyle = columnHeaderStyle;
        }

        private void CbxTipoVehiculo_Validating(object sender, CancelEventArgs e)
        {
            if (CbxTipoVehiculo.Text.Equals("Seleccionar"))
            {
                errorProviderTipo.SetError(CbxTipoVehiculo, "Seleccione un Item");
                e.Cancel = true;
            }
        }

        private void CbxTipoVehiculo_Validated(object sender, EventArgs e)
        {
            errorProviderTipo.SetError(CbxTipoVehiculo, "");
        }

    }
}
