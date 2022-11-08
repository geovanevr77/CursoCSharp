using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Text;

namespace CursoCSharp.ClassesEMetodos {

    public class CarroOpcional {

        private double desconto = 0.1;
        private string nome;

        //Implementação
        //Propriedade
        public string Nome {
            get { return "Opcional: " + nome; }

            set { nome = value; }
        }

        //Propriedades autoimplementadas

        public double Preco { get; set; }

        //Somente Leitura
        public double PrecoComDesconto {
            get => Preco - (desconto * Preco);//Lambda  
            //get { return Preco - (desconto * Preco); }
        }

        public CarroOpcional() { }

        public CarroOpcional(string nome, double preco) {
            Nome = nome;
            Preco = preco;
        }

    }


    class Props {
        public static void Executar() {

            Console.WriteLine("___________________________");

            var op1 = new CarroOpcional("Ar condicionado", 3499.90);
            Console.WriteLine(op1.Nome);
            Console.WriteLine("Valor: "+op1.Preco);
            Console.WriteLine("Valor com desconto: "+op1.PrecoComDesconto);


            Console.WriteLine("___________________________");


            var op2 = new CarroOpcional();
            op2.Nome = "Direção Elétrica";
            op2.Preco = 2349.90;
            Console.WriteLine(op2.Nome);
            Console.WriteLine("Valor: "+op1.Preco);
            Console.WriteLine("Valor com desconto: "+op2.PrecoComDesconto);

            Console.WriteLine("___________________________");
        } 
    }
}
