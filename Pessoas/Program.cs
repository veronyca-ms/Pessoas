using System;
using System.Globalization;

namespace Exercicios
{
    class SalarioPessoas
    {
        public static void MainSalario(string[] args) // So executa o programa 'Main' na classe.
        {
            Salario p1 = new Salario();
            Salario p2 = new Salario();

            Console.WriteLine("Dados do primeiro funcionário: ");
            Console.WriteLine("Nome: ");

            p1.nome = Console.ReadLine();
            Console.WriteLine("Salário: ");
            p1.salario = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            Console.WriteLine("Nome: ");
            p2.nome = Console.ReadLine();
            Console.WriteLine("Salário: ");
            p2.salario = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            double mediaSalario = (p1.salario + p2.salario) / 2;

            Console.WriteLine("Salário Médio: " + mediaSalario.ToString("F2", CultureInfo.InvariantCulture));

        }
    }

    class NomePessoas 
    {
        public static void MainPessoas(string[] args)
        {
            Peaple p1 = new Peaple();
            Peaple p2 = new Peaple();

            Console.WriteLine("Dados das Pessoas: ");
            Console.WriteLine("Nome da Pessoa 1: ");
            p1.nome = Console.ReadLine();
            Console.WriteLine("Idade da Pessoa 1: ");
            p1.idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Nome da Pessoa 2: ");
            p2.nome = Console.ReadLine();
            Console.WriteLine("Idade da Pessoa 2: ");
            p2.idade = int.Parse(Console.ReadLine());

            if(p1.idade > p2.idade)
            {
                Console.WriteLine($"{p1.idade}");
            }
            else
            {
                Console.WriteLine($"{p2.idade}");
            }
        }
    }
}
