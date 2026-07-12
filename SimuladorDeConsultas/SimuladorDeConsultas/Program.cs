namespace SimuladorDeTarefas
{
    internal class Program
    {
        public async Task<int> Tarefa()
        {
            await Task.Delay(2000); 
            return 10;
        }

        public async Task<int> Tarefa2()
        {
            await Task.Delay(3000);
            return 20;
        }

        public async Task<int> Tarefa3()
        {
            await Task.Delay(1000);
            return 30;
        }
        static async Task Main(string[] args)
        {
            Console.WriteLine("Executar as tarefas em paralelo");
            Console.WriteLine();

            var rTarefa = new Program().Tarefa();
            var rTarefa2 = new Program().Tarefa2();
            var rTarefa3 = new Program().Tarefa3();

            int[] resultadoTarefas = await Task.WhenAll(rTarefa, rTarefa2, rTarefa3);

            int soma = resultadoTarefas[0] + resultadoTarefas[1] + resultadoTarefas[2];

            Console.WriteLine($"Os resultados são: {resultadoTarefas[0]}, {resultadoTarefas[1]} e {resultadoTarefas[2]}");
            Console.WriteLine($"A soma das 3 tarefas é: {soma}");

            Console.WriteLine() ;
            Console.WriteLine("Todas as tarefas foram concluídas");
        }
    }
}