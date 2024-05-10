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
    public partial class ViewPoligono : Form
    {
        public ViewPoligono()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double lado = Convert.ToDouble(txtLado.Text);
            double cantidad = Convert.ToDouble(txtCantidad.Text);

            Poligono poligono = new Poligono(lado, cantidad);

            double area = Controler.calcularAreaPoligono(poligono);
            double perimetro = Controler.calcularPerimetroPoligono(poligono);


            string areaStr = area.ToString("0.000");
            string perimetroStr = perimetro.ToString("0.000");

            lblResultadoArea.Text = areaStr.ToString();
            lblResultadoPerimetro.Text = perimetroStr.ToString();
        }
    }
}
