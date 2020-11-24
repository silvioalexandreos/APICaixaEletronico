using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Requisicao
{
    public class TransacaoRequisicao
    {
        public int Id { get; set; }
        public DateTime DataTransacao { get; set; }
        public string descricao { get; set; }
        public float Valor { get; set; }
        public int IdCliente { get; set; }
        public int IdCaixaEletronico { get; set; }
    }
}
