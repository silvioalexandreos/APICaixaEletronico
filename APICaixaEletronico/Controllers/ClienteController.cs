using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business.Mapa;
using Business.Repositorio;
using Business.Requisicao;
using Business.Response;
using DataBase.Domain;
using Microsoft.AspNetCore.Mvc;

namespace APICaixaEletronico.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClienteController : Controller
    {
        [HttpGet]
        public ActionResult<List<ClienteResposta>> Get()
        {
            var cliente = ClienteRepositorio.Buscar().Select(c => ClienteMapa.Mapa(c));

            return cliente.ToList();
        }

        [HttpGet("{nome}")]
        public ActionResult<ClienteResposta> Get(string nome)
        {
            var cliente = ClienteMapa.Mapa(ClienteRepositorio.Buscar(0, nome).FirstOrDefault());

            return cliente;
        }

        [HttpPost]
        public ActionResult<RetornoReposta> Post([FromBody] ClienteRequisicao request)
        {
            var cliente = ClienteMapa.Mapa(request);

            ClienteRepositorio.Gravar(cliente);

            var retorno = new RetornoReposta()
            {
                Code = 200,
                Mensagem = $"Registro {request.Nome} cadastrado com sucesso!"
            };
            return retorno;
        }

        [HttpPut]
        public ActionResult<RetornoReposta> Put([FromBody] ClienteRequisicao request)
        {
            var cliente = ClienteMapa.Mapa(request);

            ClienteRepositorio.Atualizar(cliente);


            var retorno = new RetornoReposta()
            {
                Code = 200,
                Mensagem = $"Registro {request.Nome} atualizado com sucesso!"
            };
            return retorno;
        }

        [HttpDelete("{id}")]
        public ActionResult<RetornoReposta> Delete([FromBody] ClienteRequisicao request)
        {

            var retorno = new RetornoReposta()
            {
                Code = 200,
                Mensagem = "Registro deleteado com sucesso!"
            };
            return retorno;
        }
    }
}
