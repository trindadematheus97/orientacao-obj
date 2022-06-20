using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeJogos
{
    public class ListaDeJogos
    {
        
       private List<Jogo> _jogos;

       public List<Jogo> Jogos
        {
            get
            {
                return _jogos;
            }
        }

        public ListaDeJogos()
        {
            _jogos = new List<Jogo>();
        }

        public Boolean Inserir(Jogo jogo)
        {
            Boolean resultado = true;
            try
            {
                Jogo j = _jogos.Find(x => x.Id == jogo.Id); 
                if(j == null)
                {
                    _jogos.Add(jogo);
                }
                else
                {
                    resultado = false;
                }
            }
            catch (Exception)
            {
                resultado = false;
            }

            return resultado;
        }
    }
}
