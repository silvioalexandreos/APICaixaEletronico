using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Response
{
    public class TransacaoResposta
    {
        public string Id { get; set; }
        public string DataTransacao { get; set; }
        public string descricao { get; set; }
        public string Valor { get; set; }
        public string IdCliente { get; set; }
        public string IdCaixaEletronico { get; set; }
    }
}
