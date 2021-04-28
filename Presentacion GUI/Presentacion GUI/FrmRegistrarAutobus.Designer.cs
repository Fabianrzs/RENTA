
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
            this.PnlRegistarTactor = new System.Windows.Forms.Panel();
            this.TxtKilometrosRenta = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtKilometrosDevuelto = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtPlaca = new System.Windows.Forms.TextBox();
            this.BtnrRegistrar = new System.Windows.Forms.Button();
            this.dataGridViewRegistro = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.PnlRegistarTactor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRegistro)).BeginInit();
            this.SuspendLayout();
            // 
            // PnlRegistarTactor
            // 
            this.PnlRegistarTactor.AllowDrop = true;
            this.PnlRegistarTactor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.PnlRegistarTactor.Controls.Add(this.TxtKilometrosRenta);
            this.PnlRegistarTactor.Controls.Add(this.label4);
            this.PnlRegistarTactor.Controls.Add(this.TxtKilometrosDevuelto);
            this.PnlRegistarTactor.Controls.Add(this.label2);
            this.PnlRegistarTactor.Controls.Add(this.TxtPlaca);
            this.PnlRegistarTactor.Controls.Add(this.BtnrRegistrar);
            this.PnlRegistarTactor.Controls.Add(this.dataGridViewRegistro);
            this.PnlRegistarTactor.Controls.Add(this.label3);
            this.PnlRegistarTactor.Controls.Add(this.label1);
            this.PnlRegistarTactor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlRegistarTactor.Location = new System.Drawing.Point(0, 0);
            this.PnlRegistarTactor.Name = "PnlRegistarTactor";
            this.PnlRegistarTactor.Size = new System.Drawing.Size(777, 490);
            this.PnlRegistarTactor.TabIndex = 3;
            // 
            // TxtKilometrosRenta
            // 
            this.TxtKilometrosRenta.Font = new System.Drawing.Font("Britannic Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtKilometrosRenta.Location = new System.Drawing.Point(646, 192);
            this.TxtKilometrosRenta.Name = "TxtKilometrosRenta";
            this.TxtKilometrosRenta.Size = new System.Drawing.Size(51, 22);
            this.TxtKilometrosRenta.TabIndex = 29;
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
            // dataGridViewRegistro
            // 
            this.dataGridViewRegistro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRegistro.Location = new System.Drawing.Point(51, 119);
            this.dataGridViewRegistro.Name = "dataGridViewRegistro";
            this.dataGridViewRegistro.RowTemplate.Height = 25;
            this.dataGridViewRegistro.Size = new System.Drawing.Size(382, 216);
            this.dataGridViewRegistro.TabIndex = 21;
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
            // FrmRegistrarAutobus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(777, 490);
            this.Controls.Add(this.PnlRegistarTactor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmRegistrarAutobus";
            this.Text = "FrmRegistrarAutobus";
            this.PnlRegistarTactor.ResumeLayout(false);
            this.PnlRegistarTactor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRegistro)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PnlRegistarTactor;
        private System.Windows.Forms.TextBox TxtKilometrosRenta;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtKilometrosDevuelto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtPlaca;
        private System.Windows.Forms.Button BtnrRegistrar;
        private System.Windows.Forms.DataGridView dataGridViewRegistro;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
    }
}