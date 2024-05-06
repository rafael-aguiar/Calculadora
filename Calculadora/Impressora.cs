using System;
using System.Collections.Generic;

namespace Calculadora
{
    public class Impressora
    {
        /// <summary>
        /// Imprime todas as operações na fila de operações.
        /// </summary>
        /// <param name="fila">A fila de operações a ser impressa.</param>
        public static void ImprimirFila(Queue<Operacoes> fila)
        {
            if (!ValidaFila(fila)) return;

            ImprimirSeparador();
            ImprimirMensagemOperacoesPendentes();
            ImprimirOperacoes(fila);
            ImprimirSeparador();

        }

        public static void ImprimirOperacaoAtual(Operacoes operacao)
        {
            ImprimirMensagemOperacaoAtual();
            Console.WriteLine("{0} {1} {2} = {3}", operacao.valorA, operacao.operador, operacao.valorB, operacao.resultado);
        }

        /// <summary>
        /// Verifica se a fila de operações está vazia e imprime uma mensagem caso esteja.
        /// </summary>
        /// <param name="fila">A fila a ser validada.</param>
        /// <returns>True se a fila não estiver vazia, False caso contrário.</returns>
        private static bool ValidaFila(Queue<Operacoes> fila)
        {
            if (fila.Count == 0)
            {
                ImprimirSeparador();
                ImprimirMensagemNenhumaOperacao();
                return false;
            }
            return true;
        }

        /// <summary>
        /// Imprime uma mensagem para operações pendentes na fila.
        /// </summary>
        private static void ImprimirMensagemOperacoesPendentes()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Próximas operações na fila:");
            Console.ResetColor();
        }

        /// <summary>
        /// Imprime uma mensagem para a operação que está sendo processada.
        /// </summary>
        private static void ImprimirMensagemOperacaoAtual()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Operação atual:");
            Console.ResetColor();
        }

        /// <summary>
        /// Imprime uma mensagem indicando que não há mais operações na fila.
        /// </summary>
        private static void ImprimirMensagemNenhumaOperacao()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Não há mais operações na fila.");
            Console.ResetColor();
        }

        /// <summary>
        /// Imprime todas as operações na fila.
        /// </summary>
        /// <param name="fila">A fila de operações.</param>
        private static void ImprimirOperacoes(Queue<Operacoes> fila)
        {
            foreach (Operacoes operacao in fila)
            {

                Console.WriteLine("{0} {1} {2}", operacao.valorA, operacao.operador, operacao.valorB);
            }
        }

        /// <summary>
        /// Imprime um separador para melhor visualização.
        /// </summary>
        private static void ImprimirSeparador()
        {
            Console.WriteLine(new string('-', 40));
        }
    }
}