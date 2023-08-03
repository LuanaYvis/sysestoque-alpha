using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sysestoque_alpha.Models
{
       public class NotaEntrada{
        [Key]
        public int IdNotaEntrada { get; set; }
        public DateTime dataEntrada { get; set; }
        public Fornecedor Fornecedor { get; set; } = new Fornecedor();
        public float ValorTotal { get; set; }

        //relações

        [ForeignKey(nameof(Usuario))]
        public int IdUsuarioResponsavel { get; set; }
        public Usuario Usuario { get; set; }


        // nota de entrada

        public ICollection<ItemEntrada> ItemEntrada { get; set;}=new List<ItemEntrada>();

       

    }
}
