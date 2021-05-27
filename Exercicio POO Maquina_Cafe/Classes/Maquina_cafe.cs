using System;

namespace Exercicio_POO_Maquina_Cafe.Classes
{
    public class Maquina_cafe
    {
        public int acucar_disponivel = 1000;

        public int quantidade_acucar;

        public void Fazer_Cafe(int quantidade_acucar)
        {
            if (acucar_disponivel >= quantidade_acucar)
            {
                acucar_disponivel = acucar_disponivel - quantidade_acucar;
                Console.WriteLine("Estamos fazendo seu Café, aguarde alguns instantes!");
                Console.WriteLine($"A quantidade de açúcar disponivel é: {acucar_disponivel} gramas");
            }
            else
            {
                Console.WriteLine("O açúcar da máquina acabou iremos fazer seu café sem açúcar!");
                Console.WriteLine($"A quantidade de açúcar disponivel é: {acucar_disponivel} gramas");
            }
        }

        public void Fazer_Cafe()
        {
            if (acucar_disponivel >= 10)
            {
                acucar_disponivel = acucar_disponivel - 10;
                Console.WriteLine("Estamos fazendo seu café com açúcar, aguarde alguns instantes!");
                Console.WriteLine($"A quantidade de açúcar disponivel é: {acucar_disponivel} gramas");
            }
            else
            {
                Console.WriteLine("O açúcar da máquina acabou iremos fazer seu café sem açúcar!");
                Console.WriteLine($"A quantidade de açúcar disponivel é: {acucar_disponivel} gramas");
            }
        }
    }
}