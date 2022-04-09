using System;

namespace CalculadoraIMC
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual é o seu nome?");
            string Nome = Console.ReadLine();

            Console.WriteLine("Qual é a sua altura em metros? Ex. 1.65");
            double Altura = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("Qual o seu peso em Kg? Ex: 70.3");
            double Peso = Convert.ToSingle(Console.ReadLine());

            Pessoa p1 = new Pessoa(Nome, Altura, Peso);    

            Console.WriteLine("Nome: {2}, Peso: {0}Kg, Altura: {1}m", p1.Peso, Math.Round(p1.Altura, 2) , p1.Nome);
            Console.WriteLine("Seu IMC é {0} e você está {1}", p1.Imc, p1.CalculoIMC()); 
            Console.WriteLine(p1.PesoIdeal());
        }
    }
}
