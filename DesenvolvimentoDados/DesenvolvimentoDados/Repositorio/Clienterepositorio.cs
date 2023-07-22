using DesenvolvimentoDados.Data;
using DesenvolvimentoDados.Models;
using DesenvolvimentoDados.Repositorio.Interface;
using System.Collections.Generic;
using System.Linq;

namespace DesenvolvimentoDados.Repositorio
{
    public class Clienterepositorio : IClienteRepositorio
    {
        private readonly BancoContext _context;

        public Clienterepositorio(BancoContext context)
        {
            _context = context;
        }

        public List<ClienteModel> ListarTodos()
        {
            return _context.Clientes.ToList();
        }

        public ClienteModel Adicionar(ClienteModel cliente)
        {
            _context.Clientes.Add(cliente);
            _context.SaveChanges();

            return cliente;
        }
    }
}
