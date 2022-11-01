﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.EstruturasDeControle {
    internal class EstruturaForeach {
        public static void Executar() {
            var palavra = "opa!";
            foreach (var letra in palavra) {
                Console.WriteLine(letra);
            }

            var alunos = new string[] { "Ana", "Bia", "Carlos" };

            foreach (string aluno in alunos) {
                Console.WriteLine(aluno);
            }

        }
    }
}
