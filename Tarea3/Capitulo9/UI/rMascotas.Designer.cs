namespace Tarea3.Capitulo9.UI
{
    partial class rMascotas
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.Limpiarbutton = new System.Windows.Forms.Button();
            this.Guardarbutton = new System.Windows.Forms.Button();
            this.NombreOTextBox = new System.Windows.Forms.TextBox();
            this.GeneroOTextBox = new System.Windows.Forms.TextBox();
            this.NombreMTextBox = new System.Windows.Forms.TextBox();
            this.GeneroTextBox = new System.Windows.Forms.TextBox();
            this.EdadONumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.EdadMNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.MyErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.EdadONumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EdadMNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(73, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Infromacion Owner";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Edad";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "genero";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(73, 189);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(138, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Informacion Mascota";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 226);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "NombreMascota";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(19, 258);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 17);
            this.label7.TabIndex = 6;
            this.label7.Text = "EdadMascota";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(19, 299);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(101, 17);
            this.label8.TabIndex = 7;
            this.label8.Text = "GenroMascota";
            // 
            // Limpiarbutton
            // 
            this.Limpiarbutton.Location = new System.Drawing.Point(22, 363);
            this.Limpiarbutton.Name = "Limpiarbutton";
            this.Limpiarbutton.Size = new System.Drawing.Size(90, 38);
            this.Limpiarbutton.TabIndex = 8;
            this.Limpiarbutton.Text = "Limpiar";
            this.Limpiarbutton.UseVisualStyleBackColor = true;
            this.Limpiarbutton.Click += new System.EventHandler(this.Limpiarbutton_Click);
            // 
            // Guardarbutton
            // 
            this.Guardarbutton.Location = new System.Drawing.Point(140, 363);
            this.Guardarbutton.Name = "Guardarbutton";
            this.Guardarbutton.Size = new System.Drawing.Size(93, 38);
            this.Guardarbutton.TabIndex = 9;
            this.Guardarbutton.Text = "Guardar";
            this.Guardarbutton.UseVisualStyleBackColor = true;
            this.Guardarbutton.Click += new System.EventHandler(this.Guardarbutton_Click);
            // 
            // NombreOTextBox
            // 
            this.NombreOTextBox.Location = new System.Drawing.Point(131, 74);
            this.NombreOTextBox.Name = "NombreOTextBox";
            this.NombreOTextBox.Size = new System.Drawing.Size(100, 22);
            this.NombreOTextBox.TabIndex = 11;
            // 
            // GeneroOTextBox
            // 
            this.GeneroOTextBox.Location = new System.Drawing.Point(131, 151);
            this.GeneroOTextBox.Name = "GeneroOTextBox";
            this.GeneroOTextBox.Size = new System.Drawing.Size(100, 22);
            this.GeneroOTextBox.TabIndex = 13;
            // 
            // NombreMTextBox
            // 
            this.NombreMTextBox.Location = new System.Drawing.Point(133, 223);
            this.NombreMTextBox.Name = "NombreMTextBox";
            this.NombreMTextBox.Size = new System.Drawing.Size(100, 22);
            this.NombreMTextBox.TabIndex = 14;
            // 
            // GeneroTextBox
            // 
            this.GeneroTextBox.Location = new System.Drawing.Point(133, 299);
            this.GeneroTextBox.Name = "GeneroTextBox";
            this.GeneroTextBox.Size = new System.Drawing.Size(100, 22);
            this.GeneroTextBox.TabIndex = 16;
            // 
            // EdadONumericUpDown
            // 
            this.EdadONumericUpDown.Location = new System.Drawing.Point(131, 107);
            this.EdadONumericUpDown.Name = "EdadONumericUpDown";
            this.EdadONumericUpDown.Size = new System.Drawing.Size(102, 22);
            this.EdadONumericUpDown.TabIndex = 17;
            // 
            // EdadMNumericUpDown
            // 
            this.EdadMNumericUpDown.Location = new System.Drawing.Point(130, 258);
            this.EdadMNumericUpDown.Name = "EdadMNumericUpDown";
            this.EdadMNumericUpDown.Size = new System.Drawing.Size(103, 22);
            this.EdadMNumericUpDown.TabIndex = 18;
            // 
            // MyErrorProvider
            // 
            this.MyErrorProvider.ContainerControl = this;
            // 
            // rMascotas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(262, 450);
            this.Controls.Add(this.EdadMNumericUpDown);
            this.Controls.Add(this.EdadONumericUpDown);
            this.Controls.Add(this.GeneroTextBox);
            this.Controls.Add(this.NombreMTextBox);
            this.Controls.Add(this.GeneroOTextBox);
            this.Controls.Add(this.NombreOTextBox);
            this.Controls.Add(this.Guardarbutton);
            this.Controls.Add(this.Limpiarbutton);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "rMascotas";
            this.Text = "rMascotas";
            ((System.ComponentModel.ISupportInitialize)(this.EdadONumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EdadMNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyErrorProvider)).EndInit();
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
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button Limpiarbutton;
        private System.Windows.Forms.Button Guardarbutton;
        private System.Windows.Forms.TextBox NombreOTextBox;
        private System.Windows.Forms.TextBox GeneroOTextBox;
        private System.Windows.Forms.TextBox NombreMTextBox;
        private System.Windows.Forms.TextBox GeneroTextBox;
        private System.Windows.Forms.NumericUpDown EdadONumericUpDown;
        private System.Windows.Forms.NumericUpDown EdadMNumericUpDown;
        private System.Windows.Forms.ErrorProvider MyErrorProvider;
    }
}