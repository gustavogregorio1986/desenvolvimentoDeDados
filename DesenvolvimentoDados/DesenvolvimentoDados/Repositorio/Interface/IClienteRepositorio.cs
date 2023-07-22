using DesenvolvimentoDados.Models;
using System.Collections.Generic;

namespace DesenvolvimentoDados.Repositorio.Interface
{
    public interface IClienteRepositorio
    {
        List<ClienteModel> ListarTodos();

        ClienteModel Adicionar(ClienteModel cliente);
    }
}
