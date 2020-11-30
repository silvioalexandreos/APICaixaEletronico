using Business.Requisicao;
using Business.Response;
using DataBase.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Mapa
{
    public class TransacaoMapa
    {
        public static Transacao Mapa(TransacaoRequisicao transacaoRequisicao)
        {
            return new Transacao()
            {
                Id = transacaoRequisicao.Id,
                DataTransacao = transacaoRequisicao.DataTransacao,
                descricao = transacaoRequisicao.descricao,
                Valor = transacaoRequisicao.Valor,
                IdCliente = transacaoRequisicao.IdCliente,
                IdCaixaEletronico = transacaoRequisicao.IdCaixaEletronico
            };
        }

        public static TransacaoResposta Mapa(Transacao transacao)
        {
            return new TransacaoResposta()
            {
                Id = transacao.Id.ToString(),
                DataTransacao = transacao.DataTransacao.ToString(),
                descricao = transacao.descricao,
                Valor = transacao.Valor.ToString(),
                IdCliente = transacao.IdCliente.ToString(),
                IdCaixaEletronico = transacao.IdCaixaEletronico.ToString()
            };
        }
    }
}