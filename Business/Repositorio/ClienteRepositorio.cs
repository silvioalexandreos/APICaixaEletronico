using DataBase.Domain;
using System.Collections.Generic;


namespace Business.Repositorio
{
    
    public static class ClienteRepositorio
    {
        public static void Gravar(Cliente cliente)
        {
            
            BaseRepositorio.Comando(cliente);
        }

        public static void Atualizar(Cliente cliente)
        {
            BaseRepositorio.Comando(cliente, true);
        }

        public static List<Cliente> Buscar(int id = 0, string nome = "")
        {
            string sql = "select * from Cliente";

            if (id > 0)
            {
                sql += " where idCliente = @id";
            }

            if (!string.IsNullOrEmpty(nome))
            {
                if (sql.Contains("where"))
                {
                    sql += " and nome like @nome";
                }
                else
                {
                    sql += " where nome like @nome";
                }              
            }
            var retorno = BaseRepositorio.QuerySql<Cliente>(sql, new { id, nome = "%" + nome + "%" });

            return retorno;
        }

        public static void Delete(int id)
        {
            BaseRepositorio.Delete<Cliente>(id);
        }
    }
}
