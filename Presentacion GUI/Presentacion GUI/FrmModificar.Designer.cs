
namespace Presentacion_GUI
{
    partial class FrmModificar
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
            this.PnlModificar = new System.Windows.Forms.Panel();
            this.CbxTipoVehiculo = new System.Windows.Forms.ComboBox();
            this.TxtNumeroLiquidacion = new System.Windows.Forms.TextBox();
            this.TxtPlaca = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.BtnBuscar = new System.Windows.Forms.Button();
            this.dataGridViewRegistro = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.PnlModificar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRegistro)).BeginInit();
            this.SuspendLayout();
            // 
            // PnlModificar
            // 
            this.PnlModificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.PnlModificar.Controls.Add(this.CbxTipoVehiculo);
            this.PnlModificar.Controls.Add(this.TxtNumeroLiquidacion);
            this.PnlModificar.Controls.Add(this.TxtPlaca);
            this.PnlModificar.Controls.Add(this.label4);
            this.PnlModificar.Controls.Add(this.BtnBuscar);
            this.PnlModificar.Controls.Add(this.dataGridViewRegistro);
            this.PnlModificar.Controls.Add(this.label3);
            this.PnlModificar.Controls.Add(this.label2);
            this.PnlModificar.Controls.Add(this.label1);
            this.PnlModificar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlModificar.Location = new System.Drawing.Point(0, 0);
            this.PnlModificar.Name = "PnlModificar";
            this.PnlModificar.Size = new System.Drawing.Size(777, 490);
            this.PnlModificar.TabIndex = 1;
            // 
            // CbxTipoVehiculo
            // 
            this.CbxTipoVehiculo.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CbxTipoVehiculo.FormattingEnabled = true;
            this.CbxTipoVehiculo.Items.AddRange(new object[] {
            "AUTOBUS",
            "TRACTOR"});
            this.CbxTipoVehiculo.Location = new System.Drawing.Point(620, 189);
            this.CbxTipoVehiculo.Name = "CbxTipoVehiculo";
            this.CbxTipoVehiculo.Size = new System.Drawing.Size(96, 24);
            this.CbxTipoVehiculo.TabIndex = 26;
            this.CbxTipoVehiculo.Text = "Seleccionar";
            // 
            // TxtNumeroLiquidacion
            // 
            this.TxtNumeroLiquidacion.Font = new System.Drawing.Font("Britannic Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtNumeroLiquidacion.Location = new System.Drawing.Point(56, 136);
            this.TxtNumeroLiquidacion.Name = "TxtNumeroLiquidacion";
            this.TxtNumeroLiquidacion.Size = new System.Drawing.Size(112, 22);
            this.TxtNumeroLiquidacion.TabIndex = 25;
            // 
            // TxtPlaca
            // 
            this.TxtPlaca.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtPlaca.Location = new System.Drawing.Point(620, 228);
            this.TxtPlaca.Name = "TxtPlaca";
            this.TxtPlaca.Size = new System.Drawing.Size(76, 22);
            this.TxtPlaca.TabIndex = 24;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(479, 190);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 18);
            this.label4.TabIndex = 23;
            this.label4.Text = "Tipo de Renta";
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.BtnBuscar.FlatAppearance.BorderSize = 0;
            this.BtnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBuscar.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnBuscar.Image = global::Presentacion_GUI.Properties.Resources.documento1;
            this.BtnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnBuscar.Location = new System.Drawing.Point(577, 439);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(188, 39);
            this.BtnBuscar.TabIndex = 22;
            this.BtnBuscar.Text = "MODIFICAR";
            this.BtnBuscar.UseVisualStyleBackColor = false;
            // 
            // dataGridViewRegistro
            // 
            this.dataGridViewRegistro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRegistro.Location = new System.Drawing.Point(34, 190);
            this.dataGridViewRegistro.Name = "dataGridViewRegistro";
            this.dataGridViewRegistro.RowTemplate.Height = 25;
            this.dataGridViewRegistro.Size = new System.Drawing.Size(388, 162);
            this.dataGridViewRegistro.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(479, 228);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 18);
            this.label3.TabIndex = 20;
            this.label3.Text = "Placa";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(56, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 18);
            this.label2.TabIndex = 19;
            this.label2.Text = "Numero Liquidacion";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(291, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 31);
            this.label1.TabIndex = 18;
            this.label1.Text = "CONSULTAR";
            // 
            // FrmModificar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(777, 490);
            this.Controls.Add(this.PnlModificar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmModificar";
            this.Text = "Modificar";
            this.PnlModificar.ResumeLayout(false);
            this.PnlModificar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRegistro)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PnlModificar;
        private System.Windows.Forms.ComboBox CbxTipoVehiculo;
        private System.Windows.Forms.TextBox TxtNumeroLiquidacion;
        private System.Windows.Forms.TextBox TxtPlaca;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button BtnBuscar;
        private System.Windows.Forms.DataGridView dataGridViewRegistro;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}