using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sysestoque_alpha.Models
{
    public class Fornecedor {
        [Key]
        public string? cnpj { get; set; }
        public string? Nome { get; set; }
        public string? endereco { get; set; }
        public string? email { get; set; }
        public string? fone { get; set; }


        public ICollection<Produto> Produtos {get; set;} = new List <Produto>();
        public ICollection<NotaEntrada> NotasEntrada { get; set; } = new List<NotaEntrada>();
                
    }
}
