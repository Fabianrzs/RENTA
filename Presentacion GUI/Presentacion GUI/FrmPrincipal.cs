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
        private int eventoActivo;
        private int ubicacionMausex;
        private int ubicacionMausey;

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



        private void BtnRegistrar_Click(object sender, EventArgs e)
        {
            if (PnlRegistrar.Visible == true)
            {
                PnlRegistrar.Visible = false;
            }
            else
            {
                PnlRegistrar.Visible = true;
            }
        }

        private void BtnRegisrarTactor_Click(object sender, EventArgs e)
        {
            AbrirFromHijo(new FrmRegistarTractor());
            PnlRegistrar.Visible = false;
        }

        private void BtnRegistrarAutobus_Click(object sender, EventArgs e)
        {
            AbrirFromHijo(new FrmRegistrarAutobus());
            PnlRegistrar.Visible = false;
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

        private void PnlBarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            eventoActivo = 1;
            ubicacionMausex = e.X;
            ubicacionMausey = e.Y;
        }

        private void PnlBarraTitulo_MouseMove(object sender, MouseEventArgs e)
        {
            if (eventoActivo == 1)
            {
                this.SetDesktopLocation(MousePosition.X - ubicacionMausex, MousePosition.Y - ubicacionMausey);
            }
        }

        private void PnlBarraTitulo_MouseUp(object sender, MouseEventArgs e)
        {
            eventoActivo = 0;
        }
    }
}
