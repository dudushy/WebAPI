using System.ComponentModel.DataAnnotations;

namespace CRUD_API.Model
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
    }
}
