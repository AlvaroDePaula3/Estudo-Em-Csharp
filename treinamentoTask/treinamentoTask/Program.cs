using System.Security.Cryptography.X509Certificates;
using System;
using System.Threading.Tasks;

namespace treinamentoTask
{
    internal class Program
    {
        public async Task<string> esperando3SegundosAsync()
        {
            await Task.Delay(3000);
            return "Esperei 3 segundos !";
        }
        static async Task Main(string[] args)
        {
            var esperado = await new Program().esperando3SegundosAsync();
            Console.WriteLine(esperado);
        }
    }
}