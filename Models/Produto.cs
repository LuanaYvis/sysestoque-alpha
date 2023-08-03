using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sysestoque_alpha.Models
{
    public class Produto {
        [Key]

        public int Id { get; set; }
        public string Nome { get; set; }
        public float Estoque { get; set; }
        public float EstoqueMax { get; set; }
        public float EstoqueMedio { get; set; }
        public float EstoqueMin { get; set; }


        [ForeignKey(nameof(Categoria))]
        public int CategoriaId { get; set; }
        public Categoria Categoria { get; set; }

        [ForeignKey(nameof(UnidadeMedida))]
        public int UnidadeMedida { get; set; }
        public Categoria UnidadeMedia { get; set; }

        
   
        //notas de entrada

        public ICollection<ItemEntrada> ItensEntrada { get; set; } = new List<ItemEntrada>();

        public ICollection<NotaEntrada>? NotasEntrada { get; set; } = new List<NotaEntrada>();

        public ICollection<NotaSaida>? NotaSaida { get; set; } = new List<NotaSaida>();

        public ICollection<ItemSaida>? ItensSaida { get; set; } = new List<ItemSaida>();

        public ICollection<Fornecedor>? Fornecedor { get; set; }= new List<Fornecedor>();

        public ICollection<UnidadeMedida>? UnidadesMedia { get; set; } = new List<UnidadeMedida>();

    }
}
