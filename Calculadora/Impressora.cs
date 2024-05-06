using System;
using System.Collections.Generic;

namespace Calculadora
{
    public class Impressora
    {
        /// <summary>
        /// Imprime todas as operações na fila.
        /// </summary>
        /// <param name="fila">A fila de operações que será impressa.</param>
        public static void ImprimirFila(Queue<Operacoes> fila)
        {
            if (!ValidarFila(fila))
                return;

            ImprimirSeparador();
            ImprimirMensagem("Próximas operações na fila:", ConsoleColor.Yellow);
            ImprimirOperacoes(fila);
            ImprimirSeparador();
        }

        /// <summary>
        /// Imprime a operação atual sendo processada.
        /// </summary>
        /// <param name="operacao">A operação atual que será impressa.</param>
        public static void ImprimirOperacaoAtual(Operacoes operacao)
        {
            ImprimirMensagem("Operação atual:", ConsoleColor.Green);
            Console.WriteLine($"{operacao.ValorA} {operacao.Operador} {operacao.ValorB} = {operacao.Resultado}");
        }

        /// <summary>
        /// Imprime todos os resultados das operações armazenadas na stack de resultados.
        /// </summary>
        /// <param name="stack">A stack de resultados que será impressa.</param>
        public static void ImprimirStackResultados(Stack<Operacoes> stack)
        {
            Console.WriteLine();
            ImprimirSeparador();
            ImprimirMensagem("Resultados das operações:", ConsoleColor.Green);

            while (stack.Count > 0)
            {
                Operacoes operacao = stack.Pop();
                Console.WriteLine($"{operacao.Resultado}");
            }

            ImprimirSeparador();
            Console.WriteLine();
        }

        /// <summary>
        /// Valida se a fila de operações está vazia e imprime uma mensagem caso esteja.
        /// </summary>
        /// <param name="fila">A fila de operações que será validada.</param>
        /// <returns>True se a fila não estiver vazia, False caso contrário.</returns>
        private static bool ValidarFila(Queue<Operacoes> fila)
        {
            if (fila.Count == 0)
            {
                ImprimirSeparador();
                ImprimirMensagem("Não há mais operações na fila.", ConsoleColor.Red);
                return false;
            }
            return true;
        }

        /// <summary>
        /// Imprime as operações na fila.
        /// </summary>
        /// <param name="fila">A fila de operações.</param>
        private static void ImprimirOperacoes(Queue<Operacoes> fila)
        {
            foreach (Operacoes operacao in fila)
            {
                Console.WriteLine($"{operacao.ValorA} {operacao.Operador} {operacao.ValorB}");
            }
        }

        /// <summary>
        /// Imprime uma mensagem formatada com uma cor especificada.
        /// </summary>
        /// <param name="mensagem">A mensagem a ser impressa.</param>
        /// <param name="cor">A cor do texto da mensagem.</param>
        private static void ImprimirMensagem(string mensagem, ConsoleColor cor)
        {
            Console.ForegroundColor = cor;
            Console.WriteLine(mensagem);
            Console.ResetColor();
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
