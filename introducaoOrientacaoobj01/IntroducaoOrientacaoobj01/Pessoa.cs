using System;

namespace IntroducaoOrientacaoobj01
{
    public class Pessoa
    {
        public string Nome;
        public int Idade;

        public static void CalcIdade(Pessoa x, Pessoa y)
        {
            if (x.Idade > y.Idade)
            {
                Console.WriteLine("A pessoa mais velha é: " + x.Nome);
            }
            else Console.WriteLine("A pessoa mais velha é: " + y.Nome);
        }
    }
}
