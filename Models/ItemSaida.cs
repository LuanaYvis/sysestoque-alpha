using Microsoft.EntityFrameworkCore;
using sysestoque_alpha.Models.Config;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sysestoque_alpha.Models
{
    [EntityTypeConfiguration(typeof(ItemNotaSaidaConfig))]
    public class ItemSaida
    {

        [ForeignKey(nameof(Produto))]
        public int ProdutoId { get; set; }
        public Produto produto { get; set; } = new Produto();

       
        [ForeignKey(nameof(NotaSaida))]
        public int NotaSaidaId { get; set; }
        public NotaSaida? NotaSaida { get; set; }

        public float Quantidade { get; set; }
    }

}

