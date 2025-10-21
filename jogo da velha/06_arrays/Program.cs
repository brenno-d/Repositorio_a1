using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace _06_arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char[,] chars = new char[3, 3];
            int escolha;
            int i = 0, c = 0, l = 0;
            bool vit = false, escolhido = false;
            //preenchendo os números com 1-9
            for (l = 0; l < 3; l++)
            {
                for (c = 0; c < 3; c++)
                {
                    chars[l, c] = Convert.ToChar(Convert.ToString(i + 1));
                    i++;
                }
            }
            i = 0;
            do
            {
                //exibindo os números na tela como tabela
                for (l = 0; l < 3; l++)
                {
                    for (c = 0; c < 3; c++)
                    {
                        Console.Write(chars[l, c]);
                        if (c >= 0 && c < 2)
                        {
                            Console.Write("|");
                        }

                    }
                    Console.WriteLine();
                    Console.WriteLine("------");
                }
                    if (i % 2 == 0)
                    {
                        do
                        {

                            Console.WriteLine("Jogador 1(X)\n Digite o número para jogar");
                            escolha = int.Parse(Console.ReadLine());
                            if (escolha > 0 && escolha <= 3)
                            //verifica se ja não foi pego
                            {
                                if (chars[0, escolha - 1] == Char.Parse("O") || chars[0, escolha - 1] == Char.Parse("X"))
                                {
                                    Console.WriteLine("Já selecionado o local");
                                    escolhido = true;
                                }
                                //se nao foi, coloca o valor
                                else
                                {
                                    chars[0, escolha - 1] = 'X';
                                    escolhido = false;
                                }
                            }
                            if (escolha > 3 && escolha <= 6)
                            //verifica se ja não foi pego
                            {
                                if (chars[1, (escolha -4) ] == Char.Parse("O") || chars[1, (escolha-4)] == Char.Parse("X"))
                                {
                                    Console.WriteLine("Já selecionado o local");
                                    escolhido = true;
                                }
                                //se nao foi, coloca o valor
                                else
                                {
                                    chars[1, escolha-4 ] = 'X';
                                    escolhido = false;
                                }
                            }
                            if (escolha > 6 && escolha <= 9)
                            //verifica se ja não foi pego
                            {
                                if (chars[2, escolha -7] == Char.Parse("O") || chars[2, escolha -7] == Char.Parse("X"))
                                {
                                    Console.WriteLine("Já selecionado o local");
                                    escolhido = true;
                                }
                                //se nao foi, coloca o valor
                                else
                                {
                                    chars[2, escolha -7] = 'X';
                                    escolhido = false;
                                }
                            }
                        }
                        while (escolhido == true);
                    Console.Clear();
                }
                    else
                    {
                    do
                    {

                        Console.WriteLine("Jogador 2(O)\n Digite o número para jogar");
                        escolha = int.Parse(Console.ReadLine());
                        if (escolha > 0 && escolha <= 3)
                        //verifica se ja não foi pego
                        {
                            if (chars[0, escolha - 1] == Char.Parse("O") || chars[0, escolha - 1] == Char.Parse("X"))
                            {
                                Console.WriteLine("Já selecionado o local");
                                escolhido = true;
                            }
                            //se nao foi, coloca o valor
                            else
                            {
                                chars[0, escolha - 1] = 'O';
                                escolhido = false;
                            }
                        }
                        if (escolha > 3 && escolha <= 6)
                        //verifica se ja não foi pego
                        {
                            if (chars[1, escolha-4] == Char.Parse("O") || chars[1, escolha -4] == Char.Parse("X"))
                            {
                                Console.WriteLine("Já selecionado o local");
                                escolhido = true;
                            }
                            //se nao foi, coloca o valor
                            else
                            {
                                chars[1, escolha-4] = 'O';
                                escolhido = false;
                            }
                        }
                        if (escolha > 6 && escolha <= 9)
                        //verifica se ja não foi pego
                        {
                            if (chars[2, escolha  -7] == Char.Parse("O") || chars[2, escolha -7] == Char.Parse("X"))
                            {
                                Console.WriteLine("Já selecionado o local");
                                escolhido = true;
                            }
                            //se nao foi, coloca o valor
                            else
                            {
                                chars[2, escolha-7] = 'O';
                                escolhido = false;
                            }
                        }
                    }
                    while (escolhido == true);
                    Console.Clear();
                }
                //verifica se houve vitória ou empate
                i++;
                if (i == 9)
                {
                    Console.WriteLine("DEU VELHA!!");
                    vit = true;
                }
                if (VerificarVitoria(chars) == 'X')
                {
                    Console.WriteLine("JOGADOR 1(X) GANHOU PARABÉNS!!");
                    vit = true;
                }
                if (VerificarVitoria(chars) == 'O')
                {
                    Console.WriteLine("JOGADOR 2 (O) GANHOU PARABÉNS!!");
                    vit = true;
                }
            }
            while (vit == false);
            Console.WriteLine("Aperte qualquer tecla para sair");
            Console.ReadKey();
        }
        static char VerificarVitoria(char[,] chars)
        {
            int l, c;
            //verifica as linhas
            for ( l = 0; l < 3; l++)
                if (chars[l, 0] == chars[l, 1] && chars[l, 1] == chars[l, 2])
                    return chars[l,0];

            // verifica as colunas
            for (c = 0; c < 3; c++)
                if (chars[0, c] == chars[1, c] && chars[1, c] == chars[2, c])
                    return (chars[0,c]);

            // verifica as diagonais
            if (chars[0, 0] == chars[1, 1] && chars[1, 1] == chars[2, 2])
                return chars[0,0];

            if (chars[0, 2] == chars[1, 1] && chars[1, 1] == chars[2, 0])
                return chars[0,2];

            return 'z';
        }
    }
}