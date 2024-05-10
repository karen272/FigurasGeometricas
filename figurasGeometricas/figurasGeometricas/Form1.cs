using figurasGeometricas.Vistas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace figurasGeometricas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnCirculo_Click(object sender, EventArgs e)
        {
            ViewCirculo circulo = new ViewCirculo();
            circulo.ShowDialog();
        }

        private void btnCuadrado_Click(object sender, EventArgs e)
        {
            ViewCuadrado cuadrado = new ViewCuadrado();
            cuadrado.ShowDialog();
        }

        private void btnTriangulo_Click(object sender, EventArgs e)
        {
            ViewTriangulo triangulo = new ViewTriangulo();
            triangulo.ShowDialog();
        }

        private void btnPoligono_Click(object sender, EventArgs e)
        {
            ViewPoligono poligono = new ViewPoligono();
            poligono.ShowDialog();
        }
    }
}
