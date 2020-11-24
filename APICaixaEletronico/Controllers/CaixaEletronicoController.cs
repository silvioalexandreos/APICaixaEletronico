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
    public class CaixaEletronicoController : Controller
    {
        [HttpGet]
        public ActionResult<List<CaixaEletronicoResposta>> Get()
        {
            var cliente = CaixaEletronicoRepositorio.Buscar().Select(c => CaixaEletronicoMapa.Mapa(c));

            return cliente.ToList();
        }

        [HttpGet("{descricao}")]
        public ActionResult<CaixaEletronicoResposta> Get(string descricao)
        {
            var caixa = CaixaEletronicoMapa.Mapa(CaixaEletronicoRepositorio.Buscar(0, descricao).FirstOrDefault());

            return caixa;
        }

        [HttpPost]
        public ActionResult<RetornoReposta> Post([FromBody] CaixaEletronicoRequisicao request)
        {
            var caixa = CaixaEletronicoMapa.Mapa(request);

            CaixaEletronicoRepositorio.Gravar(caixa);

            var retorno = new RetornoReposta()
            {
                Code = 200,
                Mensagem = $"Registro {request.Descricao} cadastrado com sucesso!"
            };
            return retorno;
        }

        [HttpPut]
        public ActionResult<RetornoReposta> Put([FromBody] CaixaEletronicoRequisicao request)
        {
            var caixa = CaixaEletronicoMapa.Mapa(request);

            CaixaEletronicoRepositorio.Gravar(caixa);

            var retorno = new RetornoReposta()
            {
                Code = 200,
                Mensagem = $"Registro {request.Descricao} atualizado com sucesso!"
            };
            return retorno;
        }

        [HttpDelete("{id}")]
        public ActionResult<RetornoReposta> Delete([FromBody] CaixaEletronicoRequisicao request)
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
