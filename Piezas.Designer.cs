﻿
namespace Sistema
{
    partial class Piezas
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
            this.txtfabri = new System.Windows.Forms.TextBox();
            this.txtStock = new System.Windows.Forms.TextBox();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dgvPiezas = new System.Windows.Forms.DataGridView();
            this.txtCosto = new System.Windows.Forms.TextBox();
            this.txtcop = new System.Windows.Forms.TextBox();
            this.txtxcod = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPiezas)).BeginInit();
            this.SuspendLayout();
            // 
            // txtfabri
            // 
            this.txtfabri.Location = new System.Drawing.Point(115, 173);
            this.txtfabri.Name = "txtfabri";
            this.txtfabri.Size = new System.Drawing.Size(135, 20);
            this.txtfabri.TabIndex = 17;
            // 
            // txtStock
            // 
            this.txtStock.Location = new System.Drawing.Point(115, 133);
            this.txtStock.Name = "txtStock";
            this.txtStock.Size = new System.Drawing.Size(81, 20);
            this.txtStock.TabIndex = 18;
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(115, 56);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(167, 20);
            this.txtnombre.TabIndex = 19;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(27, 133);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Stock";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 173);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Fabrica";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Costo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Codigo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Nombre";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(634, 210);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 9;
            this.button5.Text = "Eliminar";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(634, 152);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 10;
            this.button4.Text = "Editar";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(634, 88);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 11;
            this.button3.Text = "Agregar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(634, 258);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 8;
            this.button2.Text = "Cargar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // dgvPiezas
            // 
            this.dgvPiezas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPiezas.Location = new System.Drawing.Point(30, 223);
            this.dgvPiezas.Name = "dgvPiezas";
            this.dgvPiezas.ReadOnly = true;
            this.dgvPiezas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPiezas.Size = new System.Drawing.Size(537, 150);
            this.dgvPiezas.TabIndex = 7;
            this.dgvPiezas.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPiezas_CellDoubleClick);
            // 
            // txtCosto
            // 
            this.txtCosto.Location = new System.Drawing.Point(115, 92);
            this.txtCosto.Name = "txtCosto";
            this.txtCosto.Size = new System.Drawing.Size(100, 20);
            this.txtCosto.TabIndex = 22;
            // 
            // txtcop
            // 
            this.txtcop.Location = new System.Drawing.Point(376, 40);
            this.txtcop.Name = "txtcop";
            this.txtcop.Size = new System.Drawing.Size(100, 20);
            this.txtcop.TabIndex = 23;
            // 
            // txtxcod
            // 
            this.txtxcod.Location = new System.Drawing.Point(115, 22);
            this.txtxcod.Name = "txtxcod";
            this.txtxcod.Size = new System.Drawing.Size(100, 20);
            this.txtxcod.TabIndex = 24;
            // 
            // Piezas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtxcod);
            this.Controls.Add(this.txtcop);
            this.Controls.Add(this.txtCosto);
            this.Controls.Add(this.txtfabri);
            this.Controls.Add(this.txtStock);
            this.Controls.Add(this.txtnombre);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dgvPiezas);
            this.Name = "Piezas";
            this.Text = "Piezas";
            this.Load += new System.EventHandler(this.Piezas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPiezas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtfabri;
        private System.Windows.Forms.TextBox txtStock;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dgvPiezas;
        private System.Windows.Forms.TextBox txtCosto;
        private System.Windows.Forms.TextBox txtcop;
        private System.Windows.Forms.TextBox txtxcod;
    }
}