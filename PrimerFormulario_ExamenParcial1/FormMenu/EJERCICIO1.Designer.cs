namespace FormMenu
{
    partial class EJERCICIO1
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
            this.Nombre_textBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Contra_textBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Mostrar_button = new System.Windows.Forms.Button();
            this.Cancelar_button = new System.Windows.Forms.Button();
            this.Ingresar_button = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // Nombre_textBox
            // 
            this.Nombre_textBox.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F);
            this.Nombre_textBox.Location = new System.Drawing.Point(103, 108);
            this.Nombre_textBox.Name = "Nombre_textBox";
            this.Nombre_textBox.Size = new System.Drawing.Size(243, 25);
            this.Nombre_textBox.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F);
            this.label3.Location = new System.Drawing.Point(30, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 16);
            this.label3.TabIndex = 12;
            this.label3.Text = "Nombre:";
            // 
            // Contra_textBox
            // 
            this.Contra_textBox.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F);
            this.Contra_textBox.Location = new System.Drawing.Point(103, 138);
            this.Contra_textBox.Name = "Contra_textBox";
            this.Contra_textBox.PasswordChar = '*';
            this.Contra_textBox.Size = new System.Drawing.Size(243, 25);
            this.Contra_textBox.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F);
            this.label2.Location = new System.Drawing.Point(30, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 16);
            this.label2.TabIndex = 10;
            this.label2.Text = "Contraseña:";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mongolian Baiti", 15.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label1.Location = new System.Drawing.Point(137, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 23);
            this.label1.TabIndex = 9;
            this.label1.Text = "BANCOS C.A";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::FormMenu.Properties.Resources.banco__2_;
            this.pictureBox1.Location = new System.Drawing.Point(292, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(68, 58);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // Mostrar_button
            // 
            this.Mostrar_button.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Mostrar_button.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F);
            this.Mostrar_button.Image = global::FormMenu.Properties.Resources.ver;
            this.Mostrar_button.Location = new System.Drawing.Point(352, 136);
            this.Mostrar_button.Name = "Mostrar_button";
            this.Mostrar_button.Size = new System.Drawing.Size(41, 27);
            this.Mostrar_button.TabIndex = 16;
            this.Mostrar_button.UseVisualStyleBackColor = true;
            this.Mostrar_button.Click += new System.EventHandler(this.Mostrar_button_Click_1);
            // 
            // Cancelar_button
            // 
            this.Cancelar_button.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Cancelar_button.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F);
            this.Cancelar_button.Image = global::FormMenu.Properties.Resources.boton_x;
            this.Cancelar_button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Cancelar_button.Location = new System.Drawing.Point(220, 197);
            this.Cancelar_button.Name = "Cancelar_button";
            this.Cancelar_button.Size = new System.Drawing.Size(97, 35);
            this.Cancelar_button.TabIndex = 15;
            this.Cancelar_button.Text = "Cancelar";
            this.Cancelar_button.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Cancelar_button.UseVisualStyleBackColor = true;
            // 
            // Ingresar_button
            // 
            this.Ingresar_button.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F);
            this.Ingresar_button.Image = global::FormMenu.Properties.Resources.cheque;
            this.Ingresar_button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Ingresar_button.Location = new System.Drawing.Point(103, 197);
            this.Ingresar_button.Name = "Ingresar_button";
            this.Ingresar_button.Size = new System.Drawing.Size(97, 35);
            this.Ingresar_button.TabIndex = 14;
            this.Ingresar_button.Text = "Ingresar";
            this.Ingresar_button.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Ingresar_button.UseVisualStyleBackColor = true;
            this.Ingresar_button.Click += new System.EventHandler(this.Ingresar_button_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // EJERCICIO1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 247);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Mostrar_button);
            this.Controls.Add(this.Cancelar_button);
            this.Controls.Add(this.Ingresar_button);
            this.Controls.Add(this.Nombre_textBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Contra_textBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "EJERCICIO1";
            this.Text = "EJERCICIO1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Mostrar_button;
        private System.Windows.Forms.Button Cancelar_button;
        private System.Windows.Forms.Button Ingresar_button;
        private System.Windows.Forms.TextBox Nombre_textBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Contra_textBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}