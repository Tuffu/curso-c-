using System;
using System.Collections.Generic;
using System.Text;

namespace Ex5
{
    class Aluno
    {
        public string Nome;
        public double Nota, Nota2, Nota3;

        public double Med()
        {
            return Nota + Nota2 + Nota3;

        }

        public bool Aprovado()
        {
            if(Med() >= 60.0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public double NotaRestante()
        {
            if (Aprovado())
            {
                return 0.0;
            }
            else
            {
                return 60 - Med();
            }
        }

        public override string ToString()
        {
            return Nome 
            + " "+ Nota.ToString();
        }
    }
}
