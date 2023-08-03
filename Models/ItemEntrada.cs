using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sysestoque_alpha.Models
{
    public class ItemEntrada{
        public NotaEntrada NotaEntrada { get; set; }
        public Produto Produto { get; set; }
        public int Quantidade { get; set; }
    }
}
