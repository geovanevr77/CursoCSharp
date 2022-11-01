using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos {
    internal class NotaçaoPonto {

        public static void Executar() {
            var saudaçao = "olá".ToUpper().Insert(3, "world!").Replace("world!", " mundo!");
            Console.WriteLine(saudaçao);

            string valorImportante = null;
            Console.WriteLine(valorImportante?.Length);

        }
    } 
}
