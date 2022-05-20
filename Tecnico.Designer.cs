
namespace Sistema
{
    partial class Tecnico
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
            this.txtIdTecnico = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDireccionTecnico = new System.Windows.Forms.TextBox();
            this.txtTelefonoTecnico = new System.Windows.Forms.TextBox();
            this.txtNombreTecnico = new System.Windows.Forms.TextBox();
            this.txtEmailTecnico = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtIdTecnico
            // 
            this.txtIdTecnico.Location = new System.Drawing.Point(168, 55);
            this.txtIdTecnico.Name = "txtIdTecnico";
            this.txtIdTecnico.Size = new System.Drawing.Size(96, 22);
            this.txtIdTecnico.TabIndex = 0;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(464, 51);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(100, 31);
            this.btnAgregar.TabIndex = 1;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "ID";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtDireccionTecnico
            // 
            this.txtDireccionTecnico.Location = new System.Drawing.Point(168, 134);
            this.txtDireccionTecnico.Name = "txtDireccionTecnico";
            this.txtDireccionTecnico.Size = new System.Drawing.Size(238, 22);
            this.txtDireccionTecnico.TabIndex = 3;
            // 
            // txtTelefonoTecnico
            // 
            this.txtTelefonoTecnico.Location = new System.Drawing.Point(168, 174);
            this.txtTelefonoTecnico.Name = "txtTelefonoTecnico";
            this.txtTelefonoTecnico.Size = new System.Drawing.Size(112, 22);
            this.txtTelefonoTecnico.TabIndex = 4;
            // 
            // txtNombreTecnico
            // 
            this.txtNombreTecnico.Location = new System.Drawing.Point(168, 93);
            this.txtNombreTecnico.Name = "txtNombreTecnico";
            this.txtNombreTecnico.Size = new System.Drawing.Size(201, 22);
            this.txtNombreTecnico.TabIndex = 5;
            // 
            // txtEmailTecnico
            // 
            this.txtEmailTecnico.Location = new System.Drawing.Point(168, 218);
            this.txtEmailTecnico.Name = "txtEmailTecnico";
            this.txtEmailTecnico.Size = new System.Drawing.Size(238, 22);
            this.txtEmailTecnico.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 221);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Email";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(55, 179);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Telefono";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(55, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Direccion";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(55, 93);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Nombre";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(58, 274);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(716, 164);
            this.dataGridView1.TabIndex = 11;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Tecnico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtEmailTecnico);
            this.Controls.Add(this.txtNombreTecnico);
            this.Controls.Add(this.txtTelefonoTecnico);
            this.Controls.Add(this.txtDireccionTecnico);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.txtIdTecnico);
            this.Name = "Tecnico";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Tecnico_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtIdTecnico;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDireccionTecnico;
        private System.Windows.Forms.TextBox txtTelefonoTecnico;
        private System.Windows.Forms.TextBox txtNombreTecnico;
        private System.Windows.Forms.TextBox txtEmailTecnico;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}