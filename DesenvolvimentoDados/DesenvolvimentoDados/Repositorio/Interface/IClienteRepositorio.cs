using DesenvolvimentoDados.Models;
using System.Collections.Generic;

namespace DesenvolvimentoDados.Repositorio.Interface
{
    public interface IClienteRepositorio
    {
        ClienteModel ListarPorId(int id);

        List<ClienteModel> ListarTodos();

        ClienteModel Adicionar(ClienteModel cliente);

        ClienteModel Atualizar(ClienteModel cliente);

        bool Apagar(int id);

        ClienteModel ListarPorNome(string nome);
    }
}
