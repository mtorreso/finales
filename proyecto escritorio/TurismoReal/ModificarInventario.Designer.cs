namespace TurismoReal
{
    partial class ModificarInventario
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtID_dpto = new System.Windows.Forms.TextBox();
            this.txtProducto = new System.Windows.Forms.TextBox();
            this.cbxCantidad = new System.Windows.Forms.ComboBox();
            this.cbxEstado = new System.Windows.Forms.ComboBox();
            this.rtxtDescripcion = new System.Windows.Forms.RichTextBox();
            this.cbxCategoria = new System.Windows.Forms.ComboBox();
            this.dbgListar = new System.Windows.Forms.DataGridView();
            this.txtInventario = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dbgListar)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id Departamento";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Producto";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Cantidad";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(314, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Estado";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(549, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Descripcion";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(314, 101);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Categoria";
            // 
            // txtID_dpto
            // 
            this.txtID_dpto.Location = new System.Drawing.Point(134, 24);
            this.txtID_dpto.Name = "txtID_dpto";
            this.txtID_dpto.Size = new System.Drawing.Size(100, 20);
            this.txtID_dpto.TabIndex = 6;
            // 
            // txtProducto
            // 
            this.txtProducto.Location = new System.Drawing.Point(134, 61);
            this.txtProducto.Name = "txtProducto";
            this.txtProducto.Size = new System.Drawing.Size(100, 20);
            this.txtProducto.TabIndex = 7;
            // 
            // cbxCantidad
            // 
            this.cbxCantidad.FormattingEnabled = true;
            this.cbxCantidad.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9"});
            this.cbxCantidad.Location = new System.Drawing.Point(134, 93);
            this.cbxCantidad.Name = "cbxCantidad";
            this.cbxCantidad.Size = new System.Drawing.Size(121, 21);
            this.cbxCantidad.TabIndex = 8;
            // 
            // cbxEstado
            // 
            this.cbxEstado.FormattingEnabled = true;
            this.cbxEstado.Items.AddRange(new object[] {
            "Activo",
            "No Activo"});
            this.cbxEstado.Location = new System.Drawing.Point(381, 24);
            this.cbxEstado.Name = "cbxEstado";
            this.cbxEstado.Size = new System.Drawing.Size(121, 21);
            this.cbxEstado.TabIndex = 9;
            // 
            // rtxtDescripcion
            // 
            this.rtxtDescripcion.Location = new System.Drawing.Point(618, 27);
            this.rtxtDescripcion.Name = "rtxtDescripcion";
            this.rtxtDescripcion.Size = new System.Drawing.Size(170, 112);
            this.rtxtDescripcion.TabIndex = 10;
            this.rtxtDescripcion.Text = "";
            // 
            // cbxCategoria
            // 
            this.cbxCategoria.FormattingEnabled = true;
            this.cbxCategoria.Items.AddRange(new object[] {
            "Muebleria",
            "Electronica"});
            this.cbxCategoria.Location = new System.Drawing.Point(381, 101);
            this.cbxCategoria.Name = "cbxCategoria";
            this.cbxCategoria.Size = new System.Drawing.Size(121, 21);
            this.cbxCategoria.TabIndex = 11;
            // 
            // dbgListar
            // 
            this.dbgListar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dbgListar.Location = new System.Drawing.Point(23, 302);
            this.dbgListar.Name = "dbgListar";
            this.dbgListar.Size = new System.Drawing.Size(762, 150);
            this.dbgListar.TabIndex = 12;
            // 
            // txtInventario
            // 
            this.txtInventario.Location = new System.Drawing.Point(297, 221);
            this.txtInventario.Name = "txtInventario";
            this.txtInventario.Size = new System.Drawing.Size(100, 20);
            this.txtInventario.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(211, 224);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Id Inventario";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(424, 217);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 15;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(526, 218);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 23);
            this.btnModificar.TabIndex = 16;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.BtnModificar_Click);
            // 
            // ModificarInventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(797, 464);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtInventario);
            this.Controls.Add(this.dbgListar);
            this.Controls.Add(this.cbxCategoria);
            this.Controls.Add(this.rtxtDescripcion);
            this.Controls.Add(this.cbxEstado);
            this.Controls.Add(this.cbxCantidad);
            this.Controls.Add(this.txtProducto);
            this.Controls.Add(this.txtID_dpto);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ModificarInventario";
            this.Text = "ModificarInventario";
            ((System.ComponentModel.ISupportInitialize)(this.dbgListar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtID_dpto;
        private System.Windows.Forms.TextBox txtProducto;
        private System.Windows.Forms.ComboBox cbxCantidad;
        private System.Windows.Forms.ComboBox cbxEstado;
        private System.Windows.Forms.RichTextBox rtxtDescripcion;
        private System.Windows.Forms.ComboBox cbxCategoria;
        private System.Windows.Forms.DataGridView dbgListar;
        private System.Windows.Forms.TextBox txtInventario;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnModificar;
    }
}