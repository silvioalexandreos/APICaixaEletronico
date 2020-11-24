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
                Tipo = clienteRequisicao.Tipo,
                Conta = clienteRequisicao.Conta,
                Saldo = clienteRequisicao.Saldo,
                Nome = clienteRequisicao.Nome,
                CPF = clienteRequisicao.CPF,
                NomeFantasia = clienteRequisicao.NomeFantasia,
                CNPJ = clienteRequisicao.CNPJ
            };
        }

        public static ClienteResposta Mapa(Cliente cliente)
        {
            return new ClienteResposta()
            {
                Id = cliente.Id.ToString(),
                DataCadastro = cliente.DataCadastro.ToString(),
                Status = cliente.Status.ToString(),
                Tipo = cliente.Tipo.ToString(),
                Conta = cliente.Conta.ToString(),
                Saldo = cliente.Saldo.ToString(),
                Nome = cliente.Nome,
                CPF = cliente.CPF,
                NomeFantasia = cliente.NomeFantasia,
                CNPJ = cliente.CNPJ
            };
        }
    }
}
