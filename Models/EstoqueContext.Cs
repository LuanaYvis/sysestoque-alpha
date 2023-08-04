using Microsoft.EntityFrameworkCore;

namespace sysestoque_alpha.Models
{
    public class EstoqueContext : DbContext {

        public DbSet<Usuario> Usuario { get; set; }

        //public DbSet<NotaEntrada> NotaEntradas { get; set; }

        protected override void

            OnConfiguring(DbContextOptionsBuilder options){

                options.UseMySQL("Server=127.0.0.1;port=3306;database=estoque;uid=root;password=#Root2022");

        }
    }
}
