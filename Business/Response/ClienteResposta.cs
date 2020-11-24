using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Response
{
    public class ClienteResposta
    {
        public string Id { get; set; }
        public string DataCadastro { get; set; }
        public string Status { get; set; }
        public string Conta { get; set; }
        public string Saldo { get; set; }
        public string Nome { get; set; }
        public string Tipo { get; set; }
        public string CPF { get; set; }
        public string CNPJ { get; set; }
        public string NomeFantasia { get; set; }
    }
}
