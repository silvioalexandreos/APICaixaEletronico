using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataBase.Domain
{
    [Table("Transacao")]
    public class Transacao : BaseModel
    {
        [Key]
        public int Id { get; set; }
        public DateTime DataTransacao { get; set; }
        public string descricao { get; set; }
        public float Valor { get; set; }
        public int IdCliente { get; set; }
        public int IdCaixaEletronico { get; set; }

        public Transacao()
        {
            DataTransacao = DateTime.Now;
        }
    }
}
