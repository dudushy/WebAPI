using System.ComponentModel.DataAnnotations;

namespace CRUD.Api
{
    public class User
    {
        [Key]
        public string Cpf { get; set; } = string.Empty;
        public string Name { get; set; } = String.Empty;
        public string BirthDate { get; set; } = String.Empty;
        public string Email { get; set; } = String.Empty;
        public string Password { get; set; } = String.Empty;

    }
}
