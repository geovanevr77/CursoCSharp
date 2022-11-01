﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.EstruturasDeControle {
    internal class EstruturaSwitch {
        public static void Executar() {
            Console.WriteLine("Avalie meu atendimento com uma nota de 1 a 5: ");
            int.TryParse(Console.ReadLine(), out int nota);

            switch (nota) {
                case 0:
                    Console.WriteLine("Péssimo");
                    break;

                case 1:
                case 2:
                    Console.WriteLine("Ruim");
                    break;
                    
                case 3:
                    Console.WriteLine("Regular");
                    break;

                case 4:
                    Console.WriteLine("Bom");
                    break;

                case 5:
                    Console.WriteLine("Excelente");
                    break;
                default: {
                        Console.WriteLine("Nota inválida");
                       
                        if (nota >= 6) {
                            Console.WriteLine("Tente novamente.");
                        }
                        break;
                    }
            }

                    Console.WriteLine("Obrigado por avaliar, sua avaliação é muito importante.");



                    
                
            
        }
    }
}
