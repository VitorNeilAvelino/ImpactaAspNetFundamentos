using System.ComponentModel.DataAnnotations;

namespace AspNetFundamentos.Capitulo04.Mvc.Models
{
    public class ContatoViewModel
    {
        [Required]
        public string Nome { get; set; }

        [Required]
        [EmailAddress]
        //[RegularExpression(@"\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*", ErrorMessage = "Email com formato inválido.")]
        public string Email { get; set; }

        [Required]
        public string Mensagem { get; set; }
    }
}