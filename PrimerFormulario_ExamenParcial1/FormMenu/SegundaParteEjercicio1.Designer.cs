﻿namespace FormMenu
{
    partial class SegundaParteEjercicio1
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
            this.Salir_button = new System.Windows.Forms.Button();
            this.Deposito_textBox = new System.Windows.Forms.TextBox();
            this.Informe_listBox = new System.Windows.Forms.ListBox();
            this.Ingreso_Deposito_button = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // Salir_button
            // 
            this.Salir_button.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Salir_button.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Salir_button.Image = global::FormMenu.Properties.Resources.boton_x;
            this.Salir_button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Salir_button.Location = new System.Drawing.Point(436, 126);
            this.Salir_button.Name = "Salir_button";
            this.Salir_button.Size = new System.Drawing.Size(96, 40);
            this.Salir_button.TabIndex = 11;
            this.Salir_button.Text = "Cancelar";
            this.Salir_button.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Salir_button.UseVisualStyleBackColor = true;
            // 
            // Deposito_textBox
            // 
            this.Deposito_textBox.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Deposito_textBox.Location = new System.Drawing.Point(180, 80);
            this.Deposito_textBox.Name = "Deposito_textBox";
            this.Deposito_textBox.Size = new System.Drawing.Size(191, 25);
            this.Deposito_textBox.TabIndex = 10;
            // 
            // Informe_listBox
            // 
            this.Informe_listBox.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Informe_listBox.FormattingEnabled = true;
            this.Informe_listBox.ItemHeight = 16;
            this.Informe_listBox.Items.AddRange(new object[] {
            "La informacion aparecera aqui..."});
            this.Informe_listBox.Location = new System.Drawing.Point(12, 126);
            this.Informe_listBox.Name = "Informe_listBox";
            this.Informe_listBox.Size = new System.Drawing.Size(407, 148);
            this.Informe_listBox.TabIndex = 9;
            // 
            // Ingreso_Deposito_button
            // 
            this.Ingreso_Deposito_button.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ingreso_Deposito_button.Image = global::FormMenu.Properties.Resources.cheque;
            this.Ingreso_Deposito_button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Ingreso_Deposito_button.Location = new System.Drawing.Point(436, 80);
            this.Ingreso_Deposito_button.Name = "Ingreso_Deposito_button";
            this.Ingreso_Deposito_button.Size = new System.Drawing.Size(96, 40);
            this.Ingreso_Deposito_button.TabIndex = 8;
            this.Ingreso_Deposito_button.Text = "Calcular";
            this.Ingreso_Deposito_button.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Ingreso_Deposito_button.UseVisualStyleBackColor = true;
            this.Ingreso_Deposito_button.Click += new System.EventHandler(this.Ingreso_Deposito_button_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Ingrese su deposito:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(112, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(374, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "BIENVENIDO A NUESTRO APARTADO DE DEPOSITO";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // SegundaParteEjercicio1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RosyBrown;
            this.ClientSize = new System.Drawing.Size(569, 299);
            this.Controls.Add(this.Salir_button);
            this.Controls.Add(this.Deposito_textBox);
            this.Controls.Add(this.Informe_listBox);
            this.Controls.Add(this.Ingreso_Deposito_button);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "SegundaParteEjercicio1";
            this.Text = "SegundaParteEjercicio1";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Salir_button;
        private System.Windows.Forms.TextBox Deposito_textBox;
        private System.Windows.Forms.ListBox Informe_listBox;
        private System.Windows.Forms.Button Ingreso_Deposito_button;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}