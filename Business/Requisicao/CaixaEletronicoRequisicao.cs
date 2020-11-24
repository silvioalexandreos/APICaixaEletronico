using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Requisicao
{
    public class CaixaEletronicoRequisicao
    {
        public int Id { get; set; }
        public DateTime DataCadastro { get; set; }
        public bool Status { get; set; }
        public string Descricao { get; set; }
        public int QtdNota2 { get; set; }
        public int QtdNota5 { get; set; }
        public int QtdNota10 { get; set; }
        public int QtdNota20 { get; set; }
        public int QtdNota50 { get; set; }
        public int QtdNota100 { get; set; }
        public int QtdNota200 { get; set; }
    }
}
