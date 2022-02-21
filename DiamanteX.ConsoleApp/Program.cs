﻿using System;

namespace DiamanteX.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region código que desenha a parte superior do diamante
            int tamanhoDiamante = 7;

            int quantidadeEspacos = (tamanhoDiamante - 1) / 2; //3

            int quantidadeDeX = 1;

            int quantidadeDeLinhas = (tamanhoDiamante - 1) / 2; //3

            for (int linha = 0; linha < quantidadeDeLinhas; linha++)
            {
                QuantidadeEspacos();

                QuantidadeX();

                quantidadeEspacos--;
                quantidadeDeX += 2;

                Console.WriteLine();
            }

            #endregion

            #region código que desenha a parte do meio do diamante

            for (int coluna = 0; coluna < tamanhoDiamante; coluna++)
            {
                Console.Write("x");
            }

            quantidadeEspacos++;
            quantidadeDeX -= 2;

            Console.WriteLine();

            #endregion

            #region código que desenha a parte de baixo do diamante

            for (int linha = 0; linha < quantidadeDeLinhas; linha++)
            {
                QuantidadeEspacos();

                QuantidadeX();

                quantidadeEspacos++;
                quantidadeDeX -= 2;

                Console.WriteLine();
            }

            #endregion

            Console.ReadLine();

        }

        static void QuantidadeX()
        {
            int quantidadeDeX = 1;
            for (int i = 0; i < quantidadeDeX; i++)
            {
                Console.Write("x");
            }
        }

        static void QuantidadeEspacos()
        {
            int tamanhoDiamante = 7;

            int quantidadeEspacos = (tamanhoDiamante - 1) / 2;

            for (int i = 0; i < quantidadeEspacos; i++) //escrever os espaços
            {
                Console.Write(" ");
            }
        }


    }
}

