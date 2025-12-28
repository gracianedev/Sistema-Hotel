using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hotel.Models
{
    public class Suite
    {
        public Suite (string TipoSuite, int Capacidade, decimal ValorDiaria)
        {
            this.TipoSuite = TipoSuite;
            this.Capacidade = Capacidade;
            this.ValorDiaria = ValorDiaria;
        }
        public string TipoSuite { get; set; }
        public int Capacidade { get; set; }

        public decimal ValorDiaria { get; set; }
    }
}