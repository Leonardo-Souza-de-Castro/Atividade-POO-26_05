using System;

namespace Exercicio_POO_Elevador.Classes
{
    public class Elevador_de_Servico : Elevador
    {
        public void Entrar_caixas(){
            Console.WriteLine("Quantas caixas vão entrar?");
            resposta = int.Parse(Console.ReadLine());
            if (resposta <= 8)
            {
                quantidade = quantidade + resposta;
                maximo = maximo - resposta;
                Console.WriteLine($@"Entraram {resposta} caixas");
            }else
            {
                Console.WriteLine("Elevador cheio");
            }
        }

        public void Sair_Caixas(){
            Console.WriteLine("Quantas caixas vão sair?");
            resposta = int.Parse(Console.ReadLine());
            if (maximo > 0 && quantidade != 0)
            {
                quantidade = quantidade - resposta;
                maximo = maximo + resposta;
                Console.WriteLine($@"Sairam {resposta} caixas");
            }else
            {
                Console.WriteLine("Não tem ninguem no elevador antes de sair por favor entrar");
            }
        }
    }
}