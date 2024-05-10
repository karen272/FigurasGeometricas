using figurasGeometricas.Interfaz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace figurasGeometricas.Modelo
{
    internal class Poligono : ICalcular
    {
        private double lado;
        private double cantidad;

        public Poligono() { }

        public Poligono(double lado,double cantidad)
        {
            this.Lado = lado;
            this.cantidad = cantidad;
        }

        public double Lado
        {
            get { return lado; }
            set { lado = value; }

        }

        public double Cantidad
        {
            get { return cantidad; }
            set { cantidad = value; }
        }

        public double calcularPerimetro()
        {
            return Lado * Cantidad;
        }

        public double calcularArea()
        {
            return (Cantidad * Math.Pow(Lado, 2)) / (4 * Math.Tan(Math.PI / Cantidad));
        }
    }
}
