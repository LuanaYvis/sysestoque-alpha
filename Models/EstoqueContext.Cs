using Microsoft.EntityFrameworkCore;
using sysestoque_alpha.Models.Config;

namespace sysestoque_alpha.Models{
    public class EstoqueContext : DbContext {

        public DbSet<Usuario> Usuario { get; set; }
        public DbSet<NotaEntrada> NotaEntrada { get; set; }

        public DbSet<Fornecedor> Fornecedor { get; set; }

        public DbSet<ItemEntrada> ItemEntrada { get; set; }

        public DbSet<ItemSaida> ItemSaida { get; set; }
        
        public DbSet<NotaSaida> NotaSaida { get; set; }

        public DbSet<Produto> Produto { get; set; } 

        public DbSet<UnidadeMedida> UnidadeMedida { get; set; }

        public DbSet<Categoria> Categoria { get; set; }



        protected override void

            OnConfiguring(DbContextOptionsBuilder options) {

            options.UseMySQL("Server=192.168.30.68;port=3306;database=estoque_alfa;uid=user_estoque;password=#Root2022");
             
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder) {



            new ItemNotaSaidaConfig().Configure(modelBuilder.Entity<ItemSaida>());

            new ItemEntradaConfig().Configure(modelBuilder.Entity<ItemEntrada>());

            new NotaSaidaConfig().Configure(modelBuilder.Entity<NotaSaida>());

            new NotaEntradaConfig().Configure(modelBuilder.Entity<NotaEntrada>());

        }

            
    }


}
