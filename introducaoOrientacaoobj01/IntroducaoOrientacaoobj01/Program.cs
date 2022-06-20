using System;

namespace IntroducaoOrientacaoobj01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pessoa x = new Pessoa();
            Pessoa y = new Pessoa();

            Console.WriteLine("Digite o nome e a idade da pesoa 1: ");
            x.Nome = Console.ReadLine();
            x.Idade = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o nome e a idade da pesoa 2: ");
            y.Nome = Console.ReadLine();
            y.Idade = int.Parse(Console.ReadLine());

            Pessoa.CalcIdade(x, y);
        }
    }
}
