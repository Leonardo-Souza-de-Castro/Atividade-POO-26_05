using System;

namespace Exercicio_POO_Jogador.Classes
{
    public class Jogador_Meio : Jogador
    {
        public void Aposentadoria()
        {
            if (idade > 38)
            {
                Console.WriteLine("Já ta velho em amigo, aposentaria já ta garantida");
            }else
            {
                Console.WriteLine($@"Você ainda pode jogar, faltam {38 - idade} anos para você se aposentar!");
            }
        }
    }
}