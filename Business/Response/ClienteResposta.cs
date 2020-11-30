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
        public float Saldo { get; set; }
        public string Nome { get; set; }
    }
}
