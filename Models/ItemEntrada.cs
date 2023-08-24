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
    [EntityTypeConfiguration(typeof(ItemEntradaConfig))]
    public class ItemEntrada{

        [ForeignKey(nameof(NotaEntrada))]
        public int NotaEntradaId { get; set; }

        public NotaEntrada? NotaEntrada { get; set; }

        
        [ForeignKey(nameof(Produto))]
        public int ProdutoId { get; set; }

        public Produto? Produto { get; set; }
 
        public float Quantidade { get; set; }

    }
}
