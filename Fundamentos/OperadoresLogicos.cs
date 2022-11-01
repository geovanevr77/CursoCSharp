using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos {
    internal class OperadoresLogicos {
        public static void Executar() {
            
            var executarTrabalho1 = true;
            var executarTrabalho2 = true;

            bool comprouTv50 = executarTrabalho1 && executarTrabalho2;
            Console.WriteLine("Comprou a Tv50? {0}", comprouTv50);

            var comprouSorvete = executarTrabalho1 || executarTrabalho2;
            Console.WriteLine("Comprou o sorvete? {0}", comprouSorvete);

            var comprouTv32 = executarTrabalho1 ^ executarTrabalho2;
            Console.WriteLine("Comprou a Tv32? {0}", comprouTv32);

            Console.WriteLine("Mais saudável? {0}", !comprouSorvete);
        }
    }
}
