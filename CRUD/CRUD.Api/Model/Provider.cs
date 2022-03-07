using System.ComponentModel.DataAnnotations;

namespace CRUD.Api
{
    public class Provider
    {   
        [Key]
        public string Cnpj { get; set; } = string.Empty;
        public string Name { get; set; } = String.Empty;
        public string RegisterDate { get; set; } = String.Empty;
    }
}
