using System;
using System.Globalization;
using System.Collections.Generic;
using ProdutoObj.Entities;

namespace ProdutoObj
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<Produto> list = new List<Produto>();
            Console.WriteLine("Digite se o produto é nacional ou importado: (N/I) ");
            char prod = char.Parse(Console.ReadLine());
            Console.WriteLine("Nome: ");
            string nome = Console.ReadLine();
            Console.WriteLine("Preço: ");
            double preco = double.Parse(Console.ReadLine());
            if(( prod=='N') || ( prod== 'n')) {
                Console.WriteLine("Produto nacional!");
                Produto produto = new Produto(nome, preco);
                list.Add(produto);
                Console.WriteLine(produto.ToString());
            }
            else
            {
                Console.WriteLine("Taxa: ");
                double taxa = double.Parse(Console.ReadLine());
                Console.WriteLine("Produto importado!");
                Produto import = new ProdutoImportado(nome, preco, taxa);
                Console.WriteLine(import.ToString());
            }
        }
    }
}
