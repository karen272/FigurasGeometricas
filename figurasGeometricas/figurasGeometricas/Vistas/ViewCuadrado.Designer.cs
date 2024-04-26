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
            this.lblArea = new System.Windows.Forms.Label();
            this.lblResulAreaCuadrado = new System.Windows.Forms.Label();
            this.lblPerimetro = new System.Windows.Forms.Label();
            this.lblResulPerimCuadrado = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblCalculoCuadrado
            // 
            this.lblCalculoCuadrado.AutoSize = true;
            this.lblCalculoCuadrado.Location = new System.Drawing.Point(277, 46);
            this.lblCalculoCuadrado.Name = "lblCalculoCuadrado";
            this.lblCalculoCuadrado.Size = new System.Drawing.Size(136, 13);
            this.lblCalculoCuadrado.TabIndex = 0;
            this.lblCalculoCuadrado.Text = "Calculo de un CUADRADO";
            // 
            // lblIngreseDatos
            // 
            this.lblIngreseDatos.AutoSize = true;
            this.lblIngreseDatos.Location = new System.Drawing.Point(304, 91);
            this.lblIngreseDatos.Name = "lblIngreseDatos";
            this.lblIngreseDatos.Size = new System.Drawing.Size(76, 13);
            this.lblIngreseDatos.TabIndex = 1;
            this.lblIngreseDatos.Text = "Ingrese Datos:";
            // 
            // lblLado
            // 
            this.lblLado.AutoSize = true;
            this.lblLado.Location = new System.Drawing.Point(267, 142);
            this.lblLado.Name = "lblLado";
            this.lblLado.Size = new System.Drawing.Size(34, 13);
            this.lblLado.TabIndex = 2;
            this.lblLado.Text = "Lado:";
            // 
            // txtLado
            // 
            this.txtLado.Location = new System.Drawing.Point(331, 135);
            this.txtLado.Name = "txtLado";
            this.txtLado.Size = new System.Drawing.Size(82, 20);
            this.txtLado.TabIndex = 3;
            // 
            // lblArea
            // 
            this.lblArea.AutoSize = true;
            this.lblArea.Location = new System.Drawing.Point(176, 232);
            this.lblArea.Name = "lblArea";
            this.lblArea.Size = new System.Drawing.Size(32, 13);
            this.lblArea.TabIndex = 4;
            this.lblArea.Text = "Area:";
            // 
            // lblResulAreaCuadrado
            // 
            this.lblResulAreaCuadrado.AutoSize = true;
            this.lblResulAreaCuadrado.Location = new System.Drawing.Point(215, 232);
            this.lblResulAreaCuadrado.Name = "lblResulAreaCuadrado";
            this.lblResulAreaCuadrado.Size = new System.Drawing.Size(0, 13);
            this.lblResulAreaCuadrado.TabIndex = 5;
            // 
            // lblPerimetro
            // 
            this.lblPerimetro.AutoSize = true;
            this.lblPerimetro.Location = new System.Drawing.Point(350, 232);
            this.lblPerimetro.Name = "lblPerimetro";
            this.lblPerimetro.Size = new System.Drawing.Size(56, 13);
            this.lblPerimetro.TabIndex = 6;
            this.lblPerimetro.Text = "Perímetro:";
            // 
            // lblResulPerimCuadrado
            // 
            this.lblResulPerimCuadrado.AutoSize = true;
            this.lblResulPerimCuadrado.Location = new System.Drawing.Point(413, 232);
            this.lblResulPerimCuadrado.Name = "lblResulPerimCuadrado";
            this.lblResulPerimCuadrado.Size = new System.Drawing.Size(0, 13);
            this.lblResulPerimCuadrado.TabIndex = 7;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(307, 171);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(115, 32);
            this.btnCalcular.TabIndex = 8;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // ViewCuadrado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.lblResulPerimCuadrado);
            this.Controls.Add(this.lblPerimetro);
            this.Controls.Add(this.lblResulAreaCuadrado);
            this.Controls.Add(this.lblArea);
            this.Controls.Add(this.txtLado);
            this.Controls.Add(this.lblLado);
            this.Controls.Add(this.lblIngreseDatos);
            this.Controls.Add(this.lblCalculoCuadrado);
            this.Name = "ViewCuadrado";
            this.Text = "ViewCuadrado";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCalculoCuadrado;
        private System.Windows.Forms.Label lblIngreseDatos;
        private System.Windows.Forms.Label lblLado;
        private System.Windows.Forms.TextBox txtLado;
        private System.Windows.Forms.Label lblArea;
        private System.Windows.Forms.Label lblResulAreaCuadrado;
        private System.Windows.Forms.Label lblPerimetro;
        private System.Windows.Forms.Label lblResulPerimCuadrado;
        private System.Windows.Forms.Button btnCalcular;
    }
}