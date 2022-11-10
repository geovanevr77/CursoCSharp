using System;
using System.Collections.Generic;
using CursoCSharp.Fundamentos;
using CursoCSharp.EstruturasDeControle;
using CursoCSharp.ClassesEMetodos;
using CursoCSharp.Colecoes;
using CursoCSharp.OO;
using CursoCSharp.MetodosEFuncoes;

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
                {"Metodos com Retorno - Classes e Metodos", MetodosComRetorno.Executar},
                {"Metodos Estáticos - Classes e Metodos", MetodosEstaticos.Executar},
                {"Atributos Estáticos - Classes e Metodos", AtributosEstaticos.Executar},
                {"Desafio Atribúto - Classes e Metodos", DesafioAtributo.Executar},
                {"Params - Classes e Metodos", Params.Executar},
                {"Parametros Nomeados - Classes e Metodos", ParametrosNomeados.Executar},
                {"Get and Set - Classes e Metodos", GetSet.Executar},
                {"Props - Classes e Metodos", Props.Executar},
                {"Readonly - Classes e Metodos", Readonly.Executar},
                {"Exemplo Enum - Classes e Metodos", ExemploEnum.Executar},
                {"Struct - Classes e Metodos", ExemploStruct.Executar},
                {"Struct vs Classe - Classes e Metodos", StructVsClasse.Executar},
                {"Valor vs Referência - Classes e Metodos", ValorVsReferencia.Executar},
                {"Parametro por Referência - Classes e Metodos", ParametrosPorReferencia.Executar},
                {"Parametro Padrão - Classes e Metodos", ParametroPadrao.Executar},
                

                //Coleções
                {"Array - Coleções", Colecoes.Array.Executar},
                {"Lista- Coleções", ColecoesList.Executar},
                {"Array List- Coleções", ColecoesArrayList.Executar},
                {"Set - Coleções", ColecoesSet.Executar},
                {"Queue - Coleções", ColecoesQueue.Executar},
                {"Igualdade - Coleções", Igualdade.Executar},
                {"Stack - Coleções", ColecoesStack.Executar},
                {"Dictionary - Coleções", ColecoesDictionary.Executar},
                 
                
                //Orientação a Objeto
                {"Herança - OO", Heranca.Executar},
                {"Construtor This - OO", ConstrutorThis.Executar},
                {"Encapsulamento - OO", OO.Encapsulamento.Executar},
                {"Polimorfismo - OO", Polimorfismo.Executar},
                {"Abstract - OO", Abstract.Executar},                
                {"Interface - OO", Interface.Executar},
                {"Sealed - OO", Sealed.Executar},

                //Metodos e Funções
                {"Exemplo Lambda - Metodos e Funções", ExemploLambda.Executar},
                {"Lambdas como Delegates - Metodos e Funções", LambdasDelegate.Executar},
                {"Usando Delegates - Metodos e Funções", UsandoDelegates.Executar},
                {"Delegates como Função Anonima - Metodos e Funções", DelegateFunAnonima.Executar},
                {"Delegates como Parametros - Metodos e Funções", DelegatesComoParametros.Executar},
                {"Metodos de Extensão - Metodos e Funções", MetodosDeExtensao.Executar},


            });
            central.SelecionarEExecutar();
        }
    }
}