// See https://aka.ms/new-console-template for more information


namespace Arquitecto_Aritmetica
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Calcular el área de Teotihuacán
            double areaRectangulo = Rectangulo(2500, 1500);
            double areaTriangulo = Trinagulo(750, 500);
            double areaCirculoMitad = Circulo(375) / 2;
            double areaTotal = areaRectangulo + areaTriangulo + areaCirculoMitad;

            // Calcular el costo total
            double costoPorMetroCuadrado = 180;
            double costoTotal = areaTotal * costoPorMetroCuadrado;

            // Redondear el costo a dos decimales
            costoTotal = Math.Round(costoTotal, 2);

            // Mostrar el resultado
            Console.WriteLine($"El costo total de construir Teotihuacán es: ${costoTotal} pesos mexicanos.");
        }

        // Métodos para calcular áreas
        static double Rectangulo(double longitud, double ancho)
        {
            return longitud * ancho;
        }

        static double Circulo(double radio)
        {
            return Math.PI * Math.Pow(radio, 2);
        }

        static double Trinagulo(double base_, double altura)
        {
            return 0.5 * base_ * altura;
        }
    }
}