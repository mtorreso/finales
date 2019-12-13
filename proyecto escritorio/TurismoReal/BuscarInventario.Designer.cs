namespace TurismoReal
{
    partial class BuscarInventario
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtInventario = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.dgbListar = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgbListar)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 62);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Producto";
            // 
            // txtInventario
            // 
            this.txtInventario.Location = new System.Drawing.Point(184, 62);
            this.txtInventario.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtInventario.Name = "txtInventario";
            this.txtInventario.Size = new System.Drawing.Size(132, 22);
            this.txtInventario.TabIndex = 1;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(383, 57);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(100, 28);
            this.btnBuscar.TabIndex = 2;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // dgbListar
            // 
            this.dgbListar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgbListar.Location = new System.Drawing.Point(16, 142);
            this.dgbListar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgbListar.Name = "dgbListar";
            this.dgbListar.RowHeadersWidth = 51;
            this.dgbListar.Size = new System.Drawing.Size(841, 185);
            this.dgbListar.TabIndex = 3;
            // 
            // BuscarInventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(880, 385);
            this.Controls.Add(this.dgbListar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtInventario);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "BuscarInventario";
            this.Text = "BuscarInventario";
            ((System.ComponentModel.ISupportInitialize)(this.dgbListar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtInventario;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.DataGridView dgbListar;
    }
}