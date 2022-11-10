using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.OO {
    //Abstract - não consigo instanciar
    public abstract class Celular {
        public abstract string Assistente();

        public string Tocar() {
            return "Trim trim...";
        }
    }

    public class Samsung : Celular {
        public override string Assistente() {
            return "Olá! Meu nome é Bixby";
        }
    }

    public class Iphone : Celular {
        public override string Assistente() {
            return "Olá! Meu nome é Siri";
        }
    }
    public class Motorola : Celular {
        public override string Assistente() {
            return "Olá! Meu nome é Motomoto";
        }
    }


    class Abstract {
        public static void Executar() {
            /* Console.WriteLine("Samsung:");
             Samsung sam = new Samsung();
             Console.WriteLine(sam.Tocar());
             Console.WriteLine(sam.Assistente());

             Console.WriteLine("Iphone: ");
             var celular = new Iphone();
             Console.WriteLine(celular.Tocar());
             Console.WriteLine(celular.Assistente());*/

            var celulares = new List<Celular>() {
            new Iphone(),
            new Samsung(),
            new Motorola()
        };

            foreach (var celular in celulares) {
                Console.WriteLine(celular.Assistente());


            }
        }
    }
}
