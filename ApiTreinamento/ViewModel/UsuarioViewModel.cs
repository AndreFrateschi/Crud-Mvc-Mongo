using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiTreinamento.ViewModel
{
    public class UsuarioViewModel
    {
        public UsuarioViewModel()
        {
                
        }

        public UsuarioViewModel(int id, string nome, string email)
        {
            this.Id = id;
            this.Nome = nome;
            this.Email = email;
        }
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
    }
}
