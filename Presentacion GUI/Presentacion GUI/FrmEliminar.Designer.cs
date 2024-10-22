﻿
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.PnlEliminar = new System.Windows.Forms.Panel();
            this.DGEliminar = new System.Windows.Forms.DataGridView();
            this.TxtNumeroLiquidacion = new System.Windows.Forms.TextBox();
            this.TxtConfirmarLiquidacion = new System.Windows.Forms.TextBox();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.errorProviderNumeroLiquidacion = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderConfirmarLiquidacion = new System.Windows.Forms.ErrorProvider(this.components);
            this.PnlEliminar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGEliminar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderNumeroLiquidacion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderConfirmarLiquidacion)).BeginInit();
            this.SuspendLayout();
            // 
            // PnlEliminar
            // 
            this.PnlEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.PnlEliminar.Controls.Add(this.DGEliminar);
            this.PnlEliminar.Controls.Add(this.TxtNumeroLiquidacion);
            this.PnlEliminar.Controls.Add(this.TxtConfirmarLiquidacion);
            this.PnlEliminar.Controls.Add(this.BtnEliminar);
            this.PnlEliminar.Controls.Add(this.label3);
            this.PnlEliminar.Controls.Add(this.label2);
            this.PnlEliminar.Controls.Add(this.label5);
            this.PnlEliminar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlEliminar.Location = new System.Drawing.Point(0, 0);
            this.PnlEliminar.Name = "PnlEliminar";
            this.PnlEliminar.Size = new System.Drawing.Size(777, 490);
            this.PnlEliminar.TabIndex = 1;
            // 
            // DGEliminar
            // 
            this.DGEliminar.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGEliminar.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DGEliminar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGEliminar.DefaultCellStyle = dataGridViewCellStyle2;
            this.DGEliminar.GridColor = System.Drawing.Color.White;
            this.DGEliminar.Location = new System.Drawing.Point(132, 182);
            this.DGEliminar.Name = "DGEliminar";
            this.DGEliminar.RowTemplate.Height = 25;
            this.DGEliminar.Size = new System.Drawing.Size(507, 158);
            this.DGEliminar.TabIndex = 17;
            // 
            // TxtNumeroLiquidacion
            // 
            this.TxtNumeroLiquidacion.Font = new System.Drawing.Font("Britannic Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtNumeroLiquidacion.Location = new System.Drawing.Point(383, 136);
            this.TxtNumeroLiquidacion.Name = "TxtNumeroLiquidacion";
            this.TxtNumeroLiquidacion.Size = new System.Drawing.Size(112, 22);
            this.TxtNumeroLiquidacion.TabIndex = 16;
            this.TxtNumeroLiquidacion.Validating += new System.ComponentModel.CancelEventHandler(this.TxtNumeroLiquidacion_Validating);
            this.TxtNumeroLiquidacion.Validated += new System.EventHandler(this.TxtNumeroLiquidacion_Validated);
            // 
            // TxtConfirmarLiquidacion
            // 
            this.TxtConfirmarLiquidacion.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtConfirmarLiquidacion.Location = new System.Drawing.Point(331, 364);
            this.TxtConfirmarLiquidacion.Name = "TxtConfirmarLiquidacion";
            this.TxtConfirmarLiquidacion.Size = new System.Drawing.Size(113, 22);
            this.TxtConfirmarLiquidacion.TabIndex = 15;
            this.TxtConfirmarLiquidacion.Validating += new System.ComponentModel.CancelEventHandler(this.TxtConfirmarLiquidacion_Validating);
            this.TxtConfirmarLiquidacion.Validated += new System.EventHandler(this.TxtConfirmarLiquidacion_Validated);
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
            this.BtnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
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
            // errorProviderNumeroLiquidacion
            // 
            this.errorProviderNumeroLiquidacion.ContainerControl = this;
            // 
            // errorProviderConfirmarLiquidacion
            // 
            this.errorProviderConfirmarLiquidacion.ContainerControl = this;
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
            ((System.ComponentModel.ISupportInitialize)(this.DGEliminar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderNumeroLiquidacion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderConfirmarLiquidacion)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PnlEliminar;
        private System.Windows.Forms.TextBox TxtNumeroLiquidacion;
        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtConfirmarLiquidacion;
        private System.Windows.Forms.ErrorProvider errorProviderNumeroLiquidacion;
        private System.Windows.Forms.ErrorProvider errorProviderConfirmarLiquidacion;
        private System.Windows.Forms.DataGridView DGEliminar;
    }
}