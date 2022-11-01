using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos {
    internal class OperadoresAritmeticos {
        public static void Executar() {
            //Preço Desconto
            var preço = 1000.0;
            var imposto = 355;
            var desconto = 0.1;

            double total = preço = imposto;
            var totalComDesconto = total - (total * desconto);
            Console.WriteLine ("O preço final é: {0}", totalComDesconto);

            //IMC
            double peso = 91.2;
            double altura = 55;
            double imc = peso / Math.Pow(altura, 2);
            Console.WriteLine($"IMC É: {imc}");

            //Número PAR/IMPAR
            int par = 24;
            int impar = 55;
            Console.WriteLine("{0}/2 tem resto {1}", par, par % 2);
            Console.WriteLine("{0}/2 tem resto {1}", impar, impar % 2);

        }
    }
}
