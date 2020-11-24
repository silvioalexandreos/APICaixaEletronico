using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Response
{
    public class CaixaEletronicoResposta
    {
        public string Id { get; set; }
        public string DataCadastro { get; set; }
        public string Status { get; set; }
        public string Descricao { get; set; }
        public string QtdNota2 { get; set; }
        public string QtdNota5 { get; set; }
        public string QtdNota10 { get; set; }
        public string QtdNota20 { get; set; }
        public string QtdNota50 { get; set; }
        public string QtdNota100 { get; set; }
        public string QtdNota200 { get; set; }
    }
}
