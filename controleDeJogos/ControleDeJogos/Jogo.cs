using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeJogos
{
    public enum TipoGenero { Acao, Aventura, Casual, Puzze, Estrategia, Outro}

    public enum TipoConsole { PS4, PS5, Xbox_One, Xbom_360, Pc, Outro }
    public class Jogo
    {
        public Jogo()
        {
            this.Id = 1;
            this.Nome = "";
            this.Descricao = "";
            this.Genero = TipoGenero.Outro;
            this.Console = TipoConsole.Outro;
        }
        public Jogo(int id, string nome, string descicao, TipoGenero genero, TipoConsole console)
        {

        
        
            this.Id = id;
            this.Nome = nome;
            this.Descricao = descricao;
            this.Genero = genero;
            this.Console = console;
        }
        private int id;

        public int Id
        {
            get { return id; }
            set
            {
                if (value >= 0) id = value;
                else
                {
                    throw new Exception("permitido apenas números positivos!");
                }
            }
        }

        private string nome;

        public string Nome
        {
            get { return nome; }
            set { nome = value.ToUpper(); }
        }

        private string descricao;

        public string Descricao
        {
            get { return descricao; }
            set { descricao = value.ToUpper(); }
        }

        public TipoConsole Console { get; set; }

        public TipoGenero Genero { get; set; }



    }
}
