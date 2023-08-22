using Microsoft.EntityFrameworkCore;

namespace sysestoque_alpha.Models
{
    public class EstoqueContext : DbContext {

        public DbSet<Usuario> Usuario { get; set; }

        //public DbSet<NotaEntrada> NotaEntradas { get; set; }

        protected override void

            OnConfiguring(DbContextOptionsBuilder options){

                options.UseMySQL("Server=192.168.30.68;port=3306;database=estoque_alfa;uid=root;password=#Root2022");

        }
    }
}
