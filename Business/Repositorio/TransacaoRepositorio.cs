using DataBase.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Repositorio
{
    public class TransacaoRepositorio
    {
        public static void Gravar(Transacao transacao)
        {

            BaseRepositorio.Comando(transacao);
        }

        public static void Atualizar(Transacao transacao)
        {
            BaseRepositorio.Comando(transacao, true);
        }

        public static List<Transacao> Buscar(int id = 0, string descricao = "")
        {
            string sql = "select * from Transacao";

            if (id > 0)
            {
                sql += " where idTransacao = @id";
            }

            if (!string.IsNullOrEmpty(descricao))
            {
                if (sql.Contains("where"))
                {
                    sql += " and nome like @descricao";
                }
                else
                {
                    sql += " where nome like @descricao";
                }
            }
            var retorno = BaseRepositorio.QuerySql<Transacao>(sql, new { id, descricao = "%" + descricao + "%" });

            return retorno;
        }
        //Buscar Transação por ID
        public static List<Transacao> BuscarTransacaoClienteId(int clienteid = 1, string descricao = "")
        {
            //string sql = "select * from Transacao";

            string sql = "select * from Cliente c join Transacao t on c.id = t.IdCliente";

            if (clienteid > 0)
            {
                sql += " where idTransacao = @id";
            }

            if (!string.IsNullOrEmpty(descricao))
            {
                if (sql.Contains("where"))
                {
                    sql += " and nome like @descricao";
                }
                else
                {
                    sql += " where nome like @descricao";
                }
            }
            var retorno = BaseRepositorio.QuerySql<Transacao>(sql, new { clienteid, descricao = "%" + descricao + "%" });

            return retorno;
        }

        public static void Delete(int id)
        {
            BaseRepositorio.Delete<Cliente>(id);
        }
    }
}
