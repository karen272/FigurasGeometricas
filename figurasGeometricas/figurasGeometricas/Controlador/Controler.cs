using figurasGeometricas.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace figurasGeometricas.Controlador
{
    internal class Controler
    {
        internal static double calcularAlturaTriangulo(Triangulo triangulo)
        {
            return triangulo.calcularAltura(triangulo.Lado3);
        }

        internal static double calcularAreaCirculo(Circulo circulo)
        {
            return circulo.calcularArea();
        }

        internal static double calcularAreaCuadrado(Cuadrado cuadrado)
        {
            return cuadrado.calcularArea();
        }

        internal static double calcularAreaTriangulo(Triangulo triangulo)
        {
            return triangulo.calcularArea();
        }

        internal static double calcularPerimetroCirculo(Circulo circulo)
        {
            return circulo.calcularPerimetro();
        }

        internal static double calcularPerimetroCuadrado(Cuadrado cuadrado)
        {
            return cuadrado.calcularPerimetro();
        }

        internal static double calcularPerimetroTriangulo(Triangulo triangulo)
        {
            return triangulo.calcularPerimetro();
        }

        internal static string ceterminarTipoDeTriangulo(Triangulo triangulo)
        {
            return triangulo.determinarTipoTriangulo();
        }
    }
}
