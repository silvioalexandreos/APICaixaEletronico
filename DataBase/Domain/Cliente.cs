using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataBase.Domain
{
    [Table("Cliente")]
    public class Cliente : BaseModel
    {
        [Key]
        public int Id { get; set; }
        public DateTime DataCadastro { get; set; }
        public bool Status { get; set; }
        public string Nome { get; set; }
        public float Saldo { get; set; }
    }
}
