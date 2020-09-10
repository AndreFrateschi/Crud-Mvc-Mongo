using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApiTreinamento.Model;

namespace ApiTreinamento.ViewModel
{
    public class PessoaViewModel : Pessoa
    {
        public PessoaViewModel()
        {

        }

        public PessoaViewModel(Guid Id, object id, string nome, string cpf, string senha)
        {
            this.Id = Guid.NewGuid();
            this.Nome = nome;
            this.Cpf = cpf;
            this.Senha = senha;
        }
        public new Guid Id { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Senha { get; set; }

    }
}

