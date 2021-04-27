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
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private Form frmActual = null;
        private void AbrirFromHijo(Form frmHijo)
        {
            if (frmActual != null)
            {
                if (frmActual.GetType() != frmHijo.GetType())
                {
                    frmActual.Close();
                    frmActual = frmHijo;
                    frmHijo.TopLevel = false;
                    frmHijo.Dock = DockStyle.Fill;
                    PnlContenedor.Controls.Add(frmHijo);
                    PnlContenedor.Tag = frmHijo;
                    frmHijo.BringToFront();
                    frmHijo.Show();
                }
            }
            else
            {
                frmActual = frmHijo;
                frmHijo.TopLevel = false;
                frmHijo.Dock = DockStyle.Fill;
                PnlContenedor.Controls.Add(frmHijo);
                PnlContenedor.Tag = frmHijo;
                frmHijo.BringToFront();
                frmHijo.Show();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void BtnConsultar_Click(object sender, EventArgs e)
        {
            AbrirFromHijo(new FrmConsultar());
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            frmActual.Close();
            PnlContenedor.Visible = true;
        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            AbrirFromHijo(new FrmModificar());
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            AbrirFromHijo(new FrmEliminar());
        }

        private void BtnInforme_Click(object sender, EventArgs e)
        {
            AbrirFromHijo(new FrmInforme());
        }
    }
}
