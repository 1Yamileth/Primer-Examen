namespace FormMenu
{
    partial class EJERICICIO2
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Products_GridView = new System.Windows.Forms.DataGridView();
            this.Producto_textBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.Precio_Pro_textBox = new System.Windows.Forms.TextBox();
            this.Cantidad_Pro_textBox = new System.Windows.Forms.TextBox();
            this.Descuento_button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.CantidadColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Products_GridView)).BeginInit();
            this.SuspendLayout();
            // 
            // Products_GridView
            // 
            this.Products_GridView.AllowUserToAddRows = false;
            this.Products_GridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Products_GridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CantidadColumn1,
            this.NombreColumn,
            this.PrecioColumn1});
            this.Products_GridView.Location = new System.Drawing.Point(12, 187);
            this.Products_GridView.Name = "Products_GridView";
            this.Products_GridView.ReadOnly = true;
            this.Products_GridView.Size = new System.Drawing.Size(344, 180);
            this.Products_GridView.TabIndex = 0;
            this.Products_GridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Products_GridView_CellContentClick);
            // 
            // Producto_textBox
            // 
            this.Producto_textBox.Location = new System.Drawing.Point(244, 27);
            this.Producto_textBox.Name = "Producto_textBox";
            this.Producto_textBox.Size = new System.Drawing.Size(131, 20);
            this.Producto_textBox.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(455, 27);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(183, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "AGREGAR PRODUCTO";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Precio_Pro_textBox
            // 
            this.Precio_Pro_textBox.Location = new System.Drawing.Point(244, 69);
            this.Precio_Pro_textBox.Name = "Precio_Pro_textBox";
            this.Precio_Pro_textBox.Size = new System.Drawing.Size(131, 20);
            this.Precio_Pro_textBox.TabIndex = 4;
            // 
            // Cantidad_Pro_textBox
            // 
            this.Cantidad_Pro_textBox.Location = new System.Drawing.Point(244, 114);
            this.Cantidad_Pro_textBox.Name = "Cantidad_Pro_textBox";
            this.Cantidad_Pro_textBox.Size = new System.Drawing.Size(131, 20);
            this.Cantidad_Pro_textBox.TabIndex = 5;
            // 
            // Descuento_button
            // 
            this.Descuento_button.Location = new System.Drawing.Point(455, 72);
            this.Descuento_button.Name = "Descuento_button";
            this.Descuento_button.Size = new System.Drawing.Size(183, 23);
            this.Descuento_button.TabIndex = 6;
            this.Descuento_button.Text = "CALCULAR DESCUENTO";
            this.Descuento_button.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "INGRESE EL PRODUCTO A COMPRAR";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(205, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "INGRESE EL PRECIO DEL PRODUCTO ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(220, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "INGRESE LA CANTIDAD DEL PRODUCTO ";
            // 
            // CantidadColumn1
            // 
            this.CantidadColumn1.Frozen = true;
            this.CantidadColumn1.HeaderText = "Cantidad";
            this.CantidadColumn1.Name = "CantidadColumn1";
            this.CantidadColumn1.ReadOnly = true;
            // 
            // NombreColumn
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            this.NombreColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.NombreColumn.Frozen = true;
            this.NombreColumn.HeaderText = "Nombre";
            this.NombreColumn.Name = "NombreColumn";
            this.NombreColumn.ReadOnly = true;
            // 
            // PrecioColumn1
            // 
            this.PrecioColumn1.Frozen = true;
            this.PrecioColumn1.HeaderText = "Precio";
            this.PrecioColumn1.Name = "PrecioColumn1";
            this.PrecioColumn1.ReadOnly = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(455, 119);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(183, 23);
            this.button2.TabIndex = 10;
            this.button2.Text = "SALIR";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // EJERICICIO2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Descuento_button);
            this.Controls.Add(this.Cantidad_Pro_textBox);
            this.Controls.Add(this.Precio_Pro_textBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Producto_textBox);
            this.Controls.Add(this.Products_GridView);
            this.Name = "EJERICICIO2";
            this.Text = "EJERICICIO2";
            this.Load += new System.EventHandler(this.EJERICICIO2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Products_GridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Products_GridView;
        private System.Windows.Forms.TextBox Producto_textBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox Precio_Pro_textBox;
        private System.Windows.Forms.TextBox Cantidad_Pro_textBox;
        private System.Windows.Forms.Button Descuento_button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn CantidadColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioColumn1;
        private System.Windows.Forms.Button button2;
    }
}