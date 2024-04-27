namespace figurasGeometricas.Vistas
{
    partial class ViewCirculo
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
            this.lblCalculoCirculo = new System.Windows.Forms.Label();
            this.lblRadio = new System.Windows.Forms.Label();
            this.lblIngreseDatos = new System.Windows.Forms.Label();
            this.txtRadio = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblResulArea = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.lblPerimetro = new System.Windows.Forms.Label();
            this.lblResulPerim = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblTitResulta = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCalculoCirculo
            // 
            this.lblCalculoCirculo.AutoSize = true;
            this.lblCalculoCirculo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.lblCalculoCirculo.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblCalculoCirculo.Location = new System.Drawing.Point(221, 29);
            this.lblCalculoCirculo.Name = "lblCalculoCirculo";
            this.lblCalculoCirculo.Size = new System.Drawing.Size(243, 25);
            this.lblCalculoCirculo.TabIndex = 0;
            this.lblCalculoCirculo.Text = "Calculo de un CIRCULO";
            // 
            // lblRadio
            // 
            this.lblRadio.AutoSize = true;
            this.lblRadio.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.lblRadio.Location = new System.Drawing.Point(58, 34);
            this.lblRadio.Name = "lblRadio";
            this.lblRadio.Size = new System.Drawing.Size(51, 18);
            this.lblRadio.TabIndex = 1;
            this.lblRadio.Text = "Radio:";
            // 
            // lblIngreseDatos
            // 
            this.lblIngreseDatos.AutoSize = true;
            this.lblIngreseDatos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.lblIngreseDatos.Location = new System.Drawing.Point(167, 75);
            this.lblIngreseDatos.Name = "lblIngreseDatos";
            this.lblIngreseDatos.Size = new System.Drawing.Size(110, 20);
            this.lblIngreseDatos.TabIndex = 2;
            this.lblIngreseDatos.Text = "Ingrese datos";
            // 
            // txtRadio
            // 
            this.txtRadio.Location = new System.Drawing.Point(124, 32);
            this.txtRadio.Name = "txtRadio";
            this.txtRadio.Size = new System.Drawing.Size(100, 20);
            this.txtRadio.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label1.Location = new System.Drawing.Point(6, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Area:";
            // 
            // lblResulArea
            // 
            this.lblResulArea.AutoSize = true;
            this.lblResulArea.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.lblResulArea.Location = new System.Drawing.Point(61, 17);
            this.lblResulArea.Name = "lblResulArea";
            this.lblResulArea.Size = new System.Drawing.Size(0, 20);
            this.lblResulArea.TabIndex = 5;
            // 
            // btnCalcular
            // 
            this.btnCalcular.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.btnCalcular.Location = new System.Drawing.Point(86, 84);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(122, 47);
            this.btnCalcular.TabIndex = 6;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = false;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // lblPerimetro
            // 
            this.lblPerimetro.AutoSize = true;
            this.lblPerimetro.BackColor = System.Drawing.SystemColors.Control;
            this.lblPerimetro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.lblPerimetro.Location = new System.Drawing.Point(175, 17);
            this.lblPerimetro.Name = "lblPerimetro";
            this.lblPerimetro.Size = new System.Drawing.Size(87, 20);
            this.lblPerimetro.TabIndex = 8;
            this.lblPerimetro.Text = "Perimetro:";
            // 
            // lblResulPerim
            // 
            this.lblResulPerim.AutoSize = true;
            this.lblResulPerim.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.lblResulPerim.Location = new System.Drawing.Point(268, 17);
            this.lblResulPerim.Name = "lblResulPerim";
            this.lblResulPerim.Size = new System.Drawing.Size(0, 20);
            this.lblResulPerim.TabIndex = 9;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::figurasGeometricas.Properties.Resources.Circulo1;
            this.pictureBox1.Location = new System.Drawing.Point(454, 76);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(207, 271);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel1.Controls.Add(this.btnCalcular);
            this.panel1.Controls.Add(this.txtRadio);
            this.panel1.Controls.Add(this.lblRadio);
            this.panel1.Location = new System.Drawing.Point(69, 98);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(307, 157);
            this.panel1.TabIndex = 11;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel2.Controls.Add(this.lblResulPerim);
            this.panel2.Controls.Add(this.lblPerimetro);
            this.panel2.Controls.Add(this.lblResulArea);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(69, 300);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(306, 46);
            this.panel2.TabIndex = 12;
            // 
            // lblTitResulta
            // 
            this.lblTitResulta.AutoSize = true;
            this.lblTitResulta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.lblTitResulta.Location = new System.Drawing.Point(167, 277);
            this.lblTitResulta.Name = "lblTitResulta";
            this.lblTitResulta.Size = new System.Drawing.Size(93, 20);
            this.lblTitResulta.TabIndex = 13;
            this.lblTitResulta.Text = "Resultados";
            // 
            // ViewCirculo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblTitResulta);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblIngreseDatos);
            this.Controls.Add(this.lblCalculoCirculo);
            this.Name = "ViewCirculo";
            this.Text = "ViewCirculo";
            this.Load += new System.EventHandler(this.ViewCirculo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCalculoCirculo;
        private System.Windows.Forms.Label lblRadio;
        private System.Windows.Forms.Label lblIngreseDatos;
        private System.Windows.Forms.TextBox txtRadio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblResulArea;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label lblPerimetro;
        private System.Windows.Forms.Label lblResulPerim;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblTitResulta;
    }
}