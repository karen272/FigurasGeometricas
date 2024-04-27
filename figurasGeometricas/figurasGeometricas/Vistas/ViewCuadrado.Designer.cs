namespace figurasGeometricas.Vistas
{
    partial class ViewCuadrado
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
            this.lblCalculoCuadrado = new System.Windows.Forms.Label();
            this.lblIngreseDatos = new System.Windows.Forms.Label();
            this.lblLado = new System.Windows.Forms.Label();
            this.txtLado = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblArea = new System.Windows.Forms.Label();
            this.lblResulAreaCuadrado = new System.Windows.Forms.Label();
            this.lblPerimetro = new System.Windows.Forms.Label();
            this.lblResulPerimCuadrado = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblTituResult = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCalculoCuadrado
            // 
            this.lblCalculoCuadrado.AutoSize = true;
            this.lblCalculoCuadrado.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.lblCalculoCuadrado.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblCalculoCuadrado.Location = new System.Drawing.Point(232, 20);
            this.lblCalculoCuadrado.Name = "lblCalculoCuadrado";
            this.lblCalculoCuadrado.Size = new System.Drawing.Size(269, 25);
            this.lblCalculoCuadrado.TabIndex = 0;
            this.lblCalculoCuadrado.Text = "Calculo de un CUADRADO";
            // 
            // lblIngreseDatos
            // 
            this.lblIngreseDatos.AutoSize = true;
            this.lblIngreseDatos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.lblIngreseDatos.Location = new System.Drawing.Point(137, 74);
            this.lblIngreseDatos.Name = "lblIngreseDatos";
            this.lblIngreseDatos.Size = new System.Drawing.Size(119, 20);
            this.lblIngreseDatos.TabIndex = 1;
            this.lblIngreseDatos.Text = "Ingrese Datos:";
            // 
            // lblLado
            // 
            this.lblLado.AutoSize = true;
            this.lblLado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.lblLado.Location = new System.Drawing.Point(84, 28);
            this.lblLado.Name = "lblLado";
            this.lblLado.Size = new System.Drawing.Size(51, 20);
            this.lblLado.TabIndex = 2;
            this.lblLado.Text = "Lado:";
            // 
            // txtLado
            // 
            this.txtLado.Location = new System.Drawing.Point(157, 28);
            this.txtLado.Name = "txtLado";
            this.txtLado.Size = new System.Drawing.Size(67, 20);
            this.txtLado.TabIndex = 3;
            // 
            // btnCalcular
            // 
            this.btnCalcular.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.btnCalcular.Location = new System.Drawing.Point(88, 74);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(123, 45);
            this.btnCalcular.TabIndex = 8;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = false;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel1.Controls.Add(this.btnCalcular);
            this.panel1.Controls.Add(this.txtLado);
            this.panel1.Controls.Add(this.lblLado);
            this.panel1.Location = new System.Drawing.Point(67, 97);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(307, 142);
            this.panel1.TabIndex = 9;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::figurasGeometricas.Properties.Resources.Cuadrado;
            this.pictureBox1.Location = new System.Drawing.Point(434, 62);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(210, 280);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // lblArea
            // 
            this.lblArea.AutoSize = true;
            this.lblArea.BackColor = System.Drawing.SystemColors.Control;
            this.lblArea.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.lblArea.Location = new System.Drawing.Point(13, 16);
            this.lblArea.Name = "lblArea";
            this.lblArea.Size = new System.Drawing.Size(49, 20);
            this.lblArea.TabIndex = 4;
            this.lblArea.Text = "Area:";
            // 
            // lblResulAreaCuadrado
            // 
            this.lblResulAreaCuadrado.AutoSize = true;
            this.lblResulAreaCuadrado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.lblResulAreaCuadrado.Location = new System.Drawing.Point(68, 16);
            this.lblResulAreaCuadrado.Name = "lblResulAreaCuadrado";
            this.lblResulAreaCuadrado.Size = new System.Drawing.Size(0, 20);
            this.lblResulAreaCuadrado.TabIndex = 5;
            // 
            // lblPerimetro
            // 
            this.lblPerimetro.AutoSize = true;
            this.lblPerimetro.BackColor = System.Drawing.SystemColors.Control;
            this.lblPerimetro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.lblPerimetro.Location = new System.Drawing.Point(142, 16);
            this.lblPerimetro.Name = "lblPerimetro";
            this.lblPerimetro.Size = new System.Drawing.Size(87, 20);
            this.lblPerimetro.TabIndex = 6;
            this.lblPerimetro.Text = "Perímetro:";
            // 
            // lblResulPerimCuadrado
            // 
            this.lblResulPerimCuadrado.AutoSize = true;
            this.lblResulPerimCuadrado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.lblResulPerimCuadrado.Location = new System.Drawing.Point(235, 16);
            this.lblResulPerimCuadrado.Name = "lblResulPerimCuadrado";
            this.lblResulPerimCuadrado.Size = new System.Drawing.Size(0, 20);
            this.lblResulPerimCuadrado.TabIndex = 7;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel2.Controls.Add(this.lblResulPerimCuadrado);
            this.panel2.Controls.Add(this.lblPerimetro);
            this.panel2.Controls.Add(this.lblResulAreaCuadrado);
            this.panel2.Controls.Add(this.lblArea);
            this.panel2.Location = new System.Drawing.Point(64, 279);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(310, 48);
            this.panel2.TabIndex = 11;
            // 
            // lblTituResult
            // 
            this.lblTituResult.AutoSize = true;
            this.lblTituResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.lblTituResult.Location = new System.Drawing.Point(151, 256);
            this.lblTituResult.Name = "lblTituResult";
            this.lblTituResult.Size = new System.Drawing.Size(93, 20);
            this.lblTituResult.TabIndex = 12;
            this.lblTituResult.Text = "Resultados";
            // 
            // ViewCuadrado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblTituResult);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblIngreseDatos);
            this.Controls.Add(this.lblCalculoCuadrado);
            this.Name = "ViewCuadrado";
            this.Text = "ViewCuadrado";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCalculoCuadrado;
        private System.Windows.Forms.Label lblIngreseDatos;
        private System.Windows.Forms.Label lblLado;
        private System.Windows.Forms.TextBox txtLado;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblArea;
        private System.Windows.Forms.Label lblResulAreaCuadrado;
        private System.Windows.Forms.Label lblPerimetro;
        private System.Windows.Forms.Label lblResulPerimCuadrado;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblTituResult;
    }
}