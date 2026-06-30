using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System;
using System.Collections.Generic;

namespace Heranca_Funcionario
{
    public class Funcionario
    {
        private string nome;
        private double salarioBase;

        public string Nome{ 
            get { return nome; }
            set { nome = value; }
        }

        public double SalarioBase
        {
            get { return salarioBase; }
            set { salarioBase = value; }
        }

        public virtual double calcularSalario()
        {
            return SalarioBase;
        }
        public Funcionario(string nome, double salarioBase)
        {
            Nome = nome;
            SalarioBase = salarioBase;
        }

    }

    public class FuncionarioCLT : Funcionario
    {
        public FuncionarioCLT(string nome, double salarioBase) : base(nome, salarioBase) { }

        public override double calcularSalario()
        {
            return SalarioBase + (SalarioBase * 0.10);
        }

    }

    public class FuncionarioPJ : Funcionario
    {
        public FuncionarioPJ(string nome, double salarioBase) : base(nome, salarioBase) { }

        public override double calcularSalario()
        {
            return SalarioBase * 1.20;
        }
    }

    public class Estagiario : Funcionario
    {
        public Estagiario(string nome, double salarioBase) : base(nome, salarioBase) { }

        public override double calcularSalario()
        {
            return SalarioBase * 0.50;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Funcionario> funcionarios = new List<Funcionario>();
            funcionarios.Add(new FuncionarioCLT("Carlos", 7000));
            funcionarios.Add(new FuncionarioPJ("Ana", 20000));
            funcionarios.Add(new Estagiario("Alvaro", 4400));

            foreach (var f in funcionarios)
            {
                Console.WriteLine($"O nome do(a) colaborador é: {f.Nome} e seu salário é: R${f.calcularSalario():F2}");
            }

        }
    }
}