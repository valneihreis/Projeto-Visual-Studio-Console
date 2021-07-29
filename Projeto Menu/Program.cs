using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Menu
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcao = 0;

            while (opcao != 4)
            {
                // Carrega o método MontaTela
                MontaTela();

                Console.SetCursorPosition(03, 05);
                Console.WriteLine("Menu de opções");
                Console.SetCursorPosition(03, 06);
                Console.WriteLine("Escolha entre as opções abaixo um número para executar");
                Console.SetCursorPosition(03, 07);
                Console.WriteLine("o procedimento escolhido.");

                Console.SetCursorPosition(25, 10);
                Console.WriteLine("1 - Calculadora");
                Console.SetCursorPosition(25, 11);
                Console.WriteLine("2 - Iniciar Vendas");
                Console.SetCursorPosition(25, 12);
                Console.WriteLine("3 - Consultar Vendas");
                Console.SetCursorPosition(25, 13);
                Console.WriteLine("4 - Sair");

                Console.SetCursorPosition(25, 16);
                Console.WriteLine("Digite a opção desejada :");
                Console.SetCursorPosition(52, 16);
                opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        {
                            Calculadora();
                            break;
                        }

                    case 2:
                        {
                            IniciarVendas();
                            break;
                        }
                    case 3:
                        {
                            ConsultarVendas();
                            break;
                        }
                    case 4:
                        {
                            Environment.Exit(0);
                            break;
                        }
                }

                Console.ReadKey();
            }
        }
        

        static void Calculadora()
        {
            MontaTela();
            Console.SetCursorPosition(03,05);
            Console.WriteLine("Você escolheu o módulo calculadora");

            Console.SetCursorPosition(03, 08);
            Console.WriteLine("Pressione ENTER para voltar ao menu de opções.");
            Console.ReadKey();
        }

        static void IniciarVendas()
        {
            MontaTela();
            Console.SetCursorPosition(03, 05);
            Console.WriteLine("Você escolheu o módulo Iniciar Vendas");

            Console.SetCursorPosition(03, 08);
            Console.WriteLine("Pressione ENTER para voltar ao menu de opções.");
            Console.ReadKey();
        }

        static void ConsultarVendas()
        {
            MontaTela();
            Console.SetCursorPosition(03, 05);
            Console.WriteLine("Você escolheu o módulo Consultar Vendas");

            Console.SetCursorPosition(03, 08);
            Console.WriteLine("Pressione ENTER para voltar ao menu de opções.");
            Console.ReadKey();
        }
        static void MontaTela()
        {
            // Inicia as variáveis para borda horizontal, vertical e controles de coluna e linha
            int bordaHorizontal, bordaVertical, coluna, linha;

            // Muda a cor de fundo para Azul
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.Clear();

            // Seta a tela para 81 colunas e 24 linhas
            Console.SetWindowSize(81, 24);
            // Colaca um titulo na caixa (execução via cmd).
            Console.Title = "Tela para Aplicativos";

            // Atribui a cor Cinza para o titulo no centro da janela
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.SetCursorPosition(3, 2);
            Console.Write("ETEC Antônio de Pádua Cardoso      -      Sistema de Tela para Aplicativos");

            coluna = 1;
            linha = 1;

            // Atribui a cor verde para as linhas que vão compor a tela
            Console.ForegroundColor = ConsoleColor.Green;
            Console.SetCursorPosition(0, 0);
            Console.Write("╔");

            // Desenha a linha Horizontal até que seja menor que 78
            for (bordaHorizontal = 0; bordaHorizontal < 78; bordaHorizontal++)
            {
                Console.SetCursorPosition(coluna, 0);
                Console.Write("═");
                coluna++;
            }

            Console.SetCursorPosition(79, 0);
            Console.Write("╗");

            // Desenha a linha Vertical até o número 24
            for (bordaVertical = 1; bordaVertical < 24; bordaVertical++)
            {
                Console.SetCursorPosition(0, linha);
                Console.Write("║");
                linha++;
            }

            Console.SetCursorPosition(0, 4);
            Console.Write("╠");

            coluna = 1;

            for (bordaHorizontal = 0; bordaHorizontal < 78; bordaHorizontal++)
            {
                Console.SetCursorPosition(coluna, 4);
                Console.Write("═");
                coluna++;
            }

            Console.SetCursorPosition(0, 23);
            Console.Write("╚");

            linha = 1;

            for (bordaVertical = 1; bordaVertical < 23; bordaVertical++)
            {
                Console.SetCursorPosition(79, linha);
                Console.Write("║");
                linha++;
            }

            Console.SetCursorPosition(79, 4);
            Console.Write("╣");
            coluna = 1;

            Console.SetCursorPosition(79, 23);
            Console.Write("╝");

            for (bordaHorizontal = 0; bordaHorizontal < 78; bordaHorizontal++)
            {
                Console.SetCursorPosition(coluna, 23);
                Console.Write("═");
                coluna++;
            }

        }
    }
}
