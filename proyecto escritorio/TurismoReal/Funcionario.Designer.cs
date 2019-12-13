namespace TurismoReal
{
    partial class Funcionario
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.chekinToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkinToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarCheckINToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkOutToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.buscarCheckOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.chekinToolStripMenuItem,
            this.checkOutToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(600, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // chekinToolStripMenuItem
            // 
            this.chekinToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.checkinToolStripMenuItem,
            this.buscarCheckINToolStripMenuItem});
            this.chekinToolStripMenuItem.Name = "chekinToolStripMenuItem";
            this.chekinToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.chekinToolStripMenuItem.Text = "Chekin";
            // 
            // checkinToolStripMenuItem
            // 
            this.checkinToolStripMenuItem.Name = "checkinToolStripMenuItem";
            this.checkinToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.checkinToolStripMenuItem.Text = "Checkin";
            this.checkinToolStripMenuItem.Click += new System.EventHandler(this.CheckinToolStripMenuItem_Click);
            // 
            // buscarCheckINToolStripMenuItem
            // 
            this.buscarCheckINToolStripMenuItem.Name = "buscarCheckINToolStripMenuItem";
            this.buscarCheckINToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.buscarCheckINToolStripMenuItem.Text = "Buscar CheckIN";
            this.buscarCheckINToolStripMenuItem.Click += new System.EventHandler(this.BuscarCheckINToolStripMenuItem_Click);
            // 
            // checkOutToolStripMenuItem
            // 
            this.checkOutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.checkOutToolStripMenuItem1,
            this.buscarCheckOutToolStripMenuItem});
            this.checkOutToolStripMenuItem.Name = "checkOutToolStripMenuItem";
            this.checkOutToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.checkOutToolStripMenuItem.Text = "CheckOut";
            // 
            // checkOutToolStripMenuItem1
            // 
            this.checkOutToolStripMenuItem1.Name = "checkOutToolStripMenuItem1";
            this.checkOutToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.checkOutToolStripMenuItem1.Text = "CheckOut";
            this.checkOutToolStripMenuItem1.Click += new System.EventHandler(this.CheckOutToolStripMenuItem1_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salirToolStripMenuItem1});
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.salirToolStripMenuItem.Text = "Salir";
            // 
            // salirToolStripMenuItem1
            // 
            this.salirToolStripMenuItem1.Name = "salirToolStripMenuItem1";
            this.salirToolStripMenuItem1.Size = new System.Drawing.Size(96, 22);
            this.salirToolStripMenuItem1.Text = "Salir";
            this.salirToolStripMenuItem1.Click += new System.EventHandler(this.SalirToolStripMenuItem1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(71, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Bienvenido Funcionario:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(199, 60);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(35, 13);
            this.lblNombre.TabIndex = 2;
            this.lblNombre.Text = "label2";
            // 
            // buscarCheckOutToolStripMenuItem
            // 
            this.buscarCheckOutToolStripMenuItem.Name = "buscarCheckOutToolStripMenuItem";
            this.buscarCheckOutToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.buscarCheckOutToolStripMenuItem.Text = "Buscar CheckOut";
            this.buscarCheckOutToolStripMenuItem.Click += new System.EventHandler(this.BuscarCheckOutToolStripMenuItem_Click);
            // 
            // Funcionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TurismoReal.Properties.Resources.turismo;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Funcionario";
            this.Text = "Funcionario";
            this.Load += new System.EventHandler(this.Funcionario_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem chekinToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem checkinToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem checkOutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem checkOutToolStripMenuItem1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem buscarCheckINToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buscarCheckOutToolStripMenuItem;
    }
}