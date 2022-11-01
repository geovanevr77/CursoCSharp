using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos {
    internal class VariaveisEConstantes {
        public static void Executar() {
            //area da circunferencia
            double raio = 4.5;
            const double PI = 3.14;

            raio = 5.5;
            //PI = 3.1415;

            double area = PI * raio * raio;
            Console.WriteLine(area);
            Console.WriteLine("A área é: " + area);

            //Tipos inteiros
            bool estaChovendo = true;
            Console.WriteLine("Está chovendo " + estaChovendo);

            bool naoEstaChovendo = false;
            Console.WriteLine("Não está chovendo " + naoEstaChovendo);

            byte idade = 45;
            Console.WriteLine("A idade é de: " + idade);

            sbyte saldoDeGols = sbyte.MinValue;
            Console.WriteLine("Saldo de Gols " + saldoDeGols);

            short salario = short.MaxValue;
            Console.WriteLine("Salario é de: " + salario);

            int menorValorInt = int.MinValue; //Esse é o mais usado dos numeros inteiros; Valores com sinal
            Console.WriteLine("Menor int: " + menorValorInt);

            uint populaçaoBrasileira = 207_600_000; //valores sem sinal (inteiros)
            Console.WriteLine("Qual é a população do Brasil: " + populaçaoBrasileira);

            long menosValorLong = long.MinValue;
            Console.WriteLine("Menor valor de long: " + menosValorLong);

            ulong populaçãoMundial = 7_600_000_000;
            Console.WriteLine("A população mundial é de: " + populaçãoMundial);

            float preçoComputador = 1299.99f;
            Console.WriteLine("O preço do computador é de: " + preçoComputador);

            double preçoDeMercadoDaApple = 1_000_000_000_000.00;  //mais usado em real;
            Console.WriteLine("O preço de mercado da Apple é de: " + preçoDeMercadoDaApple);

            decimal distanciaEntreEstrelas = decimal.MaxValue;
            Console.WriteLine("Distância entre estrelas é de: " + distanciaEntreEstrelas);


            char letra = 'B';
            Console.WriteLine("Letra " + letra);

            string texto = "Seja bem vindo ao curso de C#";
            Console.WriteLine(texto);



        }
    }
}
