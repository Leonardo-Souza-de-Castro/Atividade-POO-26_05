using System;

namespace Exercicio_POO_Jogador.Classes
{
    public abstract class Jogador
    {
        public string nome;

        public int data_nascimento;

        public int idade;

        public string nacionalidade;

        public string altura;

        public string peso;

        public void Coletar_Dados()
        {
            Console.Write("Qual o seu nome? ");
            nome = Console.ReadLine();

            Console.Write("Qual o seu ano de nascimento? ");
            data_nascimento = int.Parse(Console.ReadLine());

            Console.Write("Qual a sua Nacionalidade? ");
            nacionalidade = Console.ReadLine();

            Console.Write("Qual a sua altura? ");
            altura = Console.ReadLine();

            Console.Write("Qual o seu peso? ");
            peso = Console.ReadLine();
        }

        public void Calcular_Idade()
        {
            idade = DateTime.Now.Year - data_nascimento;
        }

        public void Mostrar_info()
        {
            Console.WriteLine($@"Nome: {nome}");
            Console.WriteLine($@"Ano de Nascimento: {data_nascimento}");
            Console.WriteLine($@"Idade: {idade}");
            Console.WriteLine($@"Nacionalidade: {nacionalidade}");
            Console.WriteLine($@"Altura: {altura} m");
            Console.WriteLine($@"Peso: {peso}kg");
        }

    }
}