using System;

namespace interface_geometrica
{
    public interface IForma
    {
        double calcularArea();
        double calcularPerimetro();
    }

    public class Quadrado: IForma
    {
        private double lado;

        public double Lado
        {
            get { return lado; }
            private set { lado = value; }
        }

        public double calcularArea()
        {
            return Lado * Lado;
        }

        public double calcularPerimetro()
        {
            return 4 * Lado;
        }
        public Quadrado(double lado)
        {
            Lado = lado;
        }
    }

    public class Triangulo: IForma
    {
        private double baseTriangulo;
        private double alturaTriangulo;
        private double ladoTriangulo;

        public double LadoTriangulo
        {
            get { return ladoTriangulo; }
            private set { ladoTriangulo = value; }
        }

        public double BaseTriangulo
        {
            get { return baseTriangulo; }
            private set { baseTriangulo = value;}
        }

        public double AlturaTriangulo
        {
            get { return alturaTriangulo; }
            private set { alturaTriangulo = value;}
        }

        public double calcularArea()
        {
            return (baseTriangulo * alturaTriangulo) / 2;
        }

        public double calcularPerimetro()
        {
            return 3 * LadoTriangulo;
        }

        public Triangulo(double baseTriangulo, double alturaTriangulo, double ladoTriangulo)
        {
            BaseTriangulo = baseTriangulo;
            AlturaTriangulo = alturaTriangulo;
            LadoTriangulo = ladoTriangulo;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            IForma quadrado = new Quadrado(5);
            IForma triangulo = new Triangulo(4, 5, 7);

            Console.WriteLine($"Quadrado - Área:{quadrado.calcularArea()} e Perímetro: {quadrado.calcularPerimetro()}");
            Console.WriteLine($"Triângulo - Área:{triangulo.calcularArea()} e Perímetro: {triangulo.calcularPerimetro()}");
        }
    }
}