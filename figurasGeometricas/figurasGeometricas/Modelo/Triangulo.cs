using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using figurasGeometricas.Interfaz;

namespace figurasGeometricas.Modelo
{
    internal class Triangulo : ICalcular
    {
        private double lado1;
        private double lado2;
        private double lado3;

        public Triangulo(){}

        public Triangulo(double lado1, double lado2, double lado3)
        {
            this.Lado1 = lado1;
            this.Lado2 = lado2;
            this.Lado3 = lado3;
        }

        public double Lado1
        {
            get{return this.lado1;}
            set{lado1 = value;}

        }

        public double Lado2
        {
            get { return this.lado2; }
            set { lado2 = value; }
        }

        public double Lado3
        {
            get { return this.lado3; }
            set { lado3 = value; }
        }



        public string determinarTipoTriangulo()
        {
            if (lado1 == lado2 && lado2 == lado3)
            {
                return "Equilátero";
            }
            else if (lado1 == lado2 || lado1 == lado3 || lado2 == lado3)
            {
                return "Isósceles";
            }
            else
            {
                return "Escaleno";
            }
        }

        public bool esTrianguloValido()
        {
            // Verificar la desigualdad triangular
            return (lado1 + lado2 > lado3) && (lado2 + lado3 > lado1) && (lado3 + lado1 > lado2);
        }

        public double calcularPerimetro()
        {
            return lado1 + lado2 + lado3;
        }

        public double calcularArea()
        {
            // Semiperímetro del triángulo
            double s = calcularPerimetro() / 2;

            // Área utilizando la fórmula de Herón
            double area = Math.Sqrt(s * (s - lado1) * (s - lado2) * (s - lado3));
            return area;
        }

        public double calcularAltura(double lado)
        {
            double s = calcularPerimetro() / 2;
            double area = Math.Sqrt(s * (s - lado1) * (s - lado2) * (s - lado3));

            double altura = 2 * area / lado;
            return altura;
        }
    }

    
    
}
