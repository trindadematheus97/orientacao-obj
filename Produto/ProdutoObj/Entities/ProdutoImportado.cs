using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProdutoObj.Entities
{
    internal class ProdutoImportado : Produto
    {
        public double TaxaImportaco { get; set; }

        public ProdutoImportado()
        {

        }

        public ProdutoImportado(string nome, double preco, double taxaImportacao)
        {
            Preco = (taxaImportacao  * preco / 100) + ( preco);
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Nome: " + Nome);
            sb.AppendLine("Preço: " + Preco)
            sb.AppendLine("Importado");
            return sb.ToString();
        }
    }
}
