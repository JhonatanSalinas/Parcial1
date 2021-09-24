
namespace Parcial1
{
    partial class Menu
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
            this.button7 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button8 = new System.Windows.Forms.Button();
            this.Resultado = new System.Windows.Forms.TextBox();
            this.Numero2 = new System.Windows.Forms.TextBox();
            this.Numero1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.button9 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(100, 362);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 23);
            this.button7.TabIndex = 44;
            this.button7.Text = "Limpiar";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(358, 101);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 20);
            this.label5.TabIndex = 43;
            this.label5.Text = "Numero 2";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(166, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 20);
            this.label4.TabIndex = 42;
            this.label4.Text = "Numero 1";
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(288, 190);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(75, 23);
            this.button8.TabIndex = 41;
            this.button8.Text = "Calcular ";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // Resultado
            // 
            this.Resultado.Location = new System.Drawing.Point(272, 234);
            this.Resultado.Name = "Resultado";
            this.Resultado.Size = new System.Drawing.Size(100, 20);
            this.Resultado.TabIndex = 40;
            // 
            // Numero2
            // 
            this.Numero2.Location = new System.Drawing.Point(362, 137);
            this.Numero2.Name = "Numero2";
            this.Numero2.Size = new System.Drawing.Size(100, 20);
            this.Numero2.TabIndex = 39;
            // 
            // Numero1
            // 
            this.Numero1.Location = new System.Drawing.Point(170, 137);
            this.Numero1.Name = "Numero1";
            this.Numero1.Size = new System.Drawing.Size(100, 20);
            this.Numero1.TabIndex = 38;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(358, 57);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(319, 20);
            this.label6.TabIndex = 37;
            this.label6.Text = "deberá indicar si el primero o el segundo es el menor.";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(34, 57);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(329, 20);
            this.label7.TabIndex = 36;
            this.label7.Text = "El usuario introducirá dos números enteros el programa";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Algerian", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(287, 19);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(122, 26);
            this.label8.TabIndex = 35;
            this.label8.Text = "Modulo 1";
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(549, 362);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(75, 23);
            this.button9.TabIndex = 34;
            this.button9.Text = "Atras";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(709, 445);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.Resultado);
            this.Controls.Add(this.Numero2);
            this.Controls.Add(this.Numero1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.button9);
            this.Name = "Menu";
            this.Text = "Modulo I";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.TextBox Resultado;
        private System.Windows.Forms.TextBox Numero2;
        private System.Windows.Forms.TextBox Numero1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button9;
    }
}