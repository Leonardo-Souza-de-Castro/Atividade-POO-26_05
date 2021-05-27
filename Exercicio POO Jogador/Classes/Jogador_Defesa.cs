using System;

namespace Exercicio_POO_Jogador.Classes
{
    public class Jogador_Defesa : Jogador
    {
        public void Aposentadoria()
        {
            if (idade > 40)
            {
                Console.WriteLine("Já ta velho em amigo, aposentaria já ta garantida");
            }else
            {
                Console.WriteLine($@"Você ainda pode jogar, faltam {40 - idade} anos para você se aposentar!");
            }
        }
    }
}