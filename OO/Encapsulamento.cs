﻿using System;
using System.Collections.Generic;
using System.Text;
using Encapsulamento;


namespace CursoCSharp.OO {

    public class FilhoNaoReconhecido : SubCelebridade 
    {
        public new void MeusAcessos() {
            Console.WriteLine("Filho não reconhecido...");

            Console.WriteLine(InfoPublica);
            Console.WriteLine(CordoOlho);
            //Console.WriteLine(NumeroCelular);
            Console.WriteLine(JeitoDeFalar);
            //Console.WriteLine(SegredoFamilia);
            //Console.WriteLine(UsaMuitoPhotoshop);
        }
    }

    public class AmigoDistante 
    {
        public readonly SubCelebridade amiga = new SubCelebridade();

        public void MeusAcessos() {
            Console.WriteLine("Amigo Distante");

            Console.WriteLine(amiga.InfoPublica);
            //Console.WriteLine(amiga.CordoOlho);
            //Console.WriteLine(amiga.NumeroCelular);
            //Console.WriteLine(amiga.JeitoDeFalar);
            //Console.WriteLine(amiga.SegredoFamilia);
            //Console.WriteLine(amiga.UsaMuitoPhotoshop);
        }
    }

    class Encapsulamento {

        public static void Executar() {

            SubCelebridade sub = new SubCelebridade();
            sub.MeusAcessos();

            new FilhoReconhecido().MeusAcessos();
            new AmigoProximo().MeusAcessos();

            new FilhoNaoReconhecido().MeusAcessos();
            new AmigoDistante().MeusAcessos();           
        }
    }
}
