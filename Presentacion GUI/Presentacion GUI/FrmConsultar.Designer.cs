
namespace Presentacion_GUI
{
    partial class FrmConsultar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.PnlConsultar = new System.Windows.Forms.Panel();
            this.CbxTipoVehiculo = new System.Windows.Forms.ComboBox();
            this.TxtNumeroLiquidacion = new System.Windows.Forms.TextBox();
            this.TxtPlaca = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.BtnBuscar = new System.Windows.Forms.Button();
            this.DGConsultar = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.PnlConsultar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGConsultar)).BeginInit();
            this.SuspendLayout();
            // 
            // PnlConsultar
            // 
            this.PnlConsultar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.PnlConsultar.Controls.Add(this.CbxTipoVehiculo);
            this.PnlConsultar.Controls.Add(this.TxtNumeroLiquidacion);
            this.PnlConsultar.Controls.Add(this.TxtPlaca);
            this.PnlConsultar.Controls.Add(this.label4);
            this.PnlConsultar.Controls.Add(this.BtnBuscar);
            this.PnlConsultar.Controls.Add(this.DGConsultar);
            this.PnlConsultar.Controls.Add(this.label3);
            this.PnlConsultar.Controls.Add(this.label2);
            this.PnlConsultar.Controls.Add(this.label1);
            this.PnlConsultar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlConsultar.Font = new System.Drawing.Font("Modern No. 20", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PnlConsultar.Location = new System.Drawing.Point(0, 0);
            this.PnlConsultar.Name = "PnlConsultar";
            this.PnlConsultar.Size = new System.Drawing.Size(777, 490);
            this.PnlConsultar.TabIndex = 0;
            // 
            // CbxTipoVehiculo
            // 
            this.CbxTipoVehiculo.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CbxTipoVehiculo.FormattingEnabled = true;
            this.CbxTipoVehiculo.Items.AddRange(new object[] {
            "AUTOBUS",
            "TRACTOR"});
            this.CbxTipoVehiculo.Location = new System.Drawing.Point(524, 172);
            this.CbxTipoVehiculo.Name = "CbxTipoVehiculo";
            this.CbxTipoVehiculo.Size = new System.Drawing.Size(96, 24);
            this.CbxTipoVehiculo.TabIndex = 8;
            this.CbxTipoVehiculo.Text = "Seleccionar";
            // 
            // TxtNumeroLiquidacion
            // 
            this.TxtNumeroLiquidacion.Font = new System.Drawing.Font("Britannic Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtNumeroLiquidacion.Location = new System.Drawing.Point(113, 172);
            this.TxtNumeroLiquidacion.Name = "TxtNumeroLiquidacion";
            this.TxtNumeroLiquidacion.Size = new System.Drawing.Size(112, 22);
            this.TxtNumeroLiquidacion.TabIndex = 7;
            // 
            // TxtPlaca
            // 
            this.TxtPlaca.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtPlaca.Location = new System.Drawing.Point(323, 172);
            this.TxtPlaca.Name = "TxtPlaca";
            this.TxtPlaca.Size = new System.Drawing.Size(113, 22);
            this.TxtPlaca.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(524, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 18);
            this.label4.TabIndex = 5;
            this.label4.Text = "Tipo de Renta";
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.BtnBuscar.FlatAppearance.BorderSize = 0;
            this.BtnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBuscar.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnBuscar.Image = global::Presentacion_GUI.Properties.Resources.consulta;
            this.BtnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnBuscar.Location = new System.Drawing.Point(614, 439);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(151, 39);
            this.BtnBuscar.TabIndex = 4;
            this.BtnBuscar.Text = "BUSCAR\r\n";
            this.BtnBuscar.UseVisualStyleBackColor = false;
            // 
            // DGConsultar
            // 
            this.DGConsultar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGConsultar.Location = new System.Drawing.Point(48, 226);
            this.DGConsultar.Name = "DGConsultar";
            this.DGConsultar.RowTemplate.Height = 25;
            this.DGConsultar.Size = new System.Drawing.Size(684, 162);
            this.DGConsultar.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(323, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Placa";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(104, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Numero Liquidacion";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(262, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "CONSULTAR";
            // 
            // FrmConsultar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(777, 490);
            this.Controls.Add(this.PnlConsultar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmConsultar";
            this.Text = "FrmConsultar";
            this.PnlConsultar.ResumeLayout(false);
            this.PnlConsultar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGConsultar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PnlConsultar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnBuscar;
        private System.Windows.Forms.DataGridView DGConsultar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox CbxTipoVehiculo;
        private System.Windows.Forms.TextBox TxtNumeroLiquidacion;
        private System.Windows.Forms.TextBox TxtPlaca;
        private System.Windows.Forms.Label label4;
    }
}