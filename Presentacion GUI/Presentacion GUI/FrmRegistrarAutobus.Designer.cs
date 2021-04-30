
namespace Presentacion_GUI
{
    partial class FrmRegistrarAutobus
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.PnlRegistarAutobus = new System.Windows.Forms.Panel();
            this.TxtKilometrosRenta = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtKilometrosDevuelto = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtPlaca = new System.Windows.Forms.TextBox();
            this.BtnrRegistrar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.errorProviderPlaca = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderRenta = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderDevolucion = new System.Windows.Forms.ErrorProvider(this.components);
            this.DGRegistrarAutobus = new System.Windows.Forms.DataGridView();
            this.PnlRegistarAutobus.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderPlaca)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderRenta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderDevolucion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGRegistrarAutobus)).BeginInit();
            this.SuspendLayout();
            // 
            // PnlRegistarAutobus
            // 
            this.PnlRegistarAutobus.AllowDrop = true;
            this.PnlRegistarAutobus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.PnlRegistarAutobus.Controls.Add(this.DGRegistrarAutobus);
            this.PnlRegistarAutobus.Controls.Add(this.TxtKilometrosRenta);
            this.PnlRegistarAutobus.Controls.Add(this.label4);
            this.PnlRegistarAutobus.Controls.Add(this.TxtKilometrosDevuelto);
            this.PnlRegistarAutobus.Controls.Add(this.label2);
            this.PnlRegistarAutobus.Controls.Add(this.TxtPlaca);
            this.PnlRegistarAutobus.Controls.Add(this.BtnrRegistrar);
            this.PnlRegistarAutobus.Controls.Add(this.label3);
            this.PnlRegistarAutobus.Controls.Add(this.label1);
            this.PnlRegistarAutobus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlRegistarAutobus.Location = new System.Drawing.Point(0, 0);
            this.PnlRegistarAutobus.Name = "PnlRegistarAutobus";
            this.PnlRegistarAutobus.Size = new System.Drawing.Size(777, 490);
            this.PnlRegistarAutobus.TabIndex = 3;
            // 
            // TxtKilometrosRenta
            // 
            this.TxtKilometrosRenta.Font = new System.Drawing.Font("Britannic Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtKilometrosRenta.Location = new System.Drawing.Point(646, 192);
            this.TxtKilometrosRenta.Name = "TxtKilometrosRenta";
            this.TxtKilometrosRenta.Size = new System.Drawing.Size(51, 22);
            this.TxtKilometrosRenta.TabIndex = 29;
            this.TxtKilometrosRenta.Validating += new System.ComponentModel.CancelEventHandler(this.TxtKilometrosRenta_Validating);
            this.TxtKilometrosRenta.Validated += new System.EventHandler(this.TxtKilometrosRenta_Validated);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(463, 192);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 18);
            this.label4.TabIndex = 28;
            this.label4.Text = "Kilometros Renta";
            // 
            // TxtKilometrosDevuelto
            // 
            this.TxtKilometrosDevuelto.Font = new System.Drawing.Font("Britannic Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtKilometrosDevuelto.Location = new System.Drawing.Point(646, 241);
            this.TxtKilometrosDevuelto.Name = "TxtKilometrosDevuelto";
            this.TxtKilometrosDevuelto.Size = new System.Drawing.Size(51, 22);
            this.TxtKilometrosDevuelto.TabIndex = 27;
            this.TxtKilometrosDevuelto.Validating += new System.ComponentModel.CancelEventHandler(this.TxtKilometrosDevuelto_Validating);
            this.TxtKilometrosDevuelto.Validated += new System.EventHandler(this.TxtKilometrosDevuelto_Validated);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(463, 245);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(166, 18);
            this.label2.TabIndex = 26;
            this.label2.Text = "Kilometros Devolucion";
            // 
            // TxtPlaca
            // 
            this.TxtPlaca.Font = new System.Drawing.Font("Britannic Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtPlaca.Location = new System.Drawing.Point(646, 140);
            this.TxtPlaca.Name = "TxtPlaca";
            this.TxtPlaca.Size = new System.Drawing.Size(73, 22);
            this.TxtPlaca.TabIndex = 25;
            this.TxtPlaca.Validating += new System.ComponentModel.CancelEventHandler(this.TxtPlaca_Validating);
            this.TxtPlaca.Validated += new System.EventHandler(this.TxtPlaca_Validated);
            // 
            // BtnrRegistrar
            // 
            this.BtnrRegistrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.BtnrRegistrar.FlatAppearance.BorderSize = 0;
            this.BtnrRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnrRegistrar.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnrRegistrar.Image = global::Presentacion_GUI.Properties.Resources.verificar;
            this.BtnrRegistrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnrRegistrar.Location = new System.Drawing.Point(596, 439);
            this.BtnrRegistrar.Name = "BtnrRegistrar";
            this.BtnrRegistrar.Size = new System.Drawing.Size(167, 39);
            this.BtnrRegistrar.TabIndex = 22;
            this.BtnrRegistrar.Text = "    REGISTRAR";
            this.BtnrRegistrar.UseVisualStyleBackColor = false;
            this.BtnrRegistrar.Click += new System.EventHandler(this.BtnrRegistrar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(463, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 18);
            this.label3.TabIndex = 20;
            this.label3.Text = "Placa";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(224, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(319, 31);
            this.label1.TabIndex = 18;
            this.label1.Text = "REGISTRAR AUTOBUS";
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
            // DGRegistrarAutobus
            // 
            this.DGRegistrarAutobus.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGRegistrarAutobus.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.DGRegistrarAutobus.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGRegistrarAutobus.DefaultCellStyle = dataGridViewCellStyle4;
            this.DGRegistrarAutobus.GridColor = System.Drawing.Color.White;
            this.DGRegistrarAutobus.Location = new System.Drawing.Point(40, 140);
            this.DGRegistrarAutobus.Name = "DGRegistrarAutobus";
            this.DGRegistrarAutobus.RowTemplate.Height = 25;
            this.DGRegistrarAutobus.Size = new System.Drawing.Size(384, 180);
            this.DGRegistrarAutobus.TabIndex = 32;
            // 
            // FrmRegistrarAutobus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(777, 490);
            this.Controls.Add(this.PnlRegistarAutobus);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmRegistrarAutobus";
            this.Text = "FrmRegistrarAutobus";
            this.PnlRegistarAutobus.ResumeLayout(false);
            this.PnlRegistarAutobus.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderPlaca)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderRenta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderDevolucion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGRegistrarAutobus)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PnlRegistarAutobus;
        private System.Windows.Forms.TextBox TxtKilometrosRenta;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtKilometrosDevuelto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtPlaca;
        private System.Windows.Forms.Button BtnrRegistrar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider errorProviderPlaca;
        private System.Windows.Forms.ErrorProvider errorProviderRenta;
        private System.Windows.Forms.ErrorProvider errorProviderDevolucion;
        private System.Windows.Forms.DataGridView DGRegistrarAutobus;
    }
}