using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.EstruturasDeControle {
    internal class EstruturaIfElse {
        public static void Executar() {
           
            string entrada;
            Console.Write("Digite a nota: ");
            entrada = Console.ReadLine();
            double.TryParse(entrada, out double nota);

            if(nota >= 7.0) {
                Console.WriteLine("APROVADO!");
                Console.WriteLine("Não fez mais do que sua obrigação...");

            }else {
                Console.WriteLine("RECUPERAÇÃO!");
            }
        }
    }
}
