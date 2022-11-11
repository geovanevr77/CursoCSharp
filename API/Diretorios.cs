﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace CursoCSharp.API {
    class Diretorios {
        public static void Executar() {
            var novoDir = @"~/PastaCsharp".ParseHome();
            var novoDirDestino = @"~/PastaCsharpDestino".ParseHome();
            var dirProjeto = @"~/source/repos/CursoCSharp/CursoCsharp".ParseHome();

            if (Directory.Exists(novoDir)) {
                Directory.Delete(novoDir, true);
            }

            if (Directory.Exists(novoDirDestino)) {
                Directory.Delete(novoDirDestino, true);
            }
            Directory.CreateDirectory(novoDir);
            Console.WriteLine(Directory.GetCreationTime(novoDir));

            Console.WriteLine("== Pastas ======================");
            var pastas = Directory.GetDirectories(dirProjeto);
            foreach (var pasta in pastas) {
                Console.WriteLine(pasta);
            }

            Console.WriteLine("/n/n == Arquivos ============");
            var arquivos = Directory.GetFiles(dirProjeto);
            foreach (var arquivo in arquivos) {
                Console.WriteLine(arquivo);
            }

            Console.WriteLine("/n/n == Arquivos ============");
            Console.WriteLine(Directory.GetDirectoryRoot(novoDir));

            Directory.Move(novoDir, novoDirDestino); 
        }
    }
}
