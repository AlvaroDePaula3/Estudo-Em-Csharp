namespace Timeout_e_cancelamento
{
    internal class Program
    {
        public async Task<string> processamentoDemoradoAsync()
        {
            Console.WriteLine("Iniciando processamento...");
            await Task.Delay(5000);
            return "Processamento concluído com sucesso !";
        }

        public static async Task<string> cancelamentoTimeOut(CancellationToken cancelar)
        {
            try
            {
                for(int i = 0;i<5;i++)
                {
                    cancelar.ThrowIfCancellationRequested();
                    Console.WriteLine($"Progresso: {i}/5 segundos");
                    await Task.Delay(5000, cancelar);
                }
                return "Processamento concluído com sucesso!";
            }
            catch (OperationCanceledException)
            {
                Console.WriteLine("O usuário solicitou o cancelamento do processo");
                throw;
            }
        }

        static async Task Main(string[] args)
        {
            var programa = new Program();

            Console.WriteLine("Iniciar processo com timeout de 3 segundos...");

            var tarefa = programa.processamentoDemoradoAsync();
            var timeout = Task.Delay(3000);

            var tarefaConcluida = await Task.WhenAny(tarefa, timeout);

            if(tarefaConcluida == tarefa)
            {
                string resultado = await tarefa;
                Console.WriteLine($"✅{resultado}");
            } else
            {
                Console.WriteLine("Tarefa cancelada por timeout de 3 segundos");
            }
            using (var cts = new CancellationTokenSource())
            {
                Console.WriteLine("Aperte C para cancelar");
                var cancelandoTarefa = cancelamentoTimeOut(cts.Token);

                var apertarC = Task.Run(() =>
                {
                    while (true)
                    {
                        if(Console.KeyAvailable && Console.ReadKey(true).Key == ConsoleKey.C)
                        {
                            cts.Cancel();
                            break;
                        }
                    }
                });

                var tarefaFinalizada = await Task.WhenAny(cancelandoTarefa, apertarC);

                if(tarefaFinalizada == cancelandoTarefa)
                {
                    try
                    {
                        string resultado = await cancelandoTarefa;
                        Console.WriteLine($" {resultado}");
                    } catch (OperationCanceledException)
                    {
                        Console.WriteLine("A tarefa foi cancelada manualmente");
                    }
                } else
                {
                    Console.WriteLine(" Aguardando a tarefa finalizar...");
                    try
                    {
                        string resultado = await cancelandoTarefa;
                        Console.WriteLine($" {resultado}");
                    }
                    catch (OperationCanceledException)
                    {
                        Console.WriteLine("A tarefa foi cancelada manualmente");
                    }
                }
            }
        }
    }
}