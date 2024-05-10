namespace figurasGeometricas.Vistas
{
    partial class ViewPoligono
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
            this.lblTituCalculoDPoligono = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.lblCantDLados = new System.Windows.Forms.Label();
            this.lblValorDLados = new System.Windows.Forms.Label();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.txtLado = new System.Windows.Forms.TextBox();
            this.lblResult = new System.Windows.Forms.Label();
            this.lblTituloArea = new System.Windows.Forms.Label();
            this.lblTituloPerim = new System.Windows.Forms.Label();
            this.lblResultadoArea = new System.Windows.Forms.Label();
            this.lblResultadoPerimetro = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTituCalculoDPoligono
            // 
            this.lblTituCalculoDPoligono.AutoSize = true;
            this.lblTituCalculoDPoligono.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.lblTituCalculoDPoligono.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblTituCalculoDPoligono.Location = new System.Drawing.Point(218, 29);
            this.lblTituCalculoDPoligono.Name = "lblTituCalculoDPoligono";
            this.lblTituCalculoDPoligono.Size = new System.Drawing.Size(260, 25);
            this.lblTituCalculoDPoligono.TabIndex = 0;
            this.lblTituCalculoDPoligono.Text = "Calculo de un POLÍGONO";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label1.Location = new System.Drawing.Point(141, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ingrese Datos";
            // 
            // btnCalcular
            // 
            this.btnCalcular.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.btnCalcular.Location = new System.Drawing.Point(115, 111);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(123, 42);
            this.btnCalcular.TabIndex = 2;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = false;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // lblCantDLados
            // 
            this.lblCantDLados.AutoSize = true;
            this.lblCantDLados.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.lblCantDLados.Location = new System.Drawing.Point(18, 28);
            this.lblCantDLados.Name = "lblCantDLados";
            this.lblCantDLados.Size = new System.Drawing.Size(154, 20);
            this.lblCantDLados.TabIndex = 3;
            this.lblCantDLados.Text = "Cantidad de Lados:";
            // 
            // lblValorDLados
            // 
            this.lblValorDLados.AutoSize = true;
            this.lblValorDLados.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.lblValorDLados.Location = new System.Drawing.Point(24, 66);
            this.lblValorDLados.Name = "lblValorDLados";
            this.lblValorDLados.Size = new System.Drawing.Size(148, 20);
            this.lblValorDLados.TabIndex = 4;
            this.lblValorDLados.Text = "Valor de los lados:";
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(190, 28);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(84, 20);
            this.txtCantidad.TabIndex = 5;
            // 
            // txtLado
            // 
            this.txtLado.Location = new System.Drawing.Point(190, 68);
            this.txtLado.Name = "txtLado";
            this.txtLado.Size = new System.Drawing.Size(84, 20);
            this.txtLado.TabIndex = 6;
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.lblResult.Location = new System.Drawing.Point(160, 291);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(93, 20);
            this.lblResult.TabIndex = 7;
            this.lblResult.Text = "Resultados";
            // 
            // lblTituloArea
            // 
            this.lblTituloArea.AutoSize = true;
            this.lblTituloArea.BackColor = System.Drawing.SystemColors.Control;
            this.lblTituloArea.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.lblTituloArea.Location = new System.Drawing.Point(17, 10);
            this.lblTituloArea.Name = "lblTituloArea";
            this.lblTituloArea.Size = new System.Drawing.Size(49, 20);
            this.lblTituloArea.TabIndex = 8;
            this.lblTituloArea.Text = "Area:";
            // 
            // lblTituloPerim
            // 
            this.lblTituloPerim.AutoSize = true;
            this.lblTituloPerim.BackColor = System.Drawing.SystemColors.Control;
            this.lblTituloPerim.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.lblTituloPerim.Location = new System.Drawing.Point(200, 10);
            this.lblTituloPerim.Name = "lblTituloPerim";
            this.lblTituloPerim.Size = new System.Drawing.Size(87, 20);
            this.lblTituloPerim.TabIndex = 9;
            this.lblTituloPerim.Text = "Perímetro:";
            // 
            // lblResultadoArea
            // 
            this.lblResultadoArea.AutoSize = true;
            this.lblResultadoArea.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.lblResultadoArea.Location = new System.Drawing.Point(77, 10);
            this.lblResultadoArea.Name = "lblResultadoArea";
            this.lblResultadoArea.Size = new System.Drawing.Size(0, 20);
            this.lblResultadoArea.TabIndex = 10;
            // 
            // lblResultadoPerimetro
            // 
            this.lblResultadoPerimetro.AutoSize = true;
            this.lblResultadoPerimetro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.lblResultadoPerimetro.Location = new System.Drawing.Point(293, 10);
            this.lblResultadoPerimetro.Name = "lblResultadoPerimetro";
            this.lblResultadoPerimetro.Size = new System.Drawing.Size(0, 20);
            this.lblResultadoPerimetro.TabIndex = 11;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::figurasGeometricas.Properties.Resources.poligono;
            this.pictureBox1.Location = new System.Drawing.Point(462, 73);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(212, 286);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel1.Controls.Add(this.txtLado);
            this.panel1.Controls.Add(this.txtCantidad);
            this.panel1.Controls.Add(this.lblValorDLados);
            this.panel1.Controls.Add(this.lblCantDLados);
            this.panel1.Controls.Add(this.btnCalcular);
            this.panel1.Location = new System.Drawing.Point(49, 100);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(344, 169);
            this.panel1.TabIndex = 13;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel2.Controls.Add(this.lblResultadoPerimetro);
            this.panel2.Controls.Add(this.lblResultadoArea);
            this.panel2.Controls.Add(this.lblTituloPerim);
            this.panel2.Controls.Add(this.lblTituloArea);
            this.panel2.Location = new System.Drawing.Point(50, 323);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(342, 48);
            this.panel2.TabIndex = 14;
            // 
            // ViewPoligono
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTituCalculoDPoligono);
            this.Name = "ViewPoligono";
            this.Text = "ViewPoligono";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTituCalculoDPoligono;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label lblCantDLados;
        private System.Windows.Forms.Label lblValorDLados;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.TextBox txtLado;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Label lblTituloArea;
        private System.Windows.Forms.Label lblTituloPerim;
        private System.Windows.Forms.Label lblResultadoArea;
        private System.Windows.Forms.Label lblResultadoPerimetro;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}