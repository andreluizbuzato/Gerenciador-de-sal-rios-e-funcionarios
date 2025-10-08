using System;
using System.Collections.Generic;

namespace SistemaFuncionarios
{
    // Classe abstrata base
    public abstract class Funcionario
    {
        public string Nome { get; set; }
        public double SalarioBase { get; set; }

        public abstract double CalcularSalario();

        public void ExibirDados()
        {
            Console.WriteLine($"Nome: {Nome}");
            Console.WriteLine($"Salário Base: R$ {SalarioBase:F2}");
            Console.WriteLine($"Salário Final: R$ {CalcularSalario():F2}");
            Console.WriteLine("-----------------------------------");
        }
    }

    public class Administrativo : Funcionario
    {
        public override double CalcularSalario()
        {
            return SalarioBase + (SalarioBase * 0.10);
        }
    }

    public class Tecnico : Funcionario
    {
        public override double CalcularSalario()
        {
            return SalarioBase + (SalarioBase * 0.20);
        }
    }

    public class Estagiario : Funcionario
    {
        public override double CalcularSalario()
        {
            return SalarioBase / 2;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Funcionario> funcionarios = new List<Funcionario>();
            string opcao;

            Console.WriteLine("=== SISTEMA DE CADASTRO DE FUNCIONÁRIOS ===\n");

            do
            {
                int tipo;
                while (true)
                {
                    Console.WriteLine("Selecione o tipo de funcionário:");
                    Console.WriteLine("1 - Administrativo");
                    Console.WriteLine("2 - Técnico");
                    Console.WriteLine("3 - Estagiário");
                    Console.Write("Opção: ");
                    if (int.TryParse(Console.ReadLine(), out tipo) && tipo >= 1 && tipo <= 3)
                        break;
                    Console.WriteLine("Opção inválida! Tente novamente.\n");
                }

                Funcionario f = tipo switch
                {
                    1 => new Administrativo(),
                    2 => new Tecnico(),
                    3 => new Estagiario(),
                    _ => null
                };

                Console.Write("Nome do funcionário: ");
                f.Nome = Console.ReadLine();

                double salario;
                while (true)
                {
                    Console.Write("Salário base: R$ ");
                    if (double.TryParse(Console.ReadLine(), out salario) && salario >= 0)
                        break;
                    Console.WriteLine("Valor inválido! Digite um número positivo.\n");
                }
                f.SalarioBase = salario;

                funcionarios.Add(f);

                Console.Write("\nDeseja cadastrar outro funcionário? (S/N): ");
                opcao = Console.ReadLine().ToUpper();
                Console.WriteLine();

            } while (opcao == "S");

            Console.WriteLine("\n=== RELATÓRIO DE FUNCIONÁRIOS ===\n");

            foreach (var func in funcionarios)
            {
                Console.WriteLine($"Cargo: {func.GetType().Name}");
                func.ExibirDados();
            }

            Console.WriteLine("Fim do relatório. Pressione qualquer tecla para sair...");
            Console.ReadKey();
        }
    }
}
