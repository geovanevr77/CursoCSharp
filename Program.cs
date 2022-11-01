using System;
using System.Collections.Generic;

using CursoCSharp.Fundamentos;
using CursoCSharp.EstruturasDeControle;
using CursoCSharp. ClassesEMetodos;
using CursoCSharp.OO;

namespace CursoCSharp {
    class Program {
        static void Main(string[] args) {
            var central = new CentralDeExercicios(new Dictionary<string, Action>() {
               
                //FUNDAMENTOS
                
                {"Primeiro Programa - Fundamentos", PrimeiroPrograma.Executar},
                {"Comentarios - Fundamentos", Comentarios.Executar},
                {"Variaveis e Constantes - Fundamentos", VariaveisEConstantes.Executar},
                {"Inferencia - Fundamentos", Inferencia.Executar},
                {"Interpolação - Fundamentos", Interpolação.Executar},
                {"Notação Ponto - Fundamentos", NotaçaoPonto.Executar},
                {"Lendo Dados - Fundamentos", LendoDados.Executar},
                {"Formatando Numeros - Fundamentos", FormatandoNumeros.Executar},
                {"Conversoes - Fundamentos", Conversoes.Executar},
                {"Operadores Aritmeticos - Fundamentos", OperadoresAritmeticos.Executar},
                {"Operadores Relacionais - Fundamentos", OperadoresRelacionais.Executar},
                {"Operadores Lógicos - Fundamentos", OperadoresLogicos.Executar},
                {"Operadores de Atribuição - Fundamentos", OperadoresDeAtribuição.Executar},
                {"Operadores Unários - Fundamentos", OperadoresUnarios.Executar},
                {"Operadores Ternários - Fundamentos", OperadorTernario.Executar},

                //ESTRUTURAS DE CONTROLE
                
                {"Estrutura IF - Estrutura de Controle", EstruturaIf.Executar},
                {"Estrutura IF/ELSE - Estrutura de Controle", EstruturaIfElse.Executar},
                {"Estrutura IF/ELSEIF - Estrutura de Controle", EstruturaIfElseIf.Executar},
                {"Estrutura SWITCH - Estrutura de Controle", EstruturaSwitch.Executar},
                {"Estrutura WHILE - Estrutura de Controle", EstruturaWhile.Executar},
                {"Estrutura DO WHILE - Estrutura de Controle", EstruturaDoWhile.Executar},
                {"Estrutura FOR - Estrutura de Controle", EstruturaFor.Executar},
                {"Estrutura FOREACH - Estrutura de Controle", EstruturaForeach.Executar},

                //Classes e Métodos

                {"Membros - Classes e Metodos", Membros.Executar},
                {"Construtores - Classes e Metodos", Construtores.Executar},





            });
            central.SelecionarEExecutar();
        }
    }
}