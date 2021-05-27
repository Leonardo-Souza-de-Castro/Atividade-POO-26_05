using System;

namespace Exercicio_POO_Elevador.Classes
{
    public abstract class Elevador
    {
        public int andar_atual = 0;

        public int maximo = 8;

        public int quantidade = 0;

        public int resposta;

        public int total_andares = 5;

        public void Entrar()
        {
            Console.WriteLine("Quantas Pessoas Vão entrar?");
            resposta = int.Parse(Console.ReadLine());
            if (resposta <= 8)
            {
                quantidade = quantidade + resposta;
                if (quantidade == maximo)
                {
                    Console.WriteLine("Elevador cheio");
                }
                maximo = maximo - resposta;
                Console.WriteLine($@"Entraram {resposta} pessoas");
            }
            else
            {
                Console.WriteLine("Elevador cheio");
            }

        }

        public void Sair()
        {
            Console.WriteLine("Quantas pessoas vão sair?");
            resposta = int.Parse(Console.ReadLine());

            if (maximo > 0 && quantidade > 0)
            {
                quantidade = quantidade - resposta;
                maximo = maximo + resposta;
                Console.WriteLine($@"Sairam {resposta} pessoas");
            }
            else
            {
                Console.WriteLine("Não tem ninguem no elevador antes de sair por favor entrar");
            }
        }

        public void Subir()
        {
            Console.WriteLine("Para qual andar deseja ir?");
            resposta = int.Parse(Console.ReadLine());
            if (andar_atual <= total_andares && quantidade > 0)
            {
                for (var c = 0; c < (resposta - andar_atual); quantidade++)
                {
                    andar_atual = andar_atual + 1;
                    Console.WriteLine(andar_atual + c);
                }
            }
            else if (andar_atual <= total_andares && quantidade == 0)
            {
                Console.WriteLine("Entre no elevador antes de subir");
            }
            else
            {
                Console.WriteLine("Você não pode subir tudo isso ultrapassa os limites do prédio");
            }

        }

        public void Descer()
        {
            Console.WriteLine("Quantos andares você vai descer?");
            resposta = int.Parse(Console.ReadLine());

            if (andar_atual > 0 && quantidade > 0)
            {
                andar_atual = andar_atual - resposta;
                Console.WriteLine($@"Descendo {resposta} andares!");
            }
            else
            {
                Console.WriteLine("Estamos no térreo, não tem como descer");
            }
        }
    }
}