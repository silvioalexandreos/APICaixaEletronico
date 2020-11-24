using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataBase.Domain
{
    [Table("CaixaEletronico")]
    public class CaixaEletronico : BaseModel
    {
        [Key]
        public int Id { get; set; }
        public DateTime DataCadastro { get; set; }
        public bool Status { get; set; }
        public string Descricao { get; set; }
        public int QtdNotas2 { get; set; }
        public int QtdNotas5 { get; set; }
        public int QtdNotas10 { get; set; }
        public int QtdNotas20 { get; set; }
        public int QtdNotas50 { get; set; }
        public int QtdNotas100 { get; set; }
        public int QtdNotas200 { get; set; }

        public CaixaEletronico()
        {
            DataCadastro = DateTime.Now;
            Status = true;
        }
    }
}
