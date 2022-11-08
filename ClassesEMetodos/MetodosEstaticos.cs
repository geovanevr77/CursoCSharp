using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CursoCSharp.ClassesEMetodos {

    public class CalculadoraEstatica {
        public static int Somar(int a, int b) {
            return a + b;
        }
        public static int Subtrair(int a, int b) {
            return a - b;
        }
        public static int Multiplicar(int a, int b) {
            return a * b;
        }
        public int Dividir(int a, int b) {
            return a / b;
        }
    }


    class MetodosEstaticos {
        public static void Executar() {

            //com metodo estatico
            var resultado = CalculadoraEstatica.Somar(10, 8);
            Console.WriteLine("O resultado é: "+resultado);

            var resultado1 = CalculadoraEstatica.Subtrair(10, 8);
            Console.WriteLine("O resultado é: " + resultado1);

            var resultado2 = CalculadoraEstatica.Multiplicar(10, 8);
            Console.WriteLine("O resultado é: " + resultado2);

            //Sem metodo estatico
            CalculadoraEstatica cal = new CalculadoraEstatica();
            Console.WriteLine("O resultado é: "+cal.Dividir(10, 2));



        }
    }
}
