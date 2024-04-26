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
    public partial class ViewCuadrado : Form
    {
        public ViewCuadrado()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double lado = Convert.ToDouble(txtLado.Text);

            Cuadrado cuadrado = new Cuadrado(lado);

            double area = Controler.calcularAreaCuadrado(cuadrado);
            double perimetro = Controler.calcularPerimetroCuadrado(cuadrado);

            string areaStr = area.ToString("0.000");
            string perimetroStr = perimetro.ToString("0.000");

            lblResulAreaCuadrado.Text = areaStr.ToString();
            lblResulPerimCuadrado.Text = perimetroStr.ToString();
        }
    }
}
