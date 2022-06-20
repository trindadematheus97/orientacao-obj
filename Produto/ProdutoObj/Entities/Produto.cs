using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace ProdutoObj.Entities
{
    class Produto 
    {
            public string Nome { get; set; }
            public double Preco { get; set; }
        public Produto()
        {

        }
        public Produto(string nome, double preco)
        {
            Nome = nome;
            Preco = preco;
        }

        public  virtual string ToString()
        {
            
            StringBuilder sb = new StringBuilder();
            sb.Append("Nome: " + Nome);
            sb.AppendLine("Preço: " + Preco);
            sb.AppendLine("Produto nacional!");
        
            return sb.ToString();
        }


    }
}

