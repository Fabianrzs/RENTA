
namespace Presentacion_GUI
{
    partial class FrmEliminar
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
            this.PnlEliminar = new System.Windows.Forms.Panel();
            this.TxtNumeroLiquidacion = new System.Windows.Forms.TextBox();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.dataGridViewRegistro = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtConfirmarLiquidacion = new System.Windows.Forms.TextBox();
            this.PnlEliminar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRegistro)).BeginInit();
            this.SuspendLayout();
            // 
            // PnlEliminar
            // 
            this.PnlEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.PnlEliminar.Controls.Add(this.TxtNumeroLiquidacion);
            this.PnlEliminar.Controls.Add(this.TxtConfirmarLiquidacion);
            this.PnlEliminar.Controls.Add(this.BtnEliminar);
            this.PnlEliminar.Controls.Add(this.dataGridViewRegistro);
            this.PnlEliminar.Controls.Add(this.label3);
            this.PnlEliminar.Controls.Add(this.label2);
            this.PnlEliminar.Controls.Add(this.label5);
            this.PnlEliminar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlEliminar.Location = new System.Drawing.Point(0, 0);
            this.PnlEliminar.Name = "PnlEliminar";
            this.PnlEliminar.Size = new System.Drawing.Size(777, 490);
            this.PnlEliminar.TabIndex = 1;
            // 
            // TxtNumeroLiquidacion
            // 
            this.TxtNumeroLiquidacion.Font = new System.Drawing.Font("Britannic Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtNumeroLiquidacion.Location = new System.Drawing.Point(383, 136);
            this.TxtNumeroLiquidacion.Name = "TxtNumeroLiquidacion";
            this.TxtNumeroLiquidacion.Size = new System.Drawing.Size(112, 22);
            this.TxtNumeroLiquidacion.TabIndex = 16;
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.BtnEliminar.FlatAppearance.BorderSize = 0;
            this.BtnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEliminar.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnEliminar.Image = global::Presentacion_GUI.Properties.Resources.eliminar;
            this.BtnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnEliminar.Location = new System.Drawing.Point(614, 439);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(151, 39);
            this.BtnEliminar.TabIndex = 13;
            this.BtnEliminar.Text = "     ELIMINAR";
            this.BtnEliminar.UseVisualStyleBackColor = false;
            // 
            // dataGridViewRegistro
            // 
            this.dataGridViewRegistro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRegistro.Location = new System.Drawing.Point(90, 173);
            this.dataGridViewRegistro.Name = "dataGridViewRegistro";
            this.dataGridViewRegistro.RowTemplate.Height = 25;
            this.dataGridViewRegistro.Size = new System.Drawing.Size(595, 168);
            this.dataGridViewRegistro.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(90, 364);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(220, 18);
            this.label3.TabIndex = 11;
            this.label3.Text = "Confirme Numero Liquidacion";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(184, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 18);
            this.label2.TabIndex = 10;
            this.label2.Text = "Numero Liquidacion";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Modern No. 20", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(262, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(163, 31);
            this.label5.TabIndex = 9;
            this.label5.Text = "ELIMINAR";
            // 
            // TxtConfirmarLiquidacion
            // 
            this.TxtConfirmarLiquidacion.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtConfirmarLiquidacion.Location = new System.Drawing.Point(331, 364);
            this.TxtConfirmarLiquidacion.Name = "TxtConfirmarLiquidacion";
            this.TxtConfirmarLiquidacion.Size = new System.Drawing.Size(113, 22);
            this.TxtConfirmarLiquidacion.TabIndex = 15;
            // 
            // FrmEliminar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(777, 490);
            this.Controls.Add(this.PnlEliminar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmEliminar";
            this.Text = "FrmEliminar";
            this.PnlEliminar.ResumeLayout(false);
            this.PnlEliminar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRegistro)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PnlEliminar;
        private System.Windows.Forms.TextBox TxtNumeroLiquidacion;
        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.DataGridView dataGridViewRegistro;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtConfirmarLiquidacion;
    }
}