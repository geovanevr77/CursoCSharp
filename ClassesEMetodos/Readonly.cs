using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos {

    class Readonly {
        public static void Executar() {

            var novoCliente = new Cliente("Ana Silva", new DateTime(1987, 5, 22));
            Console.WriteLine(novoCliente.Nome);
            Console.WriteLine(novoCliente.GetDataDeNascimneto());
        }
    }

    class Cliente {

        public string Nome;

        readonly DateTime Nascimento; //Readonly - é somente possivel set o valor no construtor. / é utilizado para não alterar o valor 
        //em outro momento do código.

        public Cliente(string nome, DateTime nascimento) {
            Nome = nome;
            Nascimento = nascimento;
        }

        public string GetDataDeNascimneto() {
            return string.Format("{0}/{1}/{2}", Nascimento.Day, Nascimento.Month, Nascimento.Year);
        }

       
}
    }
