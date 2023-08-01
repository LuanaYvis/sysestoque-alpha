using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sysestoque_alpha.Models
{
    internal class ItemSaida
    {
        public Produto produto { get; set; } = new Produto();
        public NotaSaida NotaSaida { get; set; }
        public float quantidade { get; set; }
    }
      
    }
}
