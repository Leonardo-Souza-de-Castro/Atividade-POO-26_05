using System;
using Exercicio_POO_Jogador.Classes;

namespace Exercicio_POO_Jogador
{
    class Program
    {
        static void Main(string[] args)
        {
            bool recomecar = false;

            do
            {

                Console.WriteLine($@"
=========================================
|   Em qual posição você se enquadra:   |
|       A - ataque                      |
|       D - Defesa                      |
|       M - Meio - Campo                |
=========================================
            ");

                string opcoes = Console.ReadLine().ToLower();

                switch (opcoes)
                {
                    case "a":
                        Jogador_Ataque a = new Jogador_Ataque();
                        a.Coletar_Dados();
                        a.Calcular_Idade();
                        Console.Clear();
                        a.Mostrar_info();
                        a.Aposentadoria();
                        recomecar = false;
                        break;
                    case "d":
                        Jogador_Defesa d = new Jogador_Defesa();
                        d.Coletar_Dados();
                        d.Calcular_Idade();
                        Console.Clear();
                        d.Mostrar_info();
                        d.Aposentadoria();
                        recomecar = false;
                        break;
                    case "m":
                        Jogador_Meio m = new Jogador_Meio();
                        m.Coletar_Dados();
                        m.Calcular_Idade();
                        Console.Clear();
                        m.Mostrar_info();
                        m.Aposentadoria();
                        recomecar = false;
                        break;
                    default:
                        Console.WriteLine("Selecione uma posição válida");
                        recomecar = true;
                        break;
                }
            } while (recomecar);


        }
    }
}
