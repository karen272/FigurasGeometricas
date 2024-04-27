using figurasGeometricas.Controlador;
using figurasGeometricas.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace figurasGeometricas.Vistas
{
    public partial class ViewTriangulo : Form
    {
        public ViewTriangulo()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double lado1 = Convert.ToDouble(txtLado1.Text);
            double lado2 = Convert.ToDouble(txtLado2.Text);
            double lado3 = Convert.ToDouble(txtLado3.Text);
            Triangulo triangulo = new Triangulo(lado1, lado2, lado3);

            if (triangulo.esTrianguloValido())
            {
                double area = Controler.calcularAreaTriangulo(triangulo);
                double perimetro = Controler.calcularPerimetroTriangulo(triangulo);
                double altura = Controler.calcularAlturaTriangulo(triangulo);
                string tipo = Controler.ceterminarTipoDeTriangulo(triangulo);

                string areaStr = area.ToString("0.000");
                string perimetroStr = perimetro.ToString("0.000");
                string alturaStr = altura.ToString("0.000");


                lblResulArea.Text= areaStr.ToString();
                lblResulPerimetro.Text= perimetroStr.ToString();
                lblResulAltura.Text= alturaStr.ToString();
                lblResulTipo.Text = tipo;
            }
        }

        private void ViewTriangulo_Load(object sender, EventArgs e)
        {

        }
    }
}
