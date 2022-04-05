using System;

namespace CalculadoraIMC
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual é o seu nome?");
            string nome = Console.ReadLine();

            Console.WriteLine("Qual é a sua altura em metros? Ex. 1,65");
            double altura = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("Qual o seu peso em Kg? Ex: 70,3");
            double peso = Convert.ToSingle(Console.ReadLine());

            Pessoa p1 = new Pessoa(nome, peso, altura);

            Console.WriteLine("Seu IMC é {0}", p1.CalculoIMC);

             
        }
    }
}
