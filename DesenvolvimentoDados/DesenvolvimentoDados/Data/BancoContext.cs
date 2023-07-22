using DesenvolvimentoDados.Models;
using Microsoft.EntityFrameworkCore;

namespace DesenvolvimentoDados.Data
{
    public class BancoContext : DbContext
    {
        public BancoContext(DbContextOptions options)
            : base(options)
        {

        }

        public DbSet<ClienteModel> Clientes { get; set; }
    }
}
