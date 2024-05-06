using System;
using System.Collections;
using System.Collections.Generic;

namespace Calculadora
{
    class Program
    {
        /// <summary>
        /// Inicia o progama montando a fila de operações e iniciando o processamento.
        /// </summary>
        static void Main()
        {
            Queue<Operacoes> filaOperacoes = InicializarFila();
            ProcessarOperacoes(filaOperacoes);
        }


        /// <summary>
        /// Monta a fila de operações.
        /// </summary>
        private static Queue<Operacoes> InicializarFila()
        {
            return new Queue<Operacoes>(new[]
            {
            new Operacoes { ValorA = 2, ValorB = 3, Operador = '+' },
            new Operacoes { ValorA = 14, ValorB = 8, Operador = '-' },
            new Operacoes { ValorA = 5, ValorB = 6, Operador = '*' },
            new Operacoes { ValorA = 2147483647, ValorB = 2, Operador = '+' },
            new Operacoes { ValorA = 18, ValorB = 3, Operador = '/' }
        });
        }

        /// <summary>
        /// Inicia o processamento da fila de operações.
        /// </summary>
        /// <param name="filaOperacoes">A fila de operações.</param>
        private static void ProcessarOperacoes(Queue<Operacoes> filaOperacoes)
        {
            Stack<Operacoes> stackResultados = new();
            Calculadora calculadora = new();

            while (filaOperacoes.Count > 0)
            {
                Operacoes operacaoAtual = filaOperacoes.Dequeue();
                calculadora.Calcular(operacaoAtual);

                Impressora.ImprimirOperacaoAtual(operacaoAtual);
                Impressora.ImprimirFila(filaOperacoes);

                stackResultados.Push(operacaoAtual);
            }

            Impressora.ImprimirStackResultados(stackResultados);
        }
    }
}
