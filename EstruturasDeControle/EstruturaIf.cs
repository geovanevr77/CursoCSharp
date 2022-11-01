using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.EstruturasDeControle {
    internal class EstruturaIf {
        public static void Executar() {
            bool bomComportamento = false;
            string entrada;

            Console.Write("Digite a nota do aluno: ");
            entrada = Console.ReadLine();
            Double.TryParse(entrada, out double nota);

            Console.WriteLine("Possui um bom comportamento (S/N)?");
            entrada = Console.ReadLine();

            //Maneiras de leitura de um S ou s:
            //if (entrada == "S" || entrada == "s") bomComportamento = true;
            //bomComportamento = entrada == "S" || entrada == "s";
            bomComportamento = entrada.ToLower() == "s";

            // usado {} para leitura somente do bloco.
            //atenção para a utilização do ponto e vírgula.
            if (nota >= 9.0 && bomComportamento) {
                Console.WriteLine("Quadro de honra!");
            }





        }
    }
}
