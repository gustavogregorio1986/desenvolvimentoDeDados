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

        public ClienteModel ListarPorId(int id)
        {
            return _context.Clientes.FirstOrDefault(x => x.Id == id);
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

        public ClienteModel Atualizar(ClienteModel cliente)
        {
            ClienteModel clienteDb = ListarPorId(cliente.Id);

            if (clienteDb == null) throw new System.Exception("Houve um erro na atualização do cliente");

            clienteDb.Nome = cliente.Nome;
            clienteDb.Email = cliente.Email;
            clienteDb.Cpf = cliente.Cpf;
            clienteDb.Profissao = cliente.Profissao;

            _context.Clientes.Update(clienteDb);
            _context.SaveChanges();

            return clienteDb;
        }

        public bool Apagar(int id)
        {
            ClienteModel clientedb = ListarPorId(id);

            if (clientedb == null) throw new System.Exception("Houve um erro na deleção do cliente");

            _context.Clientes.Remove(clientedb);
            _context.SaveChanges();

            return true;
        }

        public ClienteModel ListarPorNome(string nome)
        {
            return _context.Clientes.FirstOrDefault(x => x.Nome == nome);
        }
    }
}
