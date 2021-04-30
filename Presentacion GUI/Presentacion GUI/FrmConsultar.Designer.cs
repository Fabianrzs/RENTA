
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.PnlConsultar = new System.Windows.Forms.Panel();
            this.CbxTipoVehiculo = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.BtnBuscar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.errorProviderTipo = new System.Windows.Forms.ErrorProvider(this.components);
            this.DGConsultar = new System.Windows.Forms.DataGridView();
            this.PnlConsultar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderTipo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGConsultar)).BeginInit();
            this.SuspendLayout();
            // 
            // PnlConsultar
            // 
            this.PnlConsultar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.PnlConsultar.Controls.Add(this.DGConsultar);
            this.PnlConsultar.Controls.Add(this.CbxTipoVehiculo);
            this.PnlConsultar.Controls.Add(this.label4);
            this.PnlConsultar.Controls.Add(this.BtnBuscar);
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
            this.CbxTipoVehiculo.Location = new System.Drawing.Point(253, 145);
            this.CbxTipoVehiculo.Name = "CbxTipoVehiculo";
            this.CbxTipoVehiculo.Size = new System.Drawing.Size(96, 24);
            this.CbxTipoVehiculo.TabIndex = 8;
            this.CbxTipoVehiculo.Text = "Seleccionar";
            this.CbxTipoVehiculo.Validating += new System.ComponentModel.CancelEventHandler(this.CbxTipoVehiculo_Validating);
            this.CbxTipoVehiculo.Validated += new System.EventHandler(this.CbxTipoVehiculo_Validated);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(104, 151);
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
            this.BtnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
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
            // errorProviderTipo
            // 
            this.errorProviderTipo.ContainerControl = this;
            // 
            // DGConsultar
            // 
            this.DGConsultar.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGConsultar.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DGConsultar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGConsultar.DefaultCellStyle = dataGridViewCellStyle2;
            this.DGConsultar.GridColor = System.Drawing.Color.White;
            this.DGConsultar.Location = new System.Drawing.Point(49, 183);
            this.DGConsultar.Name = "DGConsultar";
            this.DGConsultar.RowTemplate.Height = 25;
            this.DGConsultar.Size = new System.Drawing.Size(687, 228);
            this.DGConsultar.TabIndex = 13;
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
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderTipo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGConsultar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PnlConsultar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnBuscar;
        private System.Windows.Forms.ComboBox CbxTipoVehiculo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ErrorProvider errorProviderTipo;
        private System.Windows.Forms.DataGridView DGConsultar;
    }
}