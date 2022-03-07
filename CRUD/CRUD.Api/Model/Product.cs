using System.ComponentModel.DataAnnotations;

namespace CRUD.Api
{
    public class Product
    {
        [Key]
        public long Id { get; set; }
        public string Name { get; set; } = String.Empty;
        public string Description { get; set; } = String.Empty;
        public Double Weight { get; set; }
    }
}
