using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace CursoCSharp.OO {

    public class Animal {
        public string Nome { get; set; }

        public Animal(string nome) {
            Nome = nome;
        }
    }
    public class Cachorro : Animal {
        public double Altura { get; set; }

        public Cachorro(string nome) : base(nome) //base(nome) - ele recebe o construtor base da Class Pai(Animal)
        {
            Console.WriteLine("Cachorro: "+nome+" inicializado.");
        }
        //pelo menos um dos construtores precisa chamar a class base pai
        public Cachorro(string nome, double altura) : this(nome) //this(nome) - chamando o construtor de Cachorro
        {
           Altura = altura;       
        }

        public override string ToString() //ToString() - responsavel por transformar uma instancia em uma string
        {
            return $"{Nome} tem {Altura}cm de altura!";
        }

    }
    class ConstrutorThis {
        public static void Executar() {

            var spike = new Cachorro("spike");
            var max = new Cachorro("max", 40.0);

            Console.WriteLine(spike);
            Console.WriteLine(max);
        }
    }
}
