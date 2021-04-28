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
    public partial class FrmInforme : Form
    {
        

        public FrmInforme()
        {
            InitializeComponent();
            
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            RentaService vehiculoService = new RentaService();

            ConsultaResponse response = vehiculoService.Consultar();

            if (!response.Error)
            {
                dataGridViewRegistro.DataSource = response.Rentas;
            }
            else
            {
                MessageBox.Show(response.Mensaje, "ERROR AL ACTUALIZAR LOS DATOS ");
            }

        }
    }
}
