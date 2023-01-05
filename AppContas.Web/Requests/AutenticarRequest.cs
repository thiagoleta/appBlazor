using System.ComponentModel.DataAnnotations;

namespace AppContas.Web.Requests
{
    public class AutenticarRequest
    {
        [EmailAddress(ErrorMessage ="Por favor, informe um email válido.")]
        [Required(ErrorMessage ="Por favor, informe seu email.")]
        public string? Email { get; set; }
        [MinLength(8, ErrorMessage = "Por favor, informe no minimo {1} caracteres.")]
        [MaxLength(20, ErrorMessage ="Por favor, informe no maximo {1} caracteres.")]
        [Required]
        public string? Senha { get; set; }
    }
}
