using System.ComponentModel.DataAnnotations;

namespace Api.Domain.Dtos.User
{
    public class UserDto
    {
        [Required(ErrorMessage = "Nome é campo obrigatório")]
        [StringLength(60, ErrorMessage = "Nome deve ter o máximo {1} caracteres.")]
        public string Nome { get; set; }
      
        [Required(ErrorMessage = "E-mail é um campo obrigatório para Login")]
        [EmailAddress(ErrorMessage = "E-mail em formato inválido")]
        [StringLength(100, ErrorMessage = "E-mail deve ter o máximo {1} caracteres.")]
        public string Email { get; set; }
    }
}