using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hotel.Models
{
    public class Pessoa
    {
        public Pessoa (string Nome, string Sobrenome)
        {
            this.Nome = Nome;
            this.Sobrenome = Sobrenome;
        }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }

    }
}