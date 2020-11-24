using DataBase.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Repositorio
{
    public class CaixaEletronicoRepositorio
    {
        public static void Gravar(CaixaEletronico caixa)
        {
            BaseRepositorio.Comando(caixa);
        }

        public static void Atualizar(CaixaEletronico caixa)
        {
            BaseRepositorio.Comando(caixa, true);
        }

        public static List<CaixaEletronico> Buscar(int id = 0, string descricao = "")
        {
            string sql = "select * from CaixaEletronico";

            if (id > 0)
            {
                sql += " where idCaixaEletronico = @id";
            }

            if (!string.IsNullOrEmpty(descricao))
            {
                if (sql.Contains("where"))
                {
                    sql += " and descricao like @descricao";
                }
                else
                {
                    sql += " where descricao like @descricao";
                }
            }
            var retorno = BaseRepositorio.QuerySql<CaixaEletronico>(sql, new { id, descricao = "%" + descricao + "%" });

            return retorno;
        }

        public static void Delete(int id)
        {
            BaseRepositorio.Delete<CaixaEletronico>(id);
        }
    }
}
