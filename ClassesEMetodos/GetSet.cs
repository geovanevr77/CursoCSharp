using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace CursoCSharp.ClassesEMetodos {

    //Set - serve para alterar o atributo
    //Get - serve para ler o valor do atributo

    public class Moto {

        private string Marca;
        private string Modelo;
        private uint Cilindrada;

        public Moto(string marca, string modelo, uint cilindrada) {

            /*Marca = marca;
            Modelo = modelo;
            Cilindrada = cilindrada*/

            SetMarca(marca);
            SetModelo(modelo);
            SetCilindrada(cilindrada);
        }
        public Moto() { }

        //MARCA
        public string GetMarca() {
            return Marca;
        }
        public void SetMarca(string marca) {
            Marca = marca;
        }

        //MODELO
        public string GetModelo() {
            return Modelo;
        }
        public void SetModelo(string modelo) {
            Modelo = modelo;
        }

        //CILINDRADA
        public uint GetCilindrada() {
            return Cilindrada;
        }
        public void SetCilindrada(uint cilindrada) {
            // Primeira opção
            //if(cilindrada > 0){
            // Cilindrada = cilindrada;
            // }
           
            //Segunda opção
            //Cilindrada = Math.Abs(cilindrada);

            //Terceira opção - usando de vez o int, usa-se uint(somente valor positivo)

            Cilindrada = cilindrada;
        }
    }


        class GetSet {

            public static void Executar() {

            var moto1 = new Moto("Kawasaki", "Ninja ZX-6R", 636);
            Console.WriteLine(moto1.GetMarca());
            Console.WriteLine(moto1.GetModelo());
            Console.WriteLine(moto1.GetCilindrada());


            var moto2 = new Moto();
            moto2.SetMarca("Honda");
            moto2.SetModelo("CG Titan");
            moto2.SetCilindrada(150);
            Console.WriteLine(moto2.GetMarca()+" "+moto2.GetModelo()+" "+moto2.GetCilindrada());
        }
        }
    
}
