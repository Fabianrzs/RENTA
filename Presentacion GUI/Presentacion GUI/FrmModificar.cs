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
    public partial class FrmModificar : Form
    {
        public FrmModificar()
        {
            InitializeComponent();
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
    }
}
