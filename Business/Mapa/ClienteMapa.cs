using Business.Requisicao;
using Business.Response;
using DataBase.Domain;

namespace Business.Mapa
{
    public static class ClienteMapa
    {
        public static Cliente Mapa(ClienteRequisicao clienteRequisicao)
        {
            return new Cliente()
            {
                Id = clienteRequisicao.Id,
                DataCadastro = clienteRequisicao.DataCadastro,
                Status = clienteRequisicao.Status,
                Saldo = clienteRequisicao.Saldo,
                Nome = clienteRequisicao.Nome,

            };
        }

        public static ClienteResposta Mapa(Cliente cliente)
        {
            return new ClienteResposta()
            {
                Id = cliente.Id.ToString(),
                DataCadastro = cliente.DataCadastro.ToString(),
                Status = cliente.Status.ToString(),
                Saldo = cliente.Saldo,
                Nome = cliente.Nome,
            };
        }
    }
}
