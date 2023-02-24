namespace FormMenu
{
    partial class EJERCICIO3
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Datos_textBox = new System.Windows.Forms.TextBox();
            this.Numero_textBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Salir_button = new System.Windows.Forms.Button();
            this.Limpiar_button = new System.Windows.Forms.Button();
            this.Ingresar_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F);
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(110, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 16);
            this.label3.TabIndex = 16;
            this.label3.Text = "Datos a mostrar:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F);
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(110, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 16);
            this.label4.TabIndex = 15;
            this.label4.Text = "Numero Generado:";
            // 
            // Datos_textBox
            // 
            this.Datos_textBox.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F);
            this.Datos_textBox.Location = new System.Drawing.Point(258, 84);
            this.Datos_textBox.Name = "Datos_textBox";
            this.Datos_textBox.Size = new System.Drawing.Size(174, 25);
            this.Datos_textBox.TabIndex = 14;
            // 
            // Numero_textBox
            // 
            this.Numero_textBox.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F);
            this.Numero_textBox.Location = new System.Drawing.Point(258, 36);
            this.Numero_textBox.Name = "Numero_textBox";
            this.Numero_textBox.Size = new System.Drawing.Size(174, 25);
            this.Numero_textBox.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(35, 216);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(241, 48);
            this.label2.TabIndex = 11;
            this.label2.Text = "Cacular: Inicia el procedimiento.\r\nIniciar de Nuevo: Limpia los textbox.\r\nSalir: " +
    "Sale del programa";
            // 
            // Salir_button
            // 
            this.Salir_button.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F);
            this.Salir_button.Image = global::FormMenu.Properties.Resources.boton_x;
            this.Salir_button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Salir_button.Location = new System.Drawing.Point(446, 124);
            this.Salir_button.Name = "Salir_button";
            this.Salir_button.Size = new System.Drawing.Size(127, 77);
            this.Salir_button.TabIndex = 18;
            this.Salir_button.Text = "CANCELAR";
            this.Salir_button.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Salir_button.UseVisualStyleBackColor = true;
            this.Salir_button.Click += new System.EventHandler(this.Salir_button_Click_1);
            // 
            // Limpiar_button
            // 
            this.Limpiar_button.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F);
            this.Limpiar_button.Image = global::FormMenu.Properties.Resources.reiniciar;
            this.Limpiar_button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Limpiar_button.Location = new System.Drawing.Point(219, 124);
            this.Limpiar_button.Name = "Limpiar_button";
            this.Limpiar_button.Size = new System.Drawing.Size(190, 77);
            this.Limpiar_button.TabIndex = 17;
            this.Limpiar_button.Text = "Iniciar De  Nuevo";
            this.Limpiar_button.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Limpiar_button.UseVisualStyleBackColor = true;
            this.Limpiar_button.Click += new System.EventHandler(this.Limpiar_button_Click);
            // 
            // Ingresar_button
            // 
            this.Ingresar_button.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F);
            this.Ingresar_button.Image = global::FormMenu.Properties.Resources.matematicas;
            this.Ingresar_button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Ingresar_button.Location = new System.Drawing.Point(38, 124);
            this.Ingresar_button.Name = "Ingresar_button";
            this.Ingresar_button.Size = new System.Drawing.Size(157, 77);
            this.Ingresar_button.TabIndex = 12;
            this.Ingresar_button.Text = "CALCULAR";
            this.Ingresar_button.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Ingresar_button.UseVisualStyleBackColor = true;
            this.Ingresar_button.Click += new System.EventHandler(this.Ingresar_button_Click);
            // 
            // EJERCICIO3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGreen;
            this.ClientSize = new System.Drawing.Size(608, 272);
            this.Controls.Add(this.Salir_button);
            this.Controls.Add(this.Limpiar_button);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Datos_textBox);
            this.Controls.Add(this.Numero_textBox);
            this.Controls.Add(this.Ingresar_button);
            this.Controls.Add(this.label2);
            this.Name = "EJERCICIO3";
            this.Text = "EJERCICIO3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Salir_button;
        private System.Windows.Forms.Button Limpiar_button;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Datos_textBox;
        private System.Windows.Forms.TextBox Numero_textBox;
        private System.Windows.Forms.Button Ingresar_button;
        private System.Windows.Forms.Label label2;
    }
}