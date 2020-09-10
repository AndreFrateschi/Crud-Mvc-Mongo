using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using ApiTreinamento.Model;
using ApiTreinamento.ViewModel;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Bson;
using MongoDB.Driver;

namespace ApiTreinamento.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        protected static IMongoClient _client;
        protected static IMongoDatabase _database;


        public static List<PessoaViewModel> users = new List<PessoaViewModel>();


        public UsuarioController()
        {
   

        }

        [HttpGet]
        public ActionResult Get()
        {

            if (users.Count == 0)
            {
                _client = new MongoClient();
                _database = _client.GetDatabase("admin");
                var _collection = _database.GetCollection<Pessoa>("pessoaMongo");

                var pessoaEncontrada = _collection.Find(x => x.nome != "ZZZ").ToList();

                return Ok(pessoaEncontrada);
            }
            else
            {
                return Ok();
            }

        }

        [HttpPost]
        public ActionResult Post([FromBody] PessoaViewModel pessoa)
        {
            users.Add(pessoa);

            return Ok("Cadastrado realizado com sucesso!");
        }


        //    [HttpGet("{id}")]
        //    public ActionResult GetById(int id)
        //    {
        //        UsuarioViewModel usuario = users.FirstOrDefault(x => x.Id == id);

        //        return Ok(usuario);
        //    }

        //    [HttpPost]
        //    public ActionResult Post([FromBody] UsuarioViewModel usuario) 
        //    {
        //        users.Add(usuario);

        //        return Ok("Cadastrado realizado com sucesso!");
        //    }

        //    [HttpPut]
        //    public ActionResult Put([FromBody] UsuarioViewModel usuario)
        //    {
        //        var usuarioModel = users.Where(x => x.Id != usuario.Id).ToList();

        //        users = usuarioModel;
        //        users.Add(usuario);

        //        return Ok("Alteração realizada com sucesso!");
        //    }

        //    [HttpDelete("{id}")]
        //    public ActionResult Delete(int id)
        //    {
        //        var usuarioModel = users.Where(x => x.Id != id).ToList();

        //        users = usuarioModel;

        //        return Ok("Alteração realizada com sucesso!");
        //    }

    }
}
