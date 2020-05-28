using System;
using System.Collections.Generic;
using System.Reflection.PortableExecutable;
using System.Text;

namespace ArrayEx1
{
     class Pessoa
    {
        public string Nome {get; set;}
        public string Email { get; set; }

        public Pessoa(string nome, string email)
        {
            Nome = nome;
            Email = email;
        }

        public override string ToString()
        {
            return 
            Nome +
            ", "
            + Email;
        }
    }  
}
