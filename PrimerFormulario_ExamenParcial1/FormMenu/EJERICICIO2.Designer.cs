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
            this.Producto_textBox = new System.Windows.Forms.TextBox();
            this.Precio_Pro_textBox = new System.Windows.Forms.TextBox();
            this.Cantidad_Pro_textBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Prodcutos_dataGridView = new System.Windows.Forms.DataGridView();
            this.ProductoColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CANTIDADColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Agregar_button = new System.Windows.Forms.Button();
            this.Salir_button = new System.Windows.Forms.Button();
            this.Descuento_button = new System.Windows.Forms.Button();
            this.Regreso_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Prodcutos_dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Producto_textBox
            // 
            this.Producto_textBox.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F);
            this.Producto_textBox.Location = new System.Drawing.Point(333, 81);
            this.Producto_textBox.Name = "Producto_textBox";
            this.Producto_textBox.Size = new System.Drawing.Size(131, 25);
            this.Producto_textBox.TabIndex = 2;
            this.Producto_textBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Producto_textBox_KeyPress);
            // 
            // Precio_Pro_textBox
            // 
            this.Precio_Pro_textBox.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F);
            this.Precio_Pro_textBox.Location = new System.Drawing.Point(333, 103);
            this.Precio_Pro_textBox.Name = "Precio_Pro_textBox";
            this.Precio_Pro_textBox.Size = new System.Drawing.Size(131, 25);
            this.Precio_Pro_textBox.TabIndex = 4;
            this.Precio_Pro_textBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Precio_Pro_textBox_KeyPress);
            // 
            // Cantidad_Pro_textBox
            // 
            this.Cantidad_Pro_textBox.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F);
            this.Cantidad_Pro_textBox.Location = new System.Drawing.Point(333, 126);
            this.Cantidad_Pro_textBox.Name = "Cantidad_Pro_textBox";
            this.Cantidad_Pro_textBox.Size = new System.Drawing.Size(131, 25);
            this.Cantidad_Pro_textBox.TabIndex = 5;
            this.Cantidad_Pro_textBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Cantidad_Pro_textBox_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F);
            this.label1.Location = new System.Drawing.Point(13, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(269, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "INGRESE EL PRODUCTO A COMPRAR";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F);
            this.label2.Location = new System.Drawing.Point(14, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(271, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "INGRESE EL PRECIO DEL PRODUCTO ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F);
            this.label3.Location = new System.Drawing.Point(13, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(299, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "INGRESE LA CANTIDAD DEL PRODUCTO ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F);
            this.label4.Location = new System.Drawing.Point(33, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 16);
            this.label4.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F);
            this.label5.Location = new System.Drawing.Point(199, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(281, 16);
            this.label5.TabIndex = 12;
            this.label5.Text = "BIENVENIDO A NUESTRO MERCADITO";
            // 
            // Prodcutos_dataGridView
            // 
            this.Prodcutos_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Prodcutos_dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProductoColumn1,
            this.PrecioColumn1,
            this.CANTIDADColumn});
            this.Prodcutos_dataGridView.Location = new System.Drawing.Point(356, 186);
            this.Prodcutos_dataGridView.Name = "Prodcutos_dataGridView";
            this.Prodcutos_dataGridView.Size = new System.Drawing.Size(326, 236);
            this.Prodcutos_dataGridView.TabIndex = 14;
            // 
            // ProductoColumn1
            // 
            this.ProductoColumn1.Frozen = true;
            this.ProductoColumn1.HeaderText = "PRODUCTO";
            this.ProductoColumn1.Name = "ProductoColumn1";
            this.ProductoColumn1.ReadOnly = true;
            // 
            // PrecioColumn1
            // 
            this.PrecioColumn1.Frozen = true;
            this.PrecioColumn1.HeaderText = "PRECIO";
            this.PrecioColumn1.Name = "PrecioColumn1";
            this.PrecioColumn1.ReadOnly = true;
            // 
            // CANTIDADColumn
            // 
            this.CANTIDADColumn.Frozen = true;
            this.CANTIDADColumn.HeaderText = "CANTIDAD";
            this.CANTIDADColumn.Name = "CANTIDADColumn";
            this.CANTIDADColumn.ReadOnly = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::FormMenu.Properties.Resources.mercado;
            this.pictureBox1.Location = new System.Drawing.Point(486, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(59, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // Agregar_button
            // 
            this.Agregar_button.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F);
            this.Agregar_button.Image = global::FormMenu.Properties.Resources.carrito_de_compras;
            this.Agregar_button.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Agregar_button.Location = new System.Drawing.Point(36, 186);
            this.Agregar_button.Name = "Agregar_button";
            this.Agregar_button.Size = new System.Drawing.Size(246, 58);
            this.Agregar_button.TabIndex = 13;
            this.Agregar_button.Text = "AGREGAR PRODUCTO";
            this.Agregar_button.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Agregar_button.UseVisualStyleBackColor = true;
            this.Agregar_button.Click += new System.EventHandler(this.Agregar_button_Click);
            // 
            // Salir_button
            // 
            this.Salir_button.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F);
            this.Salir_button.Image = global::FormMenu.Properties.Resources.boton_x;
            this.Salir_button.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Salir_button.Location = new System.Drawing.Point(36, 323);
            this.Salir_button.Name = "Salir_button";
            this.Salir_button.Size = new System.Drawing.Size(194, 53);
            this.Salir_button.TabIndex = 10;
            this.Salir_button.Text = "CANCELAR";
            this.Salir_button.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Salir_button.UseVisualStyleBackColor = true;
            this.Salir_button.Click += new System.EventHandler(this.Salir_button_Click);
            // 
            // Descuento_button
            // 
            this.Descuento_button.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F);
            this.Descuento_button.Image = global::FormMenu.Properties.Resources.calcular;
            this.Descuento_button.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Descuento_button.Location = new System.Drawing.Point(36, 250);
            this.Descuento_button.Name = "Descuento_button";
            this.Descuento_button.Size = new System.Drawing.Size(246, 67);
            this.Descuento_button.TabIndex = 6;
            this.Descuento_button.Text = "CALCULAR DESCUENTO";
            this.Descuento_button.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Descuento_button.UseVisualStyleBackColor = true;
            this.Descuento_button.Click += new System.EventHandler(this.Descuento_button_Click);
            // 
            // Regreso_button
            // 
            this.Regreso_button.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F);
            this.Regreso_button.Image = global::FormMenu.Properties.Resources.reiniciar__1_;
            this.Regreso_button.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Regreso_button.Location = new System.Drawing.Point(36, 382);
            this.Regreso_button.Name = "Regreso_button";
            this.Regreso_button.Size = new System.Drawing.Size(194, 53);
            this.Regreso_button.TabIndex = 16;
            this.Regreso_button.Text = "MENU PRINCIPAL";
            this.Regreso_button.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Regreso_button.UseVisualStyleBackColor = true;
            this.Regreso_button.Click += new System.EventHandler(this.Regreso_button_Click);
            // 
            // EJERICICIO2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Peru;
            this.ClientSize = new System.Drawing.Size(684, 470);
            this.Controls.Add(this.Regreso_button);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Prodcutos_dataGridView);
            this.Controls.Add(this.Agregar_button);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Salir_button);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Descuento_button);
            this.Controls.Add(this.Cantidad_Pro_textBox);
            this.Controls.Add(this.Precio_Pro_textBox);
            this.Controls.Add(this.Producto_textBox);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EJERICICIO2";
            this.Text = "EJERICICIO2";
            this.Load += new System.EventHandler(this.EJERICICIO2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Prodcutos_dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox Producto_textBox;
        private System.Windows.Forms.TextBox Precio_Pro_textBox;
        private System.Windows.Forms.TextBox Cantidad_Pro_textBox;
        private System.Windows.Forms.Button Descuento_button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Salir_button;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button Agregar_button;
        private System.Windows.Forms.DataGridView Prodcutos_dataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductoColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn CANTIDADColumn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Regreso_button;
    }
}