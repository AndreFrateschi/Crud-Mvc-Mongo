using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiTreinamento.Model
{
    public class Pessoa
    {
        public Guid Id { get; set; }
        public string nome { get;  set; }
        public string cpf { get; set; }
        public string senha { get; set; }
    }  
}
