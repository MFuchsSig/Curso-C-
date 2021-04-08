using System;
using tabuleiro;
using xadrez;
namespace Xadrez_console
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                PartidaDeXadrez partida = new PartidaDeXadrez();

                while (!partida.terminada)
                {
                    try
                    {
                        Console.Clear();
                        Tela.ImprimirPartida(partida);
                        Console.WriteLine();
                        Console.Write("Digite a posição de origem :");
                        Posicao origem = Tela.lerPosicaoXadrez().toPosicao();
                        partida.validarPosicaoDeOrigem(origem );

                        bool[,] posicoesPossivies = partida.tab.peca(origem).movimentosPossiveis();

                        Console.Clear();
                        Tela.imprimirTabuleiro(partida.tab, posicoesPossivies);
                        Console.WriteLine();
                        Console.Write("Digite a posição de destino :");
                        Posicao destino = Tela.lerPosicaoXadrez().toPosicao();

                        partida.validarPosicaoDeDestino( origem ,destino);
                        partida.realizaJogada(origem, destino);
                    }
                    catch(TabuleiroExecption e)
                    {
                        Console.WriteLine(e.Message);
                        Console.ReadLine();
                    }
                }
                Console.Clear();
                Tela.ImprimirPartida(partida);

            }
            catch (TabuleiroExecption e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadLine();
        }
           
        }
        
    }

