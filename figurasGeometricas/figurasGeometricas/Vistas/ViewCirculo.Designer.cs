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
            this.SuspendLayout();
            // 
            // lblCalculoCirculo
            // 
            this.lblCalculoCirculo.AutoSize = true;
            this.lblCalculoCirculo.Location = new System.Drawing.Point(277, 51);
            this.lblCalculoCirculo.Name = "lblCalculoCirculo";
            this.lblCalculoCirculo.Size = new System.Drawing.Size(122, 13);
            this.lblCalculoCirculo.TabIndex = 0;
            this.lblCalculoCirculo.Text = "Calculo de un CIRCULO";
            // 
            // lblRadio
            // 
            this.lblRadio.AutoSize = true;
            this.lblRadio.Location = new System.Drawing.Point(259, 160);
            this.lblRadio.Name = "lblRadio";
            this.lblRadio.Size = new System.Drawing.Size(38, 13);
            this.lblRadio.TabIndex = 1;
            this.lblRadio.Text = "Radio:";
            // 
            // lblIngreseDatos
            // 
            this.lblIngreseDatos.AutoSize = true;
            this.lblIngreseDatos.Location = new System.Drawing.Point(301, 106);
            this.lblIngreseDatos.Name = "lblIngreseDatos";
            this.lblIngreseDatos.Size = new System.Drawing.Size(71, 13);
            this.lblIngreseDatos.TabIndex = 2;
            this.lblIngreseDatos.Text = "Ingrese datos";
            // 
            // txtRadio
            // 
            this.txtRadio.Location = new System.Drawing.Point(316, 153);
            this.txtRadio.Name = "txtRadio";
            this.txtRadio.Size = new System.Drawing.Size(100, 20);
            this.txtRadio.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(193, 307);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Area:";
            // 
            // lblResulArea
            // 
            this.lblResulArea.AutoSize = true;
            this.lblResulArea.Location = new System.Drawing.Point(241, 307);
            this.lblResulArea.Name = "lblResulArea";
            this.lblResulArea.Size = new System.Drawing.Size(0, 13);
            this.lblResulArea.TabIndex = 5;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(316, 198);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(77, 33);
            this.btnCalcular.TabIndex = 6;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // lblPerimetro
            // 
            this.lblPerimetro.AutoSize = true;
            this.lblPerimetro.Location = new System.Drawing.Point(447, 308);
            this.lblPerimetro.Name = "lblPerimetro";
            this.lblPerimetro.Size = new System.Drawing.Size(54, 13);
            this.lblPerimetro.TabIndex = 8;
            this.lblPerimetro.Text = "Perimetro:";
            // 
            // lblResulPerim
            // 
            this.lblResulPerim.AutoSize = true;
            this.lblResulPerim.Location = new System.Drawing.Point(507, 307);
            this.lblResulPerim.Name = "lblResulPerim";
            this.lblResulPerim.Size = new System.Drawing.Size(0, 13);
            this.lblResulPerim.TabIndex = 9;
            // 
            // ViewCirculo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblResulPerim);
            this.Controls.Add(this.lblPerimetro);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.lblResulArea);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtRadio);
            this.Controls.Add(this.lblIngreseDatos);
            this.Controls.Add(this.lblRadio);
            this.Controls.Add(this.lblCalculoCirculo);
            this.Name = "ViewCirculo";
            this.Text = "ViewCirculo";
            this.Load += new System.EventHandler(this.ViewCirculo_Load);
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
    }
}