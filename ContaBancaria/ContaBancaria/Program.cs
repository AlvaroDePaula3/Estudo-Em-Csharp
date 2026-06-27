namespace ContaBancaria
{
    internal class Program
    {
        class contaBancaria
        {
            private double saldo;

            public double Saldo
            {
                get { return saldo; }
                private set { saldo = value; }
            }

            public void Depositar(double valor)
            {
                if(valor <= 0)
                {
                    Console.WriteLine("Valores negativos não são permitidos");
                    return;
                }
                Saldo += valor;
                Console.WriteLine($"O valor do depósito é de: {valor:F2}");
            }
            public void Sacar(double valor)
            {
                if(valor < 0)
                {
                    Console.WriteLine("Não é possível realizar esse saque, pois o saldo ficará negativo");
                    return;
                }
                if (valor > Saldo)
                {
                    Console.WriteLine($"Saldo insuficiente: {valor:F2}");
                    return;
                }
                Saldo -= valor;
            }
            public contaBancaria(double saldoInicial)
            {
                Saldo = saldoInicial;
            }
        }
        static void Main(string[] args)
        {
            contaBancaria conta = new contaBancaria(0);
            Console.WriteLine("Deposite um valor: ");
            conta.Depositar(500);
            conta.Sacar(250);

            Console.WriteLine($"O valor atual é: {conta.Saldo:F2}");
    
        }
    }
}