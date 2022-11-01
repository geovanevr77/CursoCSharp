using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos {
    internal class Interpolação {
        public static void Executar() {

            {
                string nome = "Notbook Gamer";
                string marca = "DELL";
                double preço = 5800.00;
                //Contentar:
                Console.WriteLine(" O " + nome + " da marca " + marca
                    + " custa " + "$" + preço + ".");
                //Interpolação:
                Console.WriteLine(" O {0} da marca {1} custa {2}.", nome, marca, preço);
                //ex:
                Console.WriteLine($" Quero um {nome} de {preço}.");

            }
        }
    } 
}
