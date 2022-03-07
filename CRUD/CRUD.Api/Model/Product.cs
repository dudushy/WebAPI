namespace CRUD.Api
{
    public class Product
    {
        public long Id { get; set; }
        public string Name { get; set; } = String.Empty;
        public string Description { get; set; } = String.Empty;
        public Double Weight { get; set; }
    }
}
