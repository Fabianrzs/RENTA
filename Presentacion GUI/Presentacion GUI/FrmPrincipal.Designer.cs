
namespace Presentacion_GUI
{
    partial class FrmPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            this.PnlBarraTitulo = new System.Windows.Forms.Panel();
            this.Minimizar = new System.Windows.Forms.PictureBox();
            this.Cerrar = new System.Windows.Forms.PictureBox();
            this.PnlContenedor = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.PnlMenuVertical = new System.Windows.Forms.Panel();
            this.PnlRegistrar = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.BtnRegisrarTactor = new System.Windows.Forms.Button();
            this.BtnRegistrarAutobus = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.BtnInforme = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.BtnModificar = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnConsultar = new System.Windows.Forms.Button();
            this.BtnRegistrar = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.PnlBarraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Minimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cerrar)).BeginInit();
            this.PnlContenedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.PnlMenuVertical.SuspendLayout();
            this.PnlRegistrar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // PnlBarraTitulo
            // 
            this.PnlBarraTitulo.BackColor = System.Drawing.Color.Black;
            this.PnlBarraTitulo.Controls.Add(this.Minimizar);
            this.PnlBarraTitulo.Controls.Add(this.Cerrar);
            this.PnlBarraTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnlBarraTitulo.Location = new System.Drawing.Point(0, 0);
            this.PnlBarraTitulo.Name = "PnlBarraTitulo";
            this.PnlBarraTitulo.Size = new System.Drawing.Size(960, 30);
            this.PnlBarraTitulo.TabIndex = 1;
            this.PnlBarraTitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PnlBarraTitulo_MouseDown);
            this.PnlBarraTitulo.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PnlBarraTitulo_MouseMove);
            this.PnlBarraTitulo.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PnlBarraTitulo_MouseUp);
            // 
            // Minimizar
            // 
            this.Minimizar.Image = global::Presentacion_GUI.Properties.Resources.minimizar;
            this.Minimizar.Location = new System.Drawing.Point(898, 0);
            this.Minimizar.Name = "Minimizar";
            this.Minimizar.Size = new System.Drawing.Size(21, 24);
            this.Minimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Minimizar.TabIndex = 1;
            this.Minimizar.TabStop = false;
            this.Minimizar.Click += new System.EventHandler(this.Minimizar_Click);
            // 
            // Cerrar
            // 
            this.Cerrar.Image = global::Presentacion_GUI.Properties.Resources.cerrar;
            this.Cerrar.InitialImage = ((System.Drawing.Image)(resources.GetObject("Cerrar.InitialImage")));
            this.Cerrar.Location = new System.Drawing.Point(925, 0);
            this.Cerrar.Name = "Cerrar";
            this.Cerrar.Size = new System.Drawing.Size(23, 24);
            this.Cerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Cerrar.TabIndex = 0;
            this.Cerrar.TabStop = false;
            this.Cerrar.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // PnlContenedor
            // 
            this.PnlContenedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.PnlContenedor.Controls.Add(this.pictureBox2);
            this.PnlContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlContenedor.Location = new System.Drawing.Point(183, 30);
            this.PnlContenedor.Name = "PnlContenedor";
            this.PnlContenedor.Size = new System.Drawing.Size(777, 490);
            this.PnlContenedor.TabIndex = 2;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Presentacion_GUI.Properties.Resources.Logo;
            this.pictureBox2.Location = new System.Drawing.Point(137, 118);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(505, 243);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // PnlMenuVertical
            // 
            this.PnlMenuVertical.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.PnlMenuVertical.Controls.Add(this.PnlRegistrar);
            this.PnlMenuVertical.Controls.Add(this.panel5);
            this.PnlMenuVertical.Controls.Add(this.BtnInforme);
            this.PnlMenuVertical.Controls.Add(this.panel4);
            this.PnlMenuVertical.Controls.Add(this.BtnEliminar);
            this.PnlMenuVertical.Controls.Add(this.panel3);
            this.PnlMenuVertical.Controls.Add(this.BtnModificar);
            this.PnlMenuVertical.Controls.Add(this.panel2);
            this.PnlMenuVertical.Controls.Add(this.panel1);
            this.PnlMenuVertical.Controls.Add(this.BtnConsultar);
            this.PnlMenuVertical.Controls.Add(this.BtnRegistrar);
            this.PnlMenuVertical.Controls.Add(this.pictureBox3);
            this.PnlMenuVertical.Dock = System.Windows.Forms.DockStyle.Left;
            this.PnlMenuVertical.Location = new System.Drawing.Point(0, 30);
            this.PnlMenuVertical.Name = "PnlMenuVertical";
            this.PnlMenuVertical.Size = new System.Drawing.Size(183, 490);
            this.PnlMenuVertical.TabIndex = 0;
            // 
            // PnlRegistrar
            // 
            this.PnlRegistrar.Controls.Add(this.panel6);
            this.PnlRegistrar.Controls.Add(this.panel7);
            this.PnlRegistrar.Controls.Add(this.BtnRegisrarTactor);
            this.PnlRegistrar.Controls.Add(this.BtnRegistrarAutobus);
            this.PnlRegistrar.Location = new System.Drawing.Point(32, 179);
            this.PnlRegistrar.Name = "PnlRegistrar";
            this.PnlRegistrar.Size = new System.Drawing.Size(151, 79);
            this.PnlRegistrar.TabIndex = 1;
            this.PnlRegistrar.Visible = false;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Indigo;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(5, 35);
            this.panel6.TabIndex = 5;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.Indigo;
            this.panel7.Location = new System.Drawing.Point(0, 41);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(5, 35);
            this.panel7.TabIndex = 7;
            // 
            // BtnRegisrarTactor
            // 
            this.BtnRegisrarTactor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.BtnRegisrarTactor.FlatAppearance.BorderSize = 0;
            this.BtnRegisrarTactor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Indigo;
            this.BtnRegisrarTactor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRegisrarTactor.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnRegisrarTactor.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnRegisrarTactor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnRegisrarTactor.Location = new System.Drawing.Point(11, 0);
            this.BtnRegisrarTactor.Name = "BtnRegisrarTactor";
            this.BtnRegisrarTactor.Size = new System.Drawing.Size(107, 35);
            this.BtnRegisrarTactor.TabIndex = 4;
            this.BtnRegisrarTactor.Text = "TRACTOR";
            this.BtnRegisrarTactor.UseVisualStyleBackColor = false;
            this.BtnRegisrarTactor.Click += new System.EventHandler(this.BtnRegisrarTactor_Click);
            // 
            // BtnRegistrarAutobus
            // 
            this.BtnRegistrarAutobus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.BtnRegistrarAutobus.FlatAppearance.BorderSize = 0;
            this.BtnRegistrarAutobus.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Indigo;
            this.BtnRegistrarAutobus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRegistrarAutobus.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnRegistrarAutobus.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnRegistrarAutobus.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnRegistrarAutobus.Location = new System.Drawing.Point(11, 41);
            this.BtnRegistrarAutobus.Name = "BtnRegistrarAutobus";
            this.BtnRegistrarAutobus.Size = new System.Drawing.Size(107, 35);
            this.BtnRegistrarAutobus.TabIndex = 6;
            this.BtnRegistrarAutobus.Text = "AUTOBUS";
            this.BtnRegistrarAutobus.UseVisualStyleBackColor = false;
            this.BtnRegistrarAutobus.Click += new System.EventHandler(this.BtnRegistrarAutobus_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Indigo;
            this.panel5.Location = new System.Drawing.Point(0, 333);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(5, 35);
            this.panel5.TabIndex = 9;
            // 
            // BtnInforme
            // 
            this.BtnInforme.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.BtnInforme.FlatAppearance.BorderSize = 0;
            this.BtnInforme.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Indigo;
            this.BtnInforme.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnInforme.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnInforme.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnInforme.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnInforme.Location = new System.Drawing.Point(11, 333);
            this.BtnInforme.Name = "BtnInforme";
            this.BtnInforme.Size = new System.Drawing.Size(153, 35);
            this.BtnInforme.TabIndex = 8;
            this.BtnInforme.Text = "INFORMES";
            this.BtnInforme.UseVisualStyleBackColor = false;
            this.BtnInforme.Click += new System.EventHandler(this.BtnInforme_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Indigo;
            this.panel4.Location = new System.Drawing.Point(0, 282);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(5, 35);
            this.panel4.TabIndex = 7;
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.BtnEliminar.FlatAppearance.BorderSize = 0;
            this.BtnEliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Indigo;
            this.BtnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEliminar.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnEliminar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnEliminar.Location = new System.Drawing.Point(11, 282);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(153, 35);
            this.BtnEliminar.TabIndex = 6;
            this.BtnEliminar.Text = "ELIMINAR";
            this.BtnEliminar.UseVisualStyleBackColor = false;
            this.BtnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Indigo;
            this.panel3.Location = new System.Drawing.Point(0, 231);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(5, 35);
            this.panel3.TabIndex = 5;
            // 
            // BtnModificar
            // 
            this.BtnModificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.BtnModificar.FlatAppearance.BorderSize = 0;
            this.BtnModificar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Indigo;
            this.BtnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnModificar.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnModificar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnModificar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnModificar.Location = new System.Drawing.Point(12, 231);
            this.BtnModificar.Name = "BtnModificar";
            this.BtnModificar.Size = new System.Drawing.Size(152, 35);
            this.BtnModificar.TabIndex = 4;
            this.BtnModificar.Text = "MODIFICAR";
            this.BtnModificar.UseVisualStyleBackColor = false;
            this.BtnModificar.Click += new System.EventHandler(this.BtnModificar_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Indigo;
            this.panel2.Location = new System.Drawing.Point(0, 179);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(5, 35);
            this.panel2.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Indigo;
            this.panel1.Location = new System.Drawing.Point(0, 128);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(5, 35);
            this.panel1.TabIndex = 3;
            // 
            // BtnConsultar
            // 
            this.BtnConsultar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.BtnConsultar.FlatAppearance.BorderSize = 0;
            this.BtnConsultar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Indigo;
            this.BtnConsultar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnConsultar.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnConsultar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnConsultar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnConsultar.Location = new System.Drawing.Point(12, 179);
            this.BtnConsultar.Name = "BtnConsultar";
            this.BtnConsultar.Size = new System.Drawing.Size(152, 35);
            this.BtnConsultar.TabIndex = 2;
            this.BtnConsultar.Text = "CONSULTAR";
            this.BtnConsultar.UseVisualStyleBackColor = false;
            this.BtnConsultar.Click += new System.EventHandler(this.BtnConsultar_Click);
            // 
            // BtnRegistrar
            // 
            this.BtnRegistrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.BtnRegistrar.FlatAppearance.BorderSize = 0;
            this.BtnRegistrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Indigo;
            this.BtnRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRegistrar.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnRegistrar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnRegistrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnRegistrar.Location = new System.Drawing.Point(11, 128);
            this.BtnRegistrar.Name = "BtnRegistrar";
            this.BtnRegistrar.Size = new System.Drawing.Size(153, 35);
            this.BtnRegistrar.TabIndex = 2;
            this.BtnRegistrar.Text = "REGISTRAR";
            this.BtnRegistrar.UseVisualStyleBackColor = false;
            this.BtnRegistrar.Click += new System.EventHandler(this.BtnRegistrar_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Presentacion_GUI.Properties.Resources.Logo;
            this.pictureBox3.Location = new System.Drawing.Point(-18, 6);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(225, 98);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 1;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(960, 520);
            this.Controls.Add(this.PnlContenedor);
            this.Controls.Add(this.PnlMenuVertical);
            this.Controls.Add(this.PnlBarraTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmPrincipal";
            this.RightToLeftLayout = true;
            this.Text = "Form1";
            this.PnlBarraTitulo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Minimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cerrar)).EndInit();
            this.PnlContenedor.ResumeLayout(false);
            this.PnlContenedor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.PnlMenuVertical.ResumeLayout(false);
            this.PnlRegistrar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel PnlBarraTitulo;
        private System.Windows.Forms.Panel PnlContenedor;
        private System.Windows.Forms.PictureBox Minimizar;
        private System.Windows.Forms.PictureBox Cerrar;
        private System.Windows.Forms.Panel PnlMenuVertical;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button BtnRegistrar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button BtnConsultar;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button BtnInforme;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button BtnModificar;
        private System.Windows.Forms.Panel PnlRegistrar;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Button BtnRegisrarTactor;
        private System.Windows.Forms.Button BtnRegistrarAutobus;
    }
}

