using System;
using Exercicio_POO_Elevador.Classes;

namespace Exercicio_POO_Elevador
{
    class Program
    {
        static bool refazer = false;
        static void Main(string[] args)
        {
            string opcoes;

            Elevador_Social s = new Elevador_Social();
            Elevador_de_Servico se = new Elevador_de_Servico();

            Console.WriteLine($@"
 Qual elevador você vai usar?
     1 - Elevador Social
     2 - Elevador de Serviço            
");
            string elevadores = Console.ReadLine();

            switch (elevadores)
            {
                case "1":
                    s.Info_Elevador();
                    do
                    {
                        Console.WriteLine($@"
|=======================| 
|  O que faremos hoje?  |
|-----------------------|
|     S - Subir         |
|     D - Descer        |
|     E - Entrar        |
|     X - Sair          |
|=======================|
            ");

                        opcoes = Console.ReadLine().ToLower();

                        switch (opcoes)
                        {
                            case "s":
                                Console.Clear();
                                s.Subir();
                                Retornar_menu();
                                break;

                            case "d":
                                Console.Clear();
                                s.Descer();
                                Retornar_menu();
                                break;

                            case "e":
                                Console.Clear();
                                s.Entrar();
                                Retornar_menu();
                                break;

                            case "x":
                                Console.Clear();
                                s.Sair();
                                Retornar_menu();
                                break;

                            default:
                                Console.WriteLine("Opção Invalida, digite novamente");
                                refazer = true;
                                break;
                        }
                    } while (refazer);
                    break;
                case "2":
                    s.Info_Elevador();
                    do
                    {
                        Console.WriteLine($@"
|=======================| 
|  O que faremos hoje?  |
|-----------------------|
|     S - Subir         |
|     D - Descer        |
|     E - Entrar Caixas |
|     X - Sair Caixas   |
|=======================|
            ");

                        opcoes = Console.ReadLine().ToLower();
                        switch (opcoes)
                        {
                            case "s":
                                Console.Clear();
                                se.Subir();
                                Retornar_menu();
                                break;

                            case "d":
                                Console.Clear();
                                se.Descer();
                                Retornar_menu();
                                break;

                            case "e":
                                Console.Clear();
                                se.Entrar_caixas();
                                Retornar_menu();
                                break;

                            case "x":
                                Console.Clear();
                                se.Sair_Caixas();
                                Retornar_menu();
                                break;

                            default:
                                Console.WriteLine("Opção Invalida, digite novamente");
                                refazer = true;
                                break;
                        }
                    } while (refazer);

                    break;
                default:
                    break;
            }
        }

        static void Retornar_menu()
        {
            Console.WriteLine($@"
|===============================|
| Gostaria de retornar ao menu? |
|-------------------------------|
|           S - Sim             |
|           N - Não             |
|===============================|
            ");

            string resposta = Console.ReadLine().ToLower();

            if (resposta == "s")
            {
                refazer = true;
            }
            else
            {
                refazer = false;
            }
        }
    }
}
