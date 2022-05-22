namespace Sistema
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.mantenedorClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mantenedorProductoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mantenedorClienteToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.mantenedorClienteToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.vendedorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mantenedorVendedorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.almacenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mantenedorAlmacenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tecnicoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mantenedorTecnicoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.citasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mantenedorCitasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.piezasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manteneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mantenedorClienteToolStripMenuItem
            // 
            this.mantenedorClienteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mantenedorProductoToolStripMenuItem});
            this.mantenedorClienteToolStripMenuItem.Name = "mantenedorClienteToolStripMenuItem";
            this.mantenedorClienteToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.mantenedorClienteToolStripMenuItem.Text = "Producto";
            // 
            // mantenedorProductoToolStripMenuItem
            // 
            this.mantenedorProductoToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.mantenedorProductoToolStripMenuItem.Name = "mantenedorProductoToolStripMenuItem";
            this.mantenedorProductoToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.mantenedorProductoToolStripMenuItem.Text = "Mantenedor Producto";
            this.mantenedorProductoToolStripMenuItem.Click += new System.EventHandler(this.mantenedorProductoToolStripMenuItem_Click);
            // 
            // mantenedorClienteToolStripMenuItem1
            // 
            this.mantenedorClienteToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mantenedorClienteToolStripMenuItem2});
            this.mantenedorClienteToolStripMenuItem1.Name = "mantenedorClienteToolStripMenuItem1";
            this.mantenedorClienteToolStripMenuItem1.Size = new System.Drawing.Size(56, 20);
            this.mantenedorClienteToolStripMenuItem1.Text = "Cliente";
            // 
            // mantenedorClienteToolStripMenuItem2
            // 
            this.mantenedorClienteToolStripMenuItem2.Name = "mantenedorClienteToolStripMenuItem2";
            this.mantenedorClienteToolStripMenuItem2.Size = new System.Drawing.Size(179, 22);
            this.mantenedorClienteToolStripMenuItem2.Text = "Mantenedor Cliente";
            this.mantenedorClienteToolStripMenuItem2.Click += new System.EventHandler(this.mantenedorClienteToolStripMenuItem2_Click);
            // 
            // vendedorToolStripMenuItem
            // 
            this.vendedorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mantenedorVendedorToolStripMenuItem});
            this.vendedorToolStripMenuItem.Name = "vendedorToolStripMenuItem";
            this.vendedorToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.vendedorToolStripMenuItem.Text = "Vendedor";
            // 
            // mantenedorVendedorToolStripMenuItem
            // 
            this.mantenedorVendedorToolStripMenuItem.Name = "mantenedorVendedorToolStripMenuItem";
            this.mantenedorVendedorToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.mantenedorVendedorToolStripMenuItem.Text = "Mantenedor Vendedor";
            // 
            // almacenToolStripMenuItem
            // 
            this.almacenToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mantenedorAlmacenToolStripMenuItem});
            this.almacenToolStripMenuItem.Name = "almacenToolStripMenuItem";
            this.almacenToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.almacenToolStripMenuItem.Text = "Almacen";
            // 
            // mantenedorAlmacenToolStripMenuItem
            // 
            this.mantenedorAlmacenToolStripMenuItem.Name = "mantenedorAlmacenToolStripMenuItem";
            this.mantenedorAlmacenToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.mantenedorAlmacenToolStripMenuItem.Text = "Mantenedor Almacen";
            // 
            // tecnicoToolStripMenuItem
            // 
            this.tecnicoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mantenedorTecnicoToolStripMenuItem});
            this.tecnicoToolStripMenuItem.Name = "tecnicoToolStripMenuItem";
            this.tecnicoToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.tecnicoToolStripMenuItem.Text = "Tecnico";
            // 
            // mantenedorTecnicoToolStripMenuItem
            // 
            this.mantenedorTecnicoToolStripMenuItem.Name = "mantenedorTecnicoToolStripMenuItem";
            this.mantenedorTecnicoToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.mantenedorTecnicoToolStripMenuItem.Text = "Mantenedor Tecnico";
            this.mantenedorTecnicoToolStripMenuItem.Click += new System.EventHandler(this.mantenedorTecnicoToolStripMenuItem_Click);
            // 
            // citasToolStripMenuItem
            // 
            this.citasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mantenedorCitasToolStripMenuItem});
            this.citasToolStripMenuItem.Name = "citasToolStripMenuItem";
            this.citasToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
            this.citasToolStripMenuItem.Text = "Citas";
            // 
            // mantenedorCitasToolStripMenuItem
            // 
            this.mantenedorCitasToolStripMenuItem.Name = "mantenedorCitasToolStripMenuItem";
            this.mantenedorCitasToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.mantenedorCitasToolStripMenuItem.Text = "Mantenedor Citas";
            // 
            // piezasToolStripMenuItem
            // 
            this.piezasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manteneToolStripMenuItem});
            this.piezasToolStripMenuItem.Name = "piezasToolStripMenuItem";
            this.piezasToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.piezasToolStripMenuItem.Text = "Piezas";
            // 
            // manteneToolStripMenuItem
            // 
            this.manteneToolStripMenuItem.Name = "manteneToolStripMenuItem";
            this.manteneToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.manteneToolStripMenuItem.Text = "Mantenedor de Piezas";
            this.manteneToolStripMenuItem.Click += new System.EventHandler(this.manteneToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mantenedorClienteToolStripMenuItem,
            this.mantenedorClienteToolStripMenuItem1,
            this.vendedorToolStripMenuItem,
            this.almacenToolStripMenuItem,
            this.tecnicoToolStripMenuItem,
            this.citasToolStripMenuItem,
            this.piezasToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(558, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 248);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Mantenimiento";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripMenuItem mantenedorClienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mantenedorProductoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mantenedorClienteToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem mantenedorClienteToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem vendedorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mantenedorVendedorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem almacenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mantenedorAlmacenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tecnicoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mantenedorTecnicoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem citasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mantenedorCitasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem piezasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manteneToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
    }
}

