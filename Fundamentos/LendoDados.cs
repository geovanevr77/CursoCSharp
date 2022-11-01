using System;
using System.Globalization;

namespace CursoCSharp.Fundamentos {
    internal class LendoDados {
        public static void Executar() {

            Console.Write("1- Qual é seu nome?");
            string nome = Console.ReadLine();

            Console.Write("2- Qual é a sua idade?");
            int idade = int.Parse(Console.ReadLine());

            Console.Write("3- Qual é o seu salario?");
            double salario = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            Console.WriteLine("Dados do Cadastrante:");
            
                Console.WriteLine($"NOME:{nome} " + $"IDADE: {idade} " +
                    $"SALÁRIO: R${salario}.");
             


        }
    }
}
