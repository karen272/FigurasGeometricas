using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using figurasGeometricas.Interfaz;

namespace figurasGeometricas.Modelo
{
    internal class Cuadrado : ICalcular
    {
        private double lado;

        public Cuadrado(double lado)
        {
            this.lado = lado;
        }

        public double Lado
        {
            get { return lado; }
            set { lado = value; }
        }

        public double calcularArea()
        {
            return Lado * Lado;
        }
        public double calcularPerimetro()
        {
            return lado * 4;
        }
    }
}
