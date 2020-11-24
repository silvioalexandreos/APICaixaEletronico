using Business.Requisicao;
using Business.Response;
using DataBase.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Mapa
{
    public class CaixaEletronicoMapa
    {
        public static CaixaEletronico Mapa(CaixaEletronicoRequisicao clientePFRequisicao)
        {
            return new CaixaEletronico()
            {
                Id = clientePFRequisicao.Id,
                DataCadastro = clientePFRequisicao.DataCadastro,
                Status = clientePFRequisicao.Status,
                QtdNotas2 = clientePFRequisicao.QtdNota2,
                QtdNotas5 = clientePFRequisicao.QtdNota5,
                QtdNotas10 = clientePFRequisicao.QtdNota10,
                QtdNotas20 = clientePFRequisicao.QtdNota20,
                QtdNotas50 = clientePFRequisicao.QtdNota50,
                QtdNotas100 = clientePFRequisicao.QtdNota100,
                QtdNotas200 = clientePFRequisicao.QtdNota200
            };
        }

        public static CaixaEletronicoResposta Mapa(CaixaEletronico caixa)
        {
            return new CaixaEletronicoResposta()
            {
                Id = caixa.Id.ToString(),
                DataCadastro = caixa.DataCadastro.ToString(),
                Status = caixa.Status.ToString(),
                QtdNota2 = caixa.QtdNotas2.ToString(),
                QtdNota5 = caixa.QtdNotas5.ToString(),
                QtdNota10 = caixa.QtdNotas10.ToString(),
                QtdNota20 = caixa.QtdNotas20.ToString(),
                QtdNota50 = caixa.QtdNotas50.ToString(),
                QtdNota100 = caixa.QtdNotas100.ToString(),
                QtdNota200 = caixa.QtdNotas200.ToString()
            };
        }
    }
}
