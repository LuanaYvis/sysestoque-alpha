using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sysestoque_alpha.Models
{
    internal class Produto {

        public int Id { get; set; }
        public string Nome { get; set; }
        public float Estoque { get; set; }
        public float EstoqueMax { get; set; }
        public float EstoqueMedio { get; set; }
        public float EstoqueMin { get; set; }

;
    }
}
