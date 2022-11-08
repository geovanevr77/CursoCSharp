using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos {

    class MetodosComRetorno {
        public static void Executar() {

            var CalculadoraComum = new CalculadoraComum();
            var resultado = CalculadoraComum.Somar(5, 5);
            Console.WriteLine("O reultado é: " + resultado);

            var resultado2 = CalculadoraComum.Subtrair(5, 5);
            Console.WriteLine("O reultado é: " + resultado2);

            var resultado3 = CalculadoraComum.Multiplicar(5, 5);
            Console.WriteLine("O reultado é: " + resultado3);

            var resultado4 = CalculadoraComum.Dividir(5, 5);
            Console.WriteLine("O reultado é: " + resultado4);
            Console.WriteLine("___________________________________________________________");


            var CalculadoraCadeia = new CalculadoraCadeia();
            CalculadoraCadeia.Somar(3).Multiplicar(9).Dividir(3).Subtrair(2).Imprimir().Limpar().Imprimir();
            Console.WriteLine("___________________________________________________________");

            resultado = CalculadoraCadeia.Somar(5).Subtrair(2).Multiplicar(3).Resultado();
            Console.WriteLine("O resultado é: "+resultado);

            
        }
    }

    class CalculadoraComum {
        public int Somar(int a, int b) {
            return a + b;
        }
        public int Subtrair(int a, int b) {
            return a - b;
        }
        public int Multiplicar(int a, int b) {
            return a * b;
        }
        public double Dividir(int a, int b) {
            return a * b;
        }
   
    }

    class CalculadoraCadeia {

        int memoria;

        public CalculadoraCadeia Somar(int a) {

            memoria += a;
            return this;
        }

        public CalculadoraCadeia Subtrair(int a) {
            memoria -= a;
            return this;
        }

        public CalculadoraCadeia Multiplicar(int a) {
            memoria *= a;
            return this;
        }
        public CalculadoraCadeia Dividir(int a) {
            memoria /= a;
            return this;
        }

        public CalculadoraCadeia Limpar() {
            memoria = 0;
            return this;
        }

        public CalculadoraCadeia Imprimir() {
            Console.WriteLine("Resultado é: " + memoria);
            return this;
        }
        public int Resultado() {
            return memoria;
        }
    }
}
