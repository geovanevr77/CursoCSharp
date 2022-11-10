﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.OO {
    class Interface {
        public static void Executar() {
            var calc = new Calculadora();
            var resultado = calc.ExecutarOperacoes(20, 5);
            Console.WriteLine(resultado);
        }
    }

    interface OperacaoBinaria {
    }

    class Soma : OperacaoBinaria {
        public int Operacao(int a, int b) {
            return a + b;
        }
    }

    class Subtracao : OperacaoBinaria {
            public int Operacao(int a, int b) {
                return a - b;
            }
    }
    class Multiplicacao : OperacaoBinaria {
            public int Operacao(int a, int b) {
                return a * b;
            }
    }

    class Divisao : OperacaoBinaria {
            public int Operacao(int a, int b) {
                return a / b;
            }
    }

    class Calculadora {
        List<OperacaoBinaria> operacoes = new List<OperacaoBinaria> {
            new Soma(),
            new Subtracao(),
            new Multiplicacao(),
            new Divisao(),
        };

        public string ExecutarOperacoes(int a, int b) {
            string resultado = "";
            
            foreach (var op in operacoes) {
                resultado += $"Usando {op.GetType().Name} = {(a, b)}";
            }
            return resultado;
        }
    }

   
}
