using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GerenciadorLojasAPI.Models
{
    public class Market
    {
        public Guid Id { get; set; }
        public string CNPJ { get; set; }
        public Address Address { get; set; }
        public int Number { get; set; }
    }
}