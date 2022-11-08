using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace CursoCSharp.ClassesEMetodos {

    public class Produto {
        public string Nome;
        public double Preco;
        public static double Desconto = 0.1;

        public Produto(string nome, double preco, double desconto) {
            Nome = nome;
            Preco = preco;
            Desconto = desconto;
        }
        public Produto() { }

        public double CalcularDesconto() {
            return Preco - (Preco * Desconto);
        }

    }

    class AtributosEstaticos {

        public static void Executar() {

            var Produto1 = new Produto("Caneta", 3.2, 0.1);

            var Produto2 = new Produto() {
                Nome = "Borracha",
                Preco = 5.3,
                //Desconto = 0.1
            };

            Console.WriteLine("Preço com desconto: "+Produto1.CalcularDesconto());
            Console.WriteLine("Preço com desconto: " + Produto2.CalcularDesconto());

            Produto.Desconto = 0.5;


        }
    }
}
