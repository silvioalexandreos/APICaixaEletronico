using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business.Mapa;
using Business.Repositorio;
using Business.Response;
using Microsoft.AspNetCore.Mvc;

namespace APICaixaEletronico.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SaqueController : Controller
    {
        [HttpGet]
        public Dictionary<string, string> Get(ContaNotasResposta resposta)
        {

            if (true)
            {
                ContaNotasRepositorio saque = new ContaNotasRepositorio();

                return saque.ContaNotas(resposta.Valor, resposta.N5, resposta.N4, resposta.N3, resposta.N2, resposta.N1);
            }

        }

        [HttpPost]
        public Dictionary<string, string> Post(ContaNotasResposta resposta)
        {

            if (true)
            {
                ContaNotasRepositorio saque = new ContaNotasRepositorio();

                return saque.ContaNotas(resposta.Valor, resposta.N5, resposta.N4, resposta.N3, resposta.N2, resposta.N1);
            }

        }
    }
}
