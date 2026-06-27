using System;

namespace Termometro
{
    class Program
    {
        class termometro
        {
            private double temperatura;

            public double Temp
            {
                get { return temperatura; }
                set
                {
                    if (temperatura < -273.15)
                    {
                        Console.WriteLine("A temperatura não pode ser abaixo do 0 absoluto.");
                    }
                    else
                    {
                        temperatura = value;
                    }
                }
            }
        }
        static void Main(string[] args)
        {
            termometro Termo = new termometro();
            Console.WriteLine("Digite a temperatura atual");

            double valor = double.Parse(Console.ReadLine());
            Termo.Temp = valor;
            Console.WriteLine($"Temperatura atual é: {valor}ºC");

            Console.ReadKey();
        }
    }
}
