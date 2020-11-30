using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Requisicao
{
    public class ClienteRequisicao
    {
        [Key]
        public int Id { get; set; }
        public DateTime DataCadastro { get; set; }
        public bool Status { get; set; }
        public float Saldo { get; set; }
        public string Nome { get; set; }


        public ClienteRequisicao()
        {
            DataCadastro = DateTime.Now;
            Status = true;
        }
    }
}
