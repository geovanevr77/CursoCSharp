using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.OO {

    public class Carro {
        protected readonly int VelocidadeMaxima;
        int VelocidadeAtual;

        public Carro(int velocidadeMaxima) {
            VelocidadeMaxima = velocidadeMaxima;
        }
        protected int AlterarVelocidade(int delta) {
            int novaVelodiade = VelocidadeAtual + delta;

            if (novaVelodiade < 0) {
                VelocidadeAtual = 0;
            } else if (novaVelodiade > VelocidadeMaxima) {
                VelocidadeAtual = VelocidadeMaxima;
            } else {
                VelocidadeAtual = novaVelodiade;
            }
            return VelocidadeAtual;
        }
        public int Acelerar() {
            return AlterarVelocidade(5);
        }
        public int Frear() {
            return AlterarVelocidade(-5);
        }
        public class Uno : Carro {
            public Uno() : base(200) {
            }

            public class Ferrari : Carro {
                public Ferrari() : base(350) {
                }
            }


            class Heranca {
                public static void Executar() {
                    Console.WriteLine("Uno...");
                    Uno carro1 = new Uno();
                    Console.WriteLine(carro1.Acelerar());
                    Console.WriteLine(carro1.Acelerar());
                    Console.WriteLine(carro1.Frear());
                    Console.WriteLine(carro1.Frear());

                    Console.WriteLine("Ferrari...");
                    Ferrari carro2 = new Ferrari();
                    Console.WriteLine(carro2.Acelerar());
                    Console.WriteLine(carro2.Acelerar());
                    Console.WriteLine(carro2.Frear());
                    Console.WriteLine(carro2.Frear());

                }
            }
        }
    }
}
