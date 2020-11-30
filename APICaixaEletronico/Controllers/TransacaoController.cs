using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business.Mapa;
using Business.Repositorio;
using Business.Requisicao;
using Business.Response;
using Microsoft.AspNetCore.Mvc;

namespace APICaixaEletronico.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TransacaoController : Controller
    {
        [HttpGet]
        public ActionResult<List<TransacaoResposta>> Get()
        {
            var cliente = TransacaoRepositorio.Buscar().Select(c => TransacaoMapa.Mapa(c));

            return cliente.ToList();
        }

        [HttpGet("{id}")]
        public ActionResult<TransacaoResposta> Get(int id)
        {
            var cliente = TransacaoMapa.Mapa(TransacaoRepositorio.Buscar(0, "").FirstOrDefault());

            return cliente;
        }


        [HttpGet("cliente/{idCliente}")]
        public ActionResult<TransacaoResposta> GetCliente(int clienteid)
        {
            var cliente = TransacaoMapa.Mapa(TransacaoRepositorio.BuscarTransacaoClienteId(clienteid, "").FirstOrDefault());

            return cliente;
        }

        //[HttpGet("{descricao}")]
        //public ActionResult<TransacaoResposta> Get(string descricao)
        //{
        //    var cliente = TransacaoMapa.Mapa(TransacaoRepositorio.Buscar(0, descricao).FirstOrDefault());

        //    return cliente;
        //}

        [HttpPost]
        public ActionResult<RetornoReposta> Post([FromBody] TransacaoRequisicao request)
        {
            var transacao = TransacaoMapa.Mapa(request);

            TransacaoRepositorio.Gravar(transacao);


            var retorno = new RetornoReposta()
            {
                Code = 200,
                Mensagem = $"Registro {request.descricao} cadastrado com sucesso!"
            };
            return retorno;
        }

        [HttpPut]
        public ActionResult<RetornoReposta> Put([FromBody] TransacaoRequisicao request)
        {
            var transacao = TransacaoMapa.Mapa(request);

            TransacaoRepositorio.Atualizar(transacao);

            var retorno = new RetornoReposta()
            {
                Code = 200,
                Mensagem = $"Registro {request.descricao} atualizado com sucesso!"
            };
            return retorno;
        }

        [HttpDelete("{id}")]
        public ActionResult<RetornoReposta> Delete([FromBody] TransacaoRequisicao request)
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
