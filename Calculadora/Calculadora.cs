﻿using System;
namespace Calculadora
{
    public class Calculadora
    {
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

        private static long Somar(Operacoes operacao)
        {
            return operacao.ValorA + operacao.ValorB;
        }

        private static long Subtrair(Operacoes operacao)
        {
            return operacao.ValorA - operacao.ValorB;
        }

        private static long Multiplicar(Operacoes operacao)
        {
            return operacao.ValorA * operacao.ValorB;
        }

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
