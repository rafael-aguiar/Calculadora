using System;
namespace Calculadora
{
    public class Calculadora
    {
        /// <summary>
        /// Realiza a operação
        /// </summary>
        /// <param name="operacao">A operação que será realizada.</param>
        public Operacoes Calcular(Operacoes operacao)
        {
            switch (operacao.Operador)
            {
                case '+':
                    operacao.Resultado = Somar(operacao);
                    break;
                case '-':
                    operacao.Resultado = Subtrair(operacao);
                    break;
                case '*':
                    operacao.Resultado = Multiplicar(operacao);
                    break;
                case '/':
                    operacao.Resultado = Dividir(operacao);
                    break;
                default:
                    operacao.Resultado = 0;
                    break;
            }
            return operacao;
        }

        /// <summary>
        /// Realiza a soma entre o Valor A e o Valor B.
        /// </summary>
        /// <param name="operacao">A operação que será realizada.</param>
        private static long Somar(Operacoes operacao)
        {
            return operacao.ValorA + operacao.ValorB;
        }

        /// <summary>
        /// Realiza a subtração entre o Valor A e o Valor B.
        /// </summary>
        /// <param name="operacao">A operação que será realizada.</param>
        private static long Subtrair(Operacoes operacao)
        {
            return operacao.ValorA - operacao.ValorB;
        }

        /// <summary>
        /// Realiza a multiplicação entre o Valor A e o Valor B.
        /// </summary>
        /// <param name="operacao">A operação que será realizada.</param>
        private static long Multiplicar(Operacoes operacao)
        {
            return operacao.ValorA * operacao.ValorB;
        }

        /// <summary>
        /// Realiza a divisão entre o Valor A e o Valor B.
        /// Retorna uma exception em caso do dividendo ser zero.
        /// </summary>
        /// <param name="operacao">A operação que será realizada.</param>
        private static long Dividir(Operacoes operacao)
        {
            if (operacao.ValorB == 0)
            {
                throw new DivideByZeroException("Não é possível dividir por zero.");
            }
            return operacao.ValorA / operacao.ValorB;
        }
    }

}
