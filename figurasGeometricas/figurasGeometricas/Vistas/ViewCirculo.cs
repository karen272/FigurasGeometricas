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
    public partial class ViewCirculo : Form
    {
        public ViewCirculo()
        {
            InitializeComponent();
        }

        private void ViewCirculo_Load(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double radio = Convert.ToDouble(txtRadio.Text);

            Circulo circulo = new Circulo(radio);

            double area = Controler.calcularAreaCirculo(circulo);
            double perimetro = Controler.calcularPerimetroCirculo(circulo);

            string areaStr = area.ToString("0.000");
            string perimetroStr = perimetro.ToString("0.000");

            lblResulArea.Text = areaStr.ToString();
            lblResulPerim.Text = perimetroStr.ToString();

        }
    }
}
