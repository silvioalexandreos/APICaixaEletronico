using Dapper;
using Dapper.Contrib.Extensions;
using DataBase.Domain;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;

namespace Business.Repositorio
{
    public static class BaseRepositorio
    {
        public static List<T> QuerySql<T>(string sql, object parameter = null)
        {
            List<T> orderDetail;
            using (var connection = new SqlConnection("Data Source=LAPTOP-HU6IVHI5;Initial Catalog=DBCaixaEletronico;Integrated Security=True"))
            {
                orderDetail = connection.Query<T>(sql, parameter).ToList();
            }
            return orderDetail;
        }

        public static void Comando<T>(T objeto, bool editar = false, object parameter = null) where T : DataBase.Domain.BaseModel
        {
            using (var connection = new SqlConnection("Data Source=LAPTOP-HU6IVHI5;Initial Catalog=DBCaixaEletronico;Integrated Security=True"))
            {
                if (editar)
                    connection.Update(objeto);
                else                    
                    connection.Insert(objeto);
            }
        }

        public static void Delete<T>(int id) where T : BaseModel
        {
            using (var connection = new SqlConnection("Data Source=LAPTOP-HU6IVHI5;Initial Catalog=DBCaixaEletronico;Integrated Security=True"))
            {
                string query = $"select * from {typeof(T).Name} where id = @id";
                var objeto = connection.Query<T>(query, new { id });
                connection.Delete(objeto);
            }
        }
    }
}
