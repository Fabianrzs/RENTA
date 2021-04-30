
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.PnlModificar = new System.Windows.Forms.Panel();
            this.BtnBuscar = new System.Windows.Forms.Button();
            this.DGModificar = new System.Windows.Forms.DataGridView();
            this.PnlAutobus = new System.Windows.Forms.Panel();
            this.TxtKilometrosRenta = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.TxtKilometrosDevuelto = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.PnlTractor = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dateTimeDevolucion = new System.Windows.Forms.DateTimePicker();
            this.dateTimeRenta = new System.Windows.Forms.DateTimePicker();
            this.CbxTipoVehiculo = new System.Windows.Forms.ComboBox();
            this.TxtNumeroLiquidacion = new System.Windows.Forms.TextBox();
            this.TxtPlaca = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.BtnModificar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.errorProviderLiquidacion = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderTiporenta = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderPlaca = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderRenta = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderDevolucion = new System.Windows.Forms.ErrorProvider(this.components);
            this.PnlModificar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGModificar)).BeginInit();
            this.PnlAutobus.SuspendLayout();
            this.PnlTractor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderLiquidacion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderTiporenta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderPlaca)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderRenta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderDevolucion)).BeginInit();
            this.SuspendLayout();
            // 
            // PnlModificar
            // 
            this.PnlModificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.PnlModificar.Controls.Add(this.BtnBuscar);
            this.PnlModificar.Controls.Add(this.DGModificar);
            this.PnlModificar.Controls.Add(this.PnlAutobus);
            this.PnlModificar.Controls.Add(this.PnlTractor);
            this.PnlModificar.Controls.Add(this.CbxTipoVehiculo);
            this.PnlModificar.Controls.Add(this.TxtNumeroLiquidacion);
            this.PnlModificar.Controls.Add(this.TxtPlaca);
            this.PnlModificar.Controls.Add(this.label4);
            this.PnlModificar.Controls.Add(this.BtnModificar);
            this.PnlModificar.Controls.Add(this.label3);
            this.PnlModificar.Controls.Add(this.label2);
            this.PnlModificar.Controls.Add(this.label1);
            this.PnlModificar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlModificar.Location = new System.Drawing.Point(0, 0);
            this.PnlModificar.Name = "PnlModificar";
            this.PnlModificar.Size = new System.Drawing.Size(777, 490);
            this.PnlModificar.TabIndex = 1;
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.BtnBuscar.FlatAppearance.BorderSize = 0;
            this.BtnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBuscar.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnBuscar.Image = global::Presentacion_GUI.Properties.Resources.consulta;
            this.BtnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnBuscar.Location = new System.Drawing.Point(264, 126);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(41, 32);
            this.BtnBuscar.TabIndex = 35;
            this.BtnBuscar.UseVisualStyleBackColor = false;
            this.BtnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // DGModificar
            // 
            this.DGModificar.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGModificar.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.DGModificar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGModificar.DefaultCellStyle = dataGridViewCellStyle6;
            this.DGModificar.GridColor = System.Drawing.Color.White;
            this.DGModificar.Location = new System.Drawing.Point(31, 190);
            this.DGModificar.Name = "DGModificar";
            this.DGModificar.RowTemplate.Height = 25;
            this.DGModificar.Size = new System.Drawing.Size(384, 180);
            this.DGModificar.TabIndex = 34;
            // 
            // PnlAutobus
            // 
            this.PnlAutobus.Controls.Add(this.TxtKilometrosRenta);
            this.PnlAutobus.Controls.Add(this.label9);
            this.PnlAutobus.Controls.Add(this.TxtKilometrosDevuelto);
            this.PnlAutobus.Controls.Add(this.label8);
            this.PnlAutobus.Location = new System.Drawing.Point(450, 249);
            this.PnlAutobus.Name = "PnlAutobus";
            this.PnlAutobus.Size = new System.Drawing.Size(283, 97);
            this.PnlAutobus.TabIndex = 34;
            this.PnlAutobus.Visible = false;
            // 
            // TxtKilometrosRenta
            // 
            this.TxtKilometrosRenta.Font = new System.Drawing.Font("Britannic Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtKilometrosRenta.Location = new System.Drawing.Point(212, 24);
            this.TxtKilometrosRenta.Name = "TxtKilometrosRenta";
            this.TxtKilometrosRenta.Size = new System.Drawing.Size(51, 22);
            this.TxtKilometrosRenta.TabIndex = 33;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(26, 24);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(131, 18);
            this.label9.TabIndex = 32;
            this.label9.Text = "Kilometros Renta";
            // 
            // TxtKilometrosDevuelto
            // 
            this.TxtKilometrosDevuelto.Font = new System.Drawing.Font("Britannic Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtKilometrosDevuelto.Location = new System.Drawing.Point(212, 60);
            this.TxtKilometrosDevuelto.Name = "TxtKilometrosDevuelto";
            this.TxtKilometrosDevuelto.Size = new System.Drawing.Size(51, 22);
            this.TxtKilometrosDevuelto.TabIndex = 31;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(26, 64);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(166, 18);
            this.label8.TabIndex = 30;
            this.label8.Text = "Kilometros Devolucion";
            // 
            // PnlTractor
            // 
            this.PnlTractor.Controls.Add(this.label5);
            this.PnlTractor.Controls.Add(this.label6);
            this.PnlTractor.Controls.Add(this.dateTimeDevolucion);
            this.PnlTractor.Controls.Add(this.dateTimeRenta);
            this.PnlTractor.Location = new System.Drawing.Point(464, 258);
            this.PnlTractor.Name = "PnlTractor";
            this.PnlTractor.Size = new System.Drawing.Size(287, 175);
            this.PnlTractor.TabIndex = 27;
            this.PnlTractor.Visible = false;
            // 
            // label5
            // 
            this.label5.AllowDrop = true;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(64, 91);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(152, 18);
            this.label5.TabIndex = 33;
            this.label5.Text = "Fecha de Devolucion";
            // 
            // label6
            // 
            this.label6.AllowDrop = true;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(74, 12);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(117, 18);
            this.label6.TabIndex = 32;
            this.label6.Text = "Fecha de Renta";
            // 
            // dateTimeDevolucion
            // 
            this.dateTimeDevolucion.Location = new System.Drawing.Point(26, 121);
            this.dateTimeDevolucion.Name = "dateTimeDevolucion";
            this.dateTimeDevolucion.Size = new System.Drawing.Size(222, 23);
            this.dateTimeDevolucion.TabIndex = 31;
            // 
            // dateTimeRenta
            // 
            this.dateTimeRenta.Location = new System.Drawing.Point(26, 42);
            this.dateTimeRenta.Name = "dateTimeRenta";
            this.dateTimeRenta.Size = new System.Drawing.Size(222, 23);
            this.dateTimeRenta.TabIndex = 30;
            this.dateTimeRenta.Value = new System.DateTime(2021, 4, 27, 0, 0, 0, 0);
            // 
            // CbxTipoVehiculo
            // 
            this.CbxTipoVehiculo.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CbxTipoVehiculo.FormattingEnabled = true;
            this.CbxTipoVehiculo.Items.AddRange(new object[] {
            "AUTOBUS",
            "TRACTOR"});
            this.CbxTipoVehiculo.Location = new System.Drawing.Point(662, 190);
            this.CbxTipoVehiculo.Name = "CbxTipoVehiculo";
            this.CbxTipoVehiculo.Size = new System.Drawing.Size(96, 24);
            this.CbxTipoVehiculo.TabIndex = 26;
            this.CbxTipoVehiculo.Text = "Seleccionar";
            this.CbxTipoVehiculo.SelectedIndexChanged += new System.EventHandler(this.CbxTipoVehiculo_SelectedIndexChanged);
            this.CbxTipoVehiculo.Validating += new System.ComponentModel.CancelEventHandler(this.CbxTipoVehiculo_Validating);
            this.CbxTipoVehiculo.Validated += new System.EventHandler(this.CbxTipoVehiculo_Validated);
            // 
            // TxtNumeroLiquidacion
            // 
            this.TxtNumeroLiquidacion.Font = new System.Drawing.Font("Britannic Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtNumeroLiquidacion.Location = new System.Drawing.Point(56, 136);
            this.TxtNumeroLiquidacion.Name = "TxtNumeroLiquidacion";
            this.TxtNumeroLiquidacion.Size = new System.Drawing.Size(112, 22);
            this.TxtNumeroLiquidacion.TabIndex = 25;
            this.TxtNumeroLiquidacion.Validating += new System.ComponentModel.CancelEventHandler(this.TxtNumeroLiquidacion_Validating);
            this.TxtNumeroLiquidacion.Validated += new System.EventHandler(this.TxtNumeroLiquidacion_Validated);
            // 
            // TxtPlaca
            // 
            this.TxtPlaca.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtPlaca.Location = new System.Drawing.Point(662, 230);
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
            // BtnModificar
            // 
            this.BtnModificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.BtnModificar.FlatAppearance.BorderSize = 0;
            this.BtnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnModificar.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnModificar.Image = global::Presentacion_GUI.Properties.Resources.boton_editar;
            this.BtnModificar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnModificar.Location = new System.Drawing.Point(577, 439);
            this.BtnModificar.Name = "BtnModificar";
            this.BtnModificar.Size = new System.Drawing.Size(188, 39);
            this.BtnModificar.TabIndex = 22;
            this.BtnModificar.Text = "MODIFICAR";
            this.BtnModificar.UseVisualStyleBackColor = false;
            this.BtnModificar.Click += new System.EventHandler(this.BtnModificar_Click);
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
            this.label1.Size = new System.Drawing.Size(176, 31);
            this.label1.TabIndex = 18;
            this.label1.Text = "MODIFICAR";
            // 
            // errorProviderLiquidacion
            // 
            this.errorProviderLiquidacion.ContainerControl = this;
            // 
            // errorProviderTiporenta
            // 
            this.errorProviderTiporenta.ContainerControl = this;
            // 
            // errorProviderPlaca
            // 
            this.errorProviderPlaca.ContainerControl = this;
            // 
            // errorProviderRenta
            // 
            this.errorProviderRenta.ContainerControl = this;
            // 
            // errorProviderDevolucion
            // 
            this.errorProviderDevolucion.ContainerControl = this;
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
            ((System.ComponentModel.ISupportInitialize)(this.DGModificar)).EndInit();
            this.PnlAutobus.ResumeLayout(false);
            this.PnlAutobus.PerformLayout();
            this.PnlTractor.ResumeLayout(false);
            this.PnlTractor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderLiquidacion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderTiporenta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderPlaca)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderRenta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderDevolucion)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PnlModificar;
        private System.Windows.Forms.ComboBox CbxTipoVehiculo;
        private System.Windows.Forms.TextBox TxtNumeroLiquidacion;
        private System.Windows.Forms.TextBox TxtPlaca;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button BtnModificar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel PnlTractor;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dateTimeDevolucion;
        private System.Windows.Forms.DateTimePicker dateTimeRenta;
        private System.Windows.Forms.Panel PnlAutobus;
        private System.Windows.Forms.TextBox TxtKilometrosRenta;
        private System.Windows.Forms.TextBox TxtKilometrosDevuelto;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ErrorProvider errorProviderLiquidacion;
        private System.Windows.Forms.ErrorProvider errorProviderTiporenta;
        private System.Windows.Forms.ErrorProvider errorProviderPlaca;
        private System.Windows.Forms.ErrorProvider errorProviderRenta;
        private System.Windows.Forms.ErrorProvider errorProviderDevolucion;
        private System.Windows.Forms.DataGridView DGModificar;
        private System.Windows.Forms.Button BtnBuscar;
    }
}