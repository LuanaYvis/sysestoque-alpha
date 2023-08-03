using System.ComponentModel.DataAnnotations;

namespace sysestoque_alpha.Models
{
    public class Usuario {
        [Key]
        [Required]

        public string Login { get; set; }
        [Required]
        public string HashSenha { get; set; }
        [Required]
        public string Nome { get; set; }
        [Required]
        public string Telefone { get; set;}
        [Required]
        public string Email { get; set;}
        
        //[Required]


        //lista nota de entrada
        //public ICollection<NotaEntrada> NotasEntrada { get; set; } = new List<NotaEntrada>();

    }
}