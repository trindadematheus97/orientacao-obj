using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotaAlunoObj
{
    public class Aluno
    {
        public string Nome;
        public double Nota1;
        public double Nota2;
        public double Nota3;
        public double Media;

        public double NotaFinal()
        {
            return (Nota1 + Nota2 + Nota3) / 3;
        }

        public Boolean Aprovado()
        {
            if (NotaFinal() > 60.00)
            {
                return true;
            }
            else return false;
        }

        public double NotaRestante()
        {
            if (Aprovado())
            {
                return 0.0;
            }
            else
            {
                return 60.0 - NotaFinal();
            }
        }



    }
}
