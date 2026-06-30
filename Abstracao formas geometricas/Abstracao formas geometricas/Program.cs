using System;

namespace Abstracao_formas_geometricas
{
    public abstract class Forma
    {
        public abstract double calcularArea();
        public abstract double calcularPerimetro();
    }

    public class Circulo : Forma
    {
        private double raio;
        
        public double Raio
        {
            get { return raio; }
            set { raio = value; }
        }

        public override double calcularArea()
        {
            return Math.PI * Math.Pow(Raio, 2);
        }

        public override double calcularPerimetro()
        {
            return 2 * Math.PI * Raio;
        }

        public Circulo(double raio)
        {
            Raio = raio;
        }
    }

    public class Retangulo : Forma
    {
        private double Base;
        private double Altura;

        public double baseRetangulo
        {
            get { return Base; }
            set { Base = value; }
        }

        public double alturaRetangulo
        {
            get { return Altura; }
            set { Altura = value; }
        }

        public override double calcularArea()
        {
            return baseRetangulo * alturaRetangulo;
        }

        public override double calcularPerimetro()
        {
            return 2 * (baseRetangulo + alturaRetangulo);
        }

        public Retangulo(double base1, double altura1)
        {
            baseRetangulo = base1;
            Altura = altura1;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
          //  List<double> formaGeometrica = new List<double>();
            Forma circular = new Circulo(4);
            Forma retangular = new Retangulo(2, 4);

            Console.WriteLine($"A medida da área do círculo é: {circular.calcularArea():F2} e do perímetro é: {circular.calcularPerimetro():F2}");
            Console.WriteLine($"A medida da área do retângulo é: {retangular.calcularArea():F2} e do perímetro é: {retangular.calcularPerimetro():F2}");

           
        }
    }
}