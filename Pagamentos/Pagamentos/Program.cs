namespace Pagamentos
{

    public abstract class Pagamento
    {
        private double valor;
        private DateTime data;

        public double Valor
        {
            get { return valor; }
            private set { valor = value; }
        }

        public DateTime Data
        {
            get { return data; }
            private set { data = value; }
        }

        public abstract string Processar();

        public virtual void exibirDetalhe()
        {
            Console.WriteLine();
            Console.WriteLine(valor);
            Console.WriteLine(data);
            
        }
        public Pagamento(double valor)
        {
            Valor = valor;
            Data = DateTime.Now;
        }
    }

    public class PagamentoCartaoDeCredito : Pagamento
    {
        private string numeroCartao;

        public string NumeroCartao
        {
            get { return numeroCartao; }
            private set { numeroCartao = value; }
        }

        public override string Processar()
        {
            string ultimosDigitos = NumeroCartao.Length >= 4 ? NumeroCartao[^4..] : "****";
            return $"Pagamento de R${Valor:F2} aprovado no cartão {ultimosDigitos} em {Data: dd/MM/yyyy}";
        }

        public override void exibirDetalhe()
        {
            Console.WriteLine();
            base.exibirDetalhe();
            Console.WriteLine($"Numero do Cartão: ****-{NumeroCartao[^4..]}");
            
        }

        public PagamentoCartaoDeCredito(double valor, string numeroCartao) : base(valor)
        {
            NumeroCartao = numeroCartao;
        }
    }

    public class PagamentoBoleto : Pagamento
    {
        private string codigoBoleto;

        public string CodigoBoleto
        {
            get { return codigoBoleto; }
            private set { codigoBoleto = value; }
        }

        public override string Processar()
        {
            return $"Boleto de valor R${Valor:F2} gerado. Código: [{CodigoBoleto}]";
        }

        public override void exibirDetalhe()
        {
            base.exibirDetalhe();
            Console.WriteLine();
            Console.WriteLine(Valor);
            Console.WriteLine(Data);
            
        }

        public PagamentoBoleto(double valor, string codigoDoBoleto):base(valor)
        {
            CodigoBoleto = codigoDoBoleto;
        }
    }

    public class PagamentoPix : Pagamento
    {
        private string chavePix;

        public string ChavePix
        {
            get { return chavePix; }
            set { chavePix = value; }
        }

        public override string Processar()
        {
            return $"Pagamento de R${Valor:F2} via PIX para a chave {ChavePix} confirmado!";
        }

        public override void exibirDetalhe()
        {
            base.exibirDetalhe();
            Console.WriteLine(Valor);
            Console.WriteLine(Data);
            Console.WriteLine();
        }

        public PagamentoPix(double valor, string chaveDoPix) : base(valor)
        {
            ChavePix = chaveDoPix;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            List<Pagamento> pagamentos = new List<Pagamento>
            {
                new PagamentoCartaoDeCredito(200.00, "4321"),
                new PagamentoPix(180.00, "2112345678"),
                new PagamentoBoleto(70.00, "9876.5432.1032")
            };

            foreach(var pago in pagamentos)
            {
                pago.exibirDetalhe();
                Console.WriteLine(pago.Processar());
            }


        
        }
    }
}