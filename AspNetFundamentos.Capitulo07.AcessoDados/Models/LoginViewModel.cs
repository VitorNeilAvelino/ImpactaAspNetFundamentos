using System.ComponentModel.DataAnnotations;

namespace AspNetFundamentos.Capitulo07.AcessoDados.Models
{
    public class LoginViewModel
    {
        [Required]
        [StringLength(50)]
        public string Login { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [StringLength(20)]
        public string Senha { get; set; }
    }
}