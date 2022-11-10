using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos {

    public class Dependente {

        public string Nome;
        public int Idade;
    }
    class ValorVsReferencia {

        public static void Executar() {
           
            
            //Struct
            Console.WriteLine("Struct - Atribuição por valor");
            int numero = 3;
            int copiaNumero = numero;
            Console.WriteLine($"{numero} | {copiaNumero}");
        
            numero++;
            Console.WriteLine($"{numero} | {copiaNumero}");
            Console.WriteLine("______________________________");

            
            
            //Class
            Console.WriteLine("Class - Atribuição por referencia");
            Dependente dep = new Dependente {
                Nome = "Beto",
                Idade = 20
            };
            
            Dependente copiaDep = dep;
            Console.WriteLine($"{dep.Nome} | {copiaDep.Nome}");
            Console.WriteLine($"{dep.Idade} | {copiaDep.Idade}");

            copiaDep.Nome = "Renato";
            dep.Idade = 21;
            Console.WriteLine($"{dep.Nome} | {copiaDep.Nome}");
            Console.WriteLine($"{dep.Idade} | {copiaDep.Idade}");
        }
    }
}
