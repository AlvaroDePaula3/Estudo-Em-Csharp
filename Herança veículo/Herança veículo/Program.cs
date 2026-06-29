using System;

namespace Herança_veículo
{
    public class Veiculo
    {
        private string marca;
        private string modelo;
        private int ano;

        public string Marca
        {
            get { return marca; }
            private set { marca = value; }
        }

        public string Modelo { 
            get { return modelo; } 
            private set { modelo = value; }
        }

        public int Ano
        {
            get { return ano; }
            private set { ano = value; }
        }

        public virtual void exibirInformacoes()
        {
            Console.WriteLine($"A Marca é: {Marca}, o modelo é: {Modelo} e o ano é: {Ano}");
        }

        public Veiculo(string marca, string modelo, int ano)
        {
            this.Marca = marca;
            this.Modelo = modelo;
            this.Ano = ano;
        }
    }

    public class Carro:Veiculo
    {
        private int numerodeportas;

        public int NumeroDePortas
        {
            get { return numerodeportas; }
            set { numerodeportas = value; }
        }

        public Carro(string marca, string modelo, int ano, int portas)
            : base(marca, modelo, ano)
        {
            numerodeportas = portas;
        }

        public override void exibirInformacoes()
        {
            base.exibirInformacoes();
            Console.WriteLine($"Esse carro possui {numerodeportas} portas");
        }
    }

    public class Moto : Veiculo
    {
        private int cilindradas;

        public int Cilindradas
        {
            get { return cilindradas; }
            set { cilindradas = value; }
        }

        public Moto(string marca, string modelo, int ano, int cilindros) : base(marca, modelo, ano)
        {
            cilindradas = cilindros;
        }

        public override void exibirInformacoes()
        {
            base.exibirInformacoes();
            Console.WriteLine($" Essa moto possui: {cilindradas} cilindradas");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Carro carro = new Carro("Aodi", "A3", 2008, 4);
            Moto moto = new Moto("Kawazaki", "Ninja", 1984, 50);

            carro.exibirInformacoes();
            Console.WriteLine();
            moto.exibirInformacoes();
        }
    }
}