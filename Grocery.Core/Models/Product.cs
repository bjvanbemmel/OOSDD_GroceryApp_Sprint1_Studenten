namespace Grocery.Core.Models
{
    public class Product : Model
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Stock { get; set; }
        public Product(int id, string name, int stock) : base(id, name)
        {
            Id = id;
            Name = name;
            Stock = stock;
        }
    }
}
