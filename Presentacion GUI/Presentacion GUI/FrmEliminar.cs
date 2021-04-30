using BLL;
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
    public partial class FrmEliminar : Form
    {

        RentaService service;
        public FrmEliminar()
        {
            InitializeComponent();
            service = new RentaService();
            llenartabla();
        }

        private void llenartabla()
        {
            ConsultaResponse response = service.Consultar();

            if (!response.Error)
            {
                DGEliminar.DataSource = response.Rentas;
            }
        }

        private void TxtNumeroLiquidacion_Validating(object sender, CancelEventArgs e)
        {

            if (!validarID(TxtNumeroLiquidacion.Text, out string Mensaje))
            {
                errorProviderNumeroLiquidacion.SetError(TxtNumeroLiquidacion, Mensaje);
                e.Cancel = true;
            }

        }

        private bool validarID(string liquidacion, out string Mensaje)
        {
            bool var = Int32.TryParse(liquidacion, out int numero);

            if (string.IsNullOrEmpty(liquidacion))
            {
                Mensaje = "Llene el Campo";
                return false;
            }else if (!var)
            {
                Mensaje = "Campo solo permite numeros";
                return false;
            }
            

            Mensaje = "Todo Correcto";
            return true;

        }

        private void TxtNumeroLiquidacion_Validated(object sender, EventArgs e)
        {
            errorProviderNumeroLiquidacion.SetError(TxtNumeroLiquidacion,"");
        }

        private void TxtConfirmarLiquidacion_Validating(object sender, CancelEventArgs e)
        {
            if (!validarID(TxtNumeroLiquidacion.Text, TxtConfirmarLiquidacion.Text ,out string Mensaje))
            {
                errorProviderNumeroLiquidacion.SetError(TxtConfirmarLiquidacion, Mensaje);
                e.Cancel = true;
            }
        }

        private bool validarID(string text, string txtConfirmar, out string mensaje)
        {
            if (string.IsNullOrEmpty(txtConfirmar))
            {
                mensaje = "CONFIRME LIQUIDACION";
                return false;
            }else if (!text.Equals(txtConfirmar))
            {
                mensaje = " NO COINSIDE EL NUMERO DE LIQUIDACION";
                return false;
            }

            mensaje = "Todo Correcto";
            return true;
        }

        private void TxtConfirmarLiquidacion_Validated(object sender, EventArgs e)
        {
            errorProviderNumeroLiquidacion.SetError(TxtConfirmarLiquidacion, "");
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            if (ValidateChildren())
            {
                Int32.TryParse(TxtNumeroLiquidacion.Text, out int result);
                MessageBox.Show(service.Eliminar(Convert.ToInt32(TxtNumeroLiquidacion.Text)));
                llenartabla();
            }
            else
            {
                MessageBox.Show("Compruebe los Campos");
            }
        }
    }
}
