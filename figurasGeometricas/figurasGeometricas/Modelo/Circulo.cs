using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using figurasGeometricas.Interfaz;

namespace figurasGeometricas.Modelo
{
    internal class Circulo : ICalcular
    {
        private double radio;


        public Circulo() { } 

        public Circulo(double radio)
        {
            this.radio = radio;
        }

        public double Radio
        {
            get { return radio; }
            set { radio = value; }
        }

        
        public double calcularArea()
        {
            return Math.PI * radio * radio;
        }
        public double calcularPerimetro()
        {
            return 2 * Math.PI * radio;
        }


    }


}
