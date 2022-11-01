using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos {
    class Membros 
    {
        public static void Executar() 
        {
            Pessoa sicrano = new Pessoa();
            sicrano.Nome = "Renato";
            sicrano.Idade = 21;

            sicrano.ApresentarNoConsole();

             

            var fulano = new Pessoa();
            fulano.Nome = "Beto";
            fulano.Idade = 22;

            var apresentacaoDoFulano = fulano.Apresentar();
        }
    }
}
