using System;
using Exercicio_POO_Maquina_Cafe.Classes;

namespace Exercicio_POO_Maquina_Cafe
{
    class Program
    {
        static bool recomecar = false;

        static void menu_recomecar(){
            Console.WriteLine($@"
|===============================|
|    Gostaria de um novo café?  |
|===============================|
|        S - sim                |
|        N - não                |
|===============================|
            ");
            string resposta = Console.ReadLine().ToLower();
            if (resposta == "s")
            {
                recomecar = true;
            }else
            {
                recomecar = false;
            }
        }
        static void Main(string[] args)
        {
            string opcoes;
            
            Maquina_cafe ma = new Maquina_cafe();

            do
            {
            Console.WriteLine("Gostaria de café com ou sem açúcar? (C - Com / S - Sem)");
            opcoes = Console.ReadLine().ToLower();
            switch (opcoes)
            {
                case "c":
                Console.WriteLine("Gostaria de Informar a quantidade de açúcar? (S - sim / N - não)");
                string opcoes_2 = Console.ReadLine().ToLower();

                if (opcoes_2 == "s")
                {
                   Console.Clear();
                   Console.WriteLine("Qual a quantidade de açúcar que deseja no café? (informe a quantidade em gramas)");
                   int quantidade_acucar = int.Parse(Console.ReadLine());
                   ma.Fazer_Cafe(quantidade_acucar);
                   menu_recomecar(); 
                }else
                {
                    Console.Clear();
                    ma.Fazer_Cafe();
                    menu_recomecar();
                }
                    break;
                
                case "s":
                    Console.Clear();
                    Console.WriteLine("Estamos Fazendo seu café, aguarde um instante!");
                    menu_recomecar();
                    break;

                default:
                    Console.WriteLine("Não entendi poderia repetir!");
                    recomecar = true;
                    break;
            }
            } while (recomecar);
            
            
        }
    }
}
