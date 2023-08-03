using Microsoft.EntityFrameworkCore;
using sysestoque_alpha.Models.Config;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sysestoque_alpha.Models
{
    [EntityTypeConfiguration(typeof(NotaSaidaConfig))]
    public class NotaSaida{

        public int Id { get; set; }
        public float valorTotal { get; set; }
        public DateTime dataSaida { get; set; } 
        
        public ICollection<ItemSaida>? ItensSaida { get; set; } = new List<ItemSaida>();
        public ICollection<Produto>? produtos { get; set; } = new List<Produto>();
    }
}
