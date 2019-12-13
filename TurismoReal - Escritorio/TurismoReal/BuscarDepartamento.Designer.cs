namespace TurismoReal
{
    partial class BuscarDepartamento
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
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.btnBuscarDepartamento = new System.Windows.Forms.Button();
            this.dgbListarDpto = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgbListarDpto)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(133, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID DEPARTAMENTO";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(262, 65);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 1;
            // 
            // btnBuscarDepartamento
            // 
            this.btnBuscarDepartamento.Location = new System.Drawing.Point(382, 63);
            this.btnBuscarDepartamento.Name = "btnBuscarDepartamento";
            this.btnBuscarDepartamento.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarDepartamento.TabIndex = 2;
            this.btnBuscarDepartamento.Text = "Buscar";
            this.btnBuscarDepartamento.UseVisualStyleBackColor = true;
            this.btnBuscarDepartamento.Click += new System.EventHandler(this.BtnBuscarDepartamento_Click);
            // 
            // dgbListarDpto
            // 
            this.dgbListarDpto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgbListarDpto.Location = new System.Drawing.Point(12, 231);
            this.dgbListarDpto.Name = "dgbListarDpto";
            this.dgbListarDpto.Size = new System.Drawing.Size(776, 207);
            this.dgbListarDpto.TabIndex = 3;
            // 
            // BuscarDepartamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgbListarDpto);
            this.Controls.Add(this.btnBuscarDepartamento);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label1);
            this.Name = "BuscarDepartamento";
            this.Text = "BuscarDepartamento";
            ((System.ComponentModel.ISupportInitialize)(this.dgbListarDpto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Button btnBuscarDepartamento;
        private System.Windows.Forms.DataGridView dgbListarDpto;
    }
}