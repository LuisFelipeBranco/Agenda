using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Entities
{
    public class Contato
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public String Telefone { get; set; }
        public bool Ativo { get; set; }


    }
}