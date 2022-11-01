﻿using System;
using System.Globalization;

namespace CursoCSharp.Fundamentos {
    internal class FormatandoNumeros {
        public static void Executar() {

            double valor = 15.175;
            Console.WriteLine(valor.ToString("F1"));
            Console.WriteLine(valor.ToString("C"));
            Console.WriteLine(valor.ToString("P"));
            Console.WriteLine(valor.ToString("#.##"));

            CultureInfo culture = new CultureInfo("en-US");
            Console.WriteLine(valor.ToString("c3", culture));

            int inteiro = 256;
            Console.WriteLine(inteiro.ToString("D10"));
        }
    }
}
