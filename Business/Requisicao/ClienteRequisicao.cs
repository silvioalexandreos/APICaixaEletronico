using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Requisicao
{
    public class ClienteRequisicao
    {
        public int Id { get; set; }
        public DateTime DataCadastro { get; set; }
        public bool Status { get; set; }
        public int Conta { get; set; }
        public float Saldo { get; set; }
        public string Nome { get; set; }
        public int Tipo { get; set; }
        public string CPF { get; set; }
        public string CNPJ { get; set; }
        public string NomeFantasia { get; set; }
    }
}
