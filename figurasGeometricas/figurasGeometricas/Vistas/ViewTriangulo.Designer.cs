namespace figurasGeometricas.Vistas
{
    partial class ViewTriangulo
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
            this.lblCalculoTriangulo = new System.Windows.Forms.Label();
            this.lblIngreseDatos = new System.Windows.Forms.Label();
            this.lblLado1 = new System.Windows.Forms.Label();
            this.txtLado1 = new System.Windows.Forms.TextBox();
            this.lblLado2 = new System.Windows.Forms.Label();
            this.txtLado2 = new System.Windows.Forms.TextBox();
            this.lblLado3 = new System.Windows.Forms.Label();
            this.txtLado3 = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.lblArea = new System.Windows.Forms.Label();
            this.lblResulArea = new System.Windows.Forms.Label();
            this.lblPerimetro = new System.Windows.Forms.Label();
            this.lblResulPerimetro = new System.Windows.Forms.Label();
            this.lblAltura = new System.Windows.Forms.Label();
            this.lblResulAltura = new System.Windows.Forms.Label();
            this.lblTipoTriangulo = new System.Windows.Forms.Label();
            this.lblResulTipo = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCalculoTriangulo
            // 
            this.lblCalculoTriangulo.AutoSize = true;
            this.lblCalculoTriangulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.lblCalculoTriangulo.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblCalculoTriangulo.Location = new System.Drawing.Point(255, 25);
            this.lblCalculoTriangulo.Name = "lblCalculoTriangulo";
            this.lblCalculoTriangulo.Size = new System.Drawing.Size(271, 25);
            this.lblCalculoTriangulo.TabIndex = 0;
            this.lblCalculoTriangulo.Text = "Calculo de un TRIANGULO";
            // 
            // lblIngreseDatos
            // 
            this.lblIngreseDatos.AutoSize = true;
            this.lblIngreseDatos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.lblIngreseDatos.Location = new System.Drawing.Point(155, 65);
            this.lblIngreseDatos.Name = "lblIngreseDatos";
            this.lblIngreseDatos.Size = new System.Drawing.Size(119, 20);
            this.lblIngreseDatos.TabIndex = 1;
            this.lblIngreseDatos.Text = "Ingrese Datos:";
            // 
            // lblLado1
            // 
            this.lblLado1.AutoSize = true;
            this.lblLado1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.lblLado1.Location = new System.Drawing.Point(77, 13);
            this.lblLado1.Name = "lblLado1";
            this.lblLado1.Size = new System.Drawing.Size(60, 20);
            this.lblLado1.TabIndex = 2;
            this.lblLado1.Text = "Lado1:";
            // 
            // txtLado1
            // 
            this.txtLado1.Location = new System.Drawing.Point(149, 13);
            this.txtLado1.Name = "txtLado1";
            this.txtLado1.Size = new System.Drawing.Size(100, 20);
            this.txtLado1.TabIndex = 3;
            // 
            // lblLado2
            // 
            this.lblLado2.AutoSize = true;
            this.lblLado2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.lblLado2.Location = new System.Drawing.Point(77, 53);
            this.lblLado2.Name = "lblLado2";
            this.lblLado2.Size = new System.Drawing.Size(60, 20);
            this.lblLado2.TabIndex = 4;
            this.lblLado2.Text = "Lado2:";
            // 
            // txtLado2
            // 
            this.txtLado2.Location = new System.Drawing.Point(149, 53);
            this.txtLado2.Name = "txtLado2";
            this.txtLado2.Size = new System.Drawing.Size(100, 20);
            this.txtLado2.TabIndex = 5;
            // 
            // lblLado3
            // 
            this.lblLado3.AutoSize = true;
            this.lblLado3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.lblLado3.Location = new System.Drawing.Point(80, 92);
            this.lblLado3.Name = "lblLado3";
            this.lblLado3.Size = new System.Drawing.Size(60, 20);
            this.lblLado3.TabIndex = 6;
            this.lblLado3.Text = "Lado3:";
            // 
            // txtLado3
            // 
            this.txtLado3.Location = new System.Drawing.Point(149, 92);
            this.txtLado3.Name = "txtLado3";
            this.txtLado3.Size = new System.Drawing.Size(100, 20);
            this.txtLado3.TabIndex = 7;
            // 
            // btnCalcular
            // 
            this.btnCalcular.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.btnCalcular.Location = new System.Drawing.Point(110, 134);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(100, 39);
            this.btnCalcular.TabIndex = 8;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = false;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // lblArea
            // 
            this.lblArea.AutoSize = true;
            this.lblArea.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.lblArea.Location = new System.Drawing.Point(60, 374);
            this.lblArea.Name = "lblArea";
            this.lblArea.Size = new System.Drawing.Size(49, 20);
            this.lblArea.TabIndex = 9;
            this.lblArea.Text = "Area:";
            // 
            // lblResulArea
            // 
            this.lblResulArea.AutoSize = true;
            this.lblResulArea.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.lblResulArea.Location = new System.Drawing.Point(113, 374);
            this.lblResulArea.Name = "lblResulArea";
            this.lblResulArea.Size = new System.Drawing.Size(0, 20);
            this.lblResulArea.TabIndex = 10;
            // 
            // lblPerimetro
            // 
            this.lblPerimetro.AutoSize = true;
            this.lblPerimetro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.lblPerimetro.Location = new System.Drawing.Point(158, 374);
            this.lblPerimetro.Name = "lblPerimetro";
            this.lblPerimetro.Size = new System.Drawing.Size(87, 20);
            this.lblPerimetro.TabIndex = 11;
            this.lblPerimetro.Text = "Perimetro:";
            // 
            // lblResulPerimetro
            // 
            this.lblResulPerimetro.AutoSize = true;
            this.lblResulPerimetro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.lblResulPerimetro.Location = new System.Drawing.Point(254, 374);
            this.lblResulPerimetro.Name = "lblResulPerimetro";
            this.lblResulPerimetro.Size = new System.Drawing.Size(0, 20);
            this.lblResulPerimetro.TabIndex = 12;
            // 
            // lblAltura
            // 
            this.lblAltura.AutoSize = true;
            this.lblAltura.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.lblAltura.Location = new System.Drawing.Point(314, 374);
            this.lblAltura.Name = "lblAltura";
            this.lblAltura.Size = new System.Drawing.Size(58, 20);
            this.lblAltura.TabIndex = 13;
            this.lblAltura.Text = "Altura:";
            // 
            // lblResulAltura
            // 
            this.lblResulAltura.AutoSize = true;
            this.lblResulAltura.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.lblResulAltura.Location = new System.Drawing.Point(376, 374);
            this.lblResulAltura.Name = "lblResulAltura";
            this.lblResulAltura.Size = new System.Drawing.Size(0, 20);
            this.lblResulAltura.TabIndex = 14;
            // 
            // lblTipoTriangulo
            // 
            this.lblTipoTriangulo.AutoSize = true;
            this.lblTipoTriangulo.BackColor = System.Drawing.SystemColors.Control;
            this.lblTipoTriangulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.lblTipoTriangulo.Location = new System.Drawing.Point(60, 7);
            this.lblTipoTriangulo.Name = "lblTipoTriangulo";
            this.lblTipoTriangulo.Size = new System.Drawing.Size(143, 20);
            this.lblTipoTriangulo.TabIndex = 15;
            this.lblTipoTriangulo.Text = "Tipo de Triangulo:";
            // 
            // lblResulTipo
            // 
            this.lblResulTipo.AutoSize = true;
            this.lblResulTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.lblResulTipo.Location = new System.Drawing.Point(209, 7);
            this.lblResulTipo.Name = "lblResulTipo";
            this.lblResulTipo.Size = new System.Drawing.Size(0, 20);
            this.lblResulTipo.TabIndex = 16;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::figurasGeometricas.Properties.Resources.Triangulo;
            this.pictureBox1.Location = new System.Drawing.Point(437, 68);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(245, 302);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel1.Controls.Add(this.btnCalcular);
            this.panel1.Controls.Add(this.txtLado3);
            this.panel1.Controls.Add(this.lblLado3);
            this.panel1.Controls.Add(this.txtLado2);
            this.panel1.Controls.Add(this.lblLado2);
            this.panel1.Controls.Add(this.txtLado1);
            this.panel1.Controls.Add(this.lblLado1);
            this.panel1.Location = new System.Drawing.Point(49, 102);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(360, 201);
            this.panel1.TabIndex = 18;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel2.Controls.Add(this.lblResulTipo);
            this.panel2.Controls.Add(this.lblTipoTriangulo);
            this.panel2.Location = new System.Drawing.Point(45, 336);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(363, 67);
            this.panel2.TabIndex = 19;
            // 
            // ViewTriangulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblResulAltura);
            this.Controls.Add(this.lblAltura);
            this.Controls.Add(this.lblResulPerimetro);
            this.Controls.Add(this.lblPerimetro);
            this.Controls.Add(this.lblResulArea);
            this.Controls.Add(this.lblArea);
            this.Controls.Add(this.lblIngreseDatos);
            this.Controls.Add(this.lblCalculoTriangulo);
            this.Controls.Add(this.panel2);
            this.Name = "ViewTriangulo";
            this.Text = "ViewTriangulo";
            this.Load += new System.EventHandler(this.ViewTriangulo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCalculoTriangulo;
        private System.Windows.Forms.Label lblIngreseDatos;
        private System.Windows.Forms.Label lblLado1;
        private System.Windows.Forms.TextBox txtLado1;
        private System.Windows.Forms.Label lblLado2;
        private System.Windows.Forms.TextBox txtLado2;
        private System.Windows.Forms.Label lblLado3;
        private System.Windows.Forms.TextBox txtLado3;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label lblArea;
        private System.Windows.Forms.Label lblResulArea;
        private System.Windows.Forms.Label lblPerimetro;
        private System.Windows.Forms.Label lblResulPerimetro;
        private System.Windows.Forms.Label lblAltura;
        private System.Windows.Forms.Label lblResulAltura;
        private System.Windows.Forms.Label lblTipoTriangulo;
        private System.Windows.Forms.Label lblResulTipo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}